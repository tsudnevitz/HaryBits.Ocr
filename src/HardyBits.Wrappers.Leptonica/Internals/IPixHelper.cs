﻿using System;
using HardyBits.Wrappers.Leptonica.Enums;

namespace HardyBits.Wrappers.Leptonica.Internals
{
  public interface IPixHelper
  {
    ImageFileFormat GetFileFormat(ReadOnlySpan<byte> span);
  }
}
