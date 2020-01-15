﻿using System;
using System.Runtime.InteropServices;

namespace GigeVision.Core
{
    public static class CvInterop64
    {
        private const string libraryPath = "runtimes\\win-x64\\native\\StreamRxCpp.dll";

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void ProgressCallback(int value);

        [DllImport(libraryPath, SetLastError = true, CallingConvention = CallingConvention.Cdecl)]
        public static extern bool Start(int port, out IntPtr imageDataAddress, int width, int height, int packetLengthToSet,
        [MarshalAs(UnmanagedType.FunctionPtr)] ProgressCallback frameReady);

        [DllImport(libraryPath, SetLastError = true, CallingConvention = CallingConvention.Cdecl)]
        public static extern bool Stop();

        [DllImport(libraryPath, SetLastError = true, CallingConvention = CallingConvention.Cdecl)]
        public static extern ulong GetCurrentInvalidFrameCounter();

        [DllImport(libraryPath, SetLastError = true, CallingConvention = CallingConvention.Cdecl)]
        public static extern ulong GetCurrentValidFrameCounter();

        [DllImport(libraryPath, SetLastError = true, CallingConvention = CallingConvention.Cdecl)]
        public static extern bool GetProcessedFrame(long port, out IntPtr imageDataAddress, ProgressCallback frameReady);

        [DllImport(libraryPath, SetLastError = true, CallingConvention = CallingConvention.Cdecl)]
        public static extern bool GetRawFrame(long port, string multicastGroupIP, out IntPtr imageDataAddress, ProgressCallback frameReady);
    }
}