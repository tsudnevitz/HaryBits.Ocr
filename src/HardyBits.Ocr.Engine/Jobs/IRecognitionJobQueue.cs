﻿using System;
using System.Threading.Tasks;
using HardyBits.Ocr.Engine.Results;
using HardyBits.Wrappers.Tesseract.Results;

namespace HardyBits.Ocr.Engine.Jobs
{
  internal interface IRecognitionJobQueue : IDisposable
  {
    Task<IRecognitionResults> EnqueueAsync(IRecognitionJob recognitionJob);
  }
}