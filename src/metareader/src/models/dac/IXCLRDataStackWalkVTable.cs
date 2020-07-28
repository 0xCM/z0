//-----------------------------------------------------------------------------
// Derivative Work
// Copyright  : Microsft/.Net foundation
// Copyright  : (c) Chris Moore, 2020
// License    :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Dac
{
    using System;
    using System.Runtime.InteropServices;

    [StructLayout(LayoutKind.Sequential)]
    internal readonly struct IXCLRDataStackWalkVTable
    {
        public readonly IntPtr GetContext;

        private readonly IntPtr GetContext2;

        public readonly IntPtr Next;

        private readonly IntPtr GetStackSizeSkipped;

        private readonly IntPtr GetFrameType;

        public readonly IntPtr GetFrame;

        public readonly IntPtr Request;

        private readonly IntPtr SetContext2;
    }
}