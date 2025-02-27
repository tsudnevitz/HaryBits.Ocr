﻿using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using HardyBits.Ocr.Engine.IO;
using HardyBits.Ocr.Engine.Preprocessing;
using HardyBits.Ocr.Engine.Results;
using HardyBits.Wrappers.Leptonica.Internals;
using HardyBits.Wrappers.Tesseract.Factories;

namespace HardyBits.Ocr.Engine.Jobs
{
  public class BitmapRecognitionJob : IRecognitionJob
  {
    private readonly IStoredImageFile _imageFile;
    private readonly IPixFactory _pixFactory;
    private readonly IConfiguredTesseractEngineFactory _engineFactory;
    private readonly IEnumerable<IPreprocessor> _preprocessors;

    public BitmapRecognitionJob(IConfiguredTesseractEngineFactory engineFactory, IStoredImageFile imageFile, IEnumerable<IPreprocessor> preprocessors, IPixFactory pixFactory)
    {
      _engineFactory = engineFactory ?? throw new ArgumentNullException(nameof(engineFactory));
      _imageFile = imageFile ?? throw new ArgumentNullException(nameof(imageFile));
      _preprocessors = preprocessors ?? throw new ArgumentNullException(nameof(preprocessors));
      _pixFactory = pixFactory ?? throw new ArgumentNullException(nameof(pixFactory));
    }

    public Task<IRecognitionResults> ExecuteAsync()
    {
      // ToDo: preserve image order
      // ToDo: make async
      var pixes = _pixFactory.Create(_imageFile.Path);

      var results = new RecognitionResults();
      var options = new ParallelOptions{ MaxDegreeOfParallelism = 10 };
      Parallel.ForEach(pixes, options, pix =>
      {
        IPix preprocessedPix;
        using (pix) preprocessedPix = Preprocess(pix);

        using (preprocessedPix)
        {
          using var engine = _engineFactory.Create();
          var result = engine.Process(preprocessedPix);
          var recognitionResult = new RecognitionResult(result);
          results.BlockingAdd(recognitionResult);
        }
      });

      return Task.FromResult<IRecognitionResults>(results);
    }

    private IPix Preprocess(IPix pix)
    {
      IPix result = null;
      foreach (var preprocessor in _preprocessors)
        result = preprocessor.Run(pix);
      return result;
    }
  }
}