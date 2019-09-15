﻿namespace HardyBits.Wrappers.Tesseract.Results
{
  public class RecognitionResult : IRecognitionResult
  {
    public string Text { get; set; }
    public string HocrText { get; set; }
    public float? Confidence { get; set; }

    public void Dispose()
    {
      // nothing to dispose yet
    }
  }
}