﻿using System;
using System.Runtime.InteropServices;
using HardyBits.Wrappers.Leptonica.Constants;
using HardyBits.Wrappers.Leptonica.Enums;

namespace HardyBits.Wrappers.Leptonica.Imports
{
  internal static class Leptonica5Pix
  {
    [DllImport(LibraryNames.Leptonica5, CallingConvention = CallingConvention.Cdecl, EntryPoint = nameof(pixCreate))]
    public static extern IntPtr pixCreate(int width, int height, int depth);

    [DllImport(LibraryNames.Leptonica5, CallingConvention = CallingConvention.Cdecl, EntryPoint = nameof(pixGetColormap))]
    public static extern IntPtr pixGetColormap(HandleRef pix);

    [DllImport(LibraryNames.Leptonica5, CallingConvention = CallingConvention.Cdecl, EntryPoint = nameof(pixSetColormap))]
    public static extern int pixSetColormap(HandleRef pix, HandleRef colormap);

    [DllImport(LibraryNames.Leptonica5, CallingConvention = CallingConvention.Cdecl, EntryPoint = nameof(pixDestroyColormap))]
    public static extern int pixDestroyColormap(HandleRef pix);
    
    [DllImport(LibraryNames.Leptonica5, CallingConvention = CallingConvention.Cdecl, EntryPoint = nameof(pixGetXRes))]
    public static extern int pixGetXRes(HandleRef pix);
    
    [DllImport(LibraryNames.Leptonica5, CallingConvention = CallingConvention.Cdecl, EntryPoint = nameof(pixSetXRes))]
    public static extern int pixSetXRes(HandleRef pix, int res);
    
    [DllImport(LibraryNames.Leptonica5, CallingConvention = CallingConvention.Cdecl, EntryPoint = nameof(pixGetYRes))]
    public static extern int pixGetYRes(HandleRef pix);
    
    [DllImport(LibraryNames.Leptonica5, CallingConvention = CallingConvention.Cdecl, EntryPoint = nameof(pixSetYRes))]
    public static extern int pixSetYRes(HandleRef pix, int res);
    
    [DllImport(LibraryNames.Leptonica5, CallingConvention = CallingConvention.Cdecl, EntryPoint = nameof(pixDestroy))]
    public static extern void pixDestroy(ref IntPtr pix);
    
    [DllImport(LibraryNames.Leptonica5, CallingConvention = CallingConvention.Cdecl, EntryPoint = nameof(pixcmapCreate))]
    public static extern IntPtr pixcmapCreate(int depth);
    
    [DllImport(LibraryNames.Leptonica5, CallingConvention = CallingConvention.Cdecl, EntryPoint = nameof(pixcmapAddColor))]
    public static extern int pixcmapAddColor(HandleRef cmap, int rval, int gval, int bval);

    [DllImport(LibraryNames.Leptonica5, CallingConvention = CallingConvention.Cdecl, EntryPoint = nameof(pixcmapDestroy))]
    public static extern void pixcmapDestroy(ref IntPtr pcmap);

    [DllImport(LibraryNames.Leptonica5, CallingConvention = CallingConvention.Cdecl, EntryPoint = nameof(pixGetData))]
    public static extern IntPtr pixGetData(HandleRef pix);

    [DllImport(LibraryNames.Leptonica5, CallingConvention = CallingConvention.Cdecl, EntryPoint = nameof(pixGetWpl))]
    public static extern int pixGetWpl(HandleRef pix);

    [DllImport(LibraryNames.Leptonica5, CallingConvention = CallingConvention.Cdecl, EntryPoint = nameof(findFileFormat))]
    public static extern int findFileFormat(string filename, out ImageFileFormat pformat);

    [DllImport(LibraryNames.Leptonica5, CallingConvention = CallingConvention.Cdecl, EntryPoint = nameof(findFileFormatBuffer))]
    public static extern unsafe int findFileFormatBuffer(void* buf, out ImageFileFormat pformat);

    [DllImport(LibraryNames.Leptonica5, CallingConvention = CallingConvention.Cdecl, EntryPoint = nameof(pixRead))]
    public static extern IntPtr pixRead(string filename);

    [DllImport(LibraryNames.Leptonica5, CallingConvention = CallingConvention.Cdecl, EntryPoint = nameof(pixGetWidth))]
    public static extern int pixGetWidth(HandleRef pix);

    [DllImport(LibraryNames.Leptonica5, CallingConvention = CallingConvention.Cdecl, EntryPoint = nameof(pixGetHeight))]
    public static extern int pixGetHeight(HandleRef pix);

    [DllImport(LibraryNames.Leptonica5, CallingConvention = CallingConvention.Cdecl, EntryPoint = nameof(pixGetDepth))]
    public static extern int pixGetDepth(HandleRef pix);

    [DllImport(LibraryNames.Leptonica5, CallingConvention = CallingConvention.Cdecl, EntryPoint = nameof(pixaReadMemMultipageTiff))]
    public static extern unsafe IntPtr pixaReadMemMultipageTiff(void* data, int size);
    
    [DllImport(LibraryNames.Leptonica5, CallingConvention = CallingConvention.Cdecl, EntryPoint = nameof(pixaReadMultipageTiff))]
    public static extern unsafe IntPtr pixaReadMultipageTiff(string filename);
    
    [DllImport(LibraryNames.Leptonica5, CallingConvention = CallingConvention.Cdecl, EntryPoint = nameof(pixReadMem))]
    public static extern unsafe IntPtr pixReadMem(void* data, int size);
    
    [DllImport(LibraryNames.Leptonica5, CallingConvention = CallingConvention.Cdecl, EntryPoint = nameof(pixaGetCount))]
    public static extern int pixaGetCount(IntPtr pixa);
    
    [DllImport(LibraryNames.Leptonica5, CallingConvention = CallingConvention.Cdecl, EntryPoint = nameof(pixaGetPix))]
    public static extern IntPtr pixaGetPix(IntPtr pixa, int index, int accesstype);

    [DllImport(LibraryNames.Leptonica5, CallingConvention = CallingConvention.Cdecl, EntryPoint = nameof(pixClone))]
    public static extern IntPtr pixClone(HandleRef pixs);

    [DllImport(LibraryNames.Leptonica5, CallingConvention = CallingConvention.Cdecl, EntryPoint = nameof(pixaCreate))]
    public static extern IntPtr pixaCreate(int n);
    
    [DllImport(LibraryNames.Leptonica5, CallingConvention = CallingConvention.Cdecl, EntryPoint = nameof(pixaDestroy))]
    public static extern void pixaDestroy(ref IntPtr pix);

    [DllImport(LibraryNames.Leptonica5, CallingConvention = CallingConvention.Cdecl, EntryPoint = nameof(pixaAddPix))]
    public static extern int pixaAddPix(IntPtr pixa, IntPtr pix, int copyflag);

    [DllImport(LibraryNames.Leptonica5, CallingConvention = CallingConvention.Cdecl, EntryPoint = nameof(pixaWriteMultipageTiff))]
    public static extern int pixaWriteMultipageTiff(string fname, IntPtr pixa);
    
    [DllImport(LibraryNames.Leptonica5, CallingConvention = CallingConvention.Cdecl, EntryPoint = nameof(boxaCreate))]
    public static extern IntPtr boxaCreate(int n);
    
    [DllImport(LibraryNames.Leptonica5, CallingConvention = CallingConvention.Cdecl, EntryPoint = nameof(boxaDestroy))]
    public static extern void boxaDestroy(ref IntPtr pboxa);
    
    [DllImport(LibraryNames.Leptonica5, CallingConvention = CallingConvention.Cdecl, EntryPoint = nameof(boxaAddBox))]
    public static extern int boxaAddBox(IntPtr boxa, IntPtr box, int copyflag);

    [DllImport(LibraryNames.Leptonica5, CallingConvention = CallingConvention.Cdecl, EntryPoint = nameof(boxDestroy))]
    public static extern void boxDestroy(ref IntPtr pboxa);
  }
}