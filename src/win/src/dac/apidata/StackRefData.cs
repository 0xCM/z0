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
    public readonly struct StackRefData
    {
        public readonly uint HasRegisterInformation;

        public readonly int Register;

        public readonly int Offset;

        public readonly ClrDataAddress Address;

        public readonly ClrDataAddress Object;

        public readonly uint Flags;

        public readonly uint SourceType;

        public readonly ClrDataAddress Source;

        public readonly ClrDataAddress StackPointer;
    }
}