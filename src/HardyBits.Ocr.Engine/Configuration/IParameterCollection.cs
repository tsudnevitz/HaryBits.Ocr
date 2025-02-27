﻿using System.Collections.Generic;

namespace HardyBits.Ocr.Engine.Configuration
{
  public interface IParameterCollection : IReadOnlyDictionary<string, IParameterValue>
  {
    bool TryGetValue<T>(string key, out T value);
    T GetValue<T>(string key);
  }
}