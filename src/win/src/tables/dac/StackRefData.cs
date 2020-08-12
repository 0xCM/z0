//-----------------------------------------------------------------------------
// Derivative Work
// Copyright  : Microsoft/.Net foundation
// Copyright  : (c) Chris Moore, 2020
// License    :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Dac
{
    using System;
    using System.Runtime.InteropServices;

    [StructLayout(LayoutKind.Sequential)]
    public struct StackRefData
    {
        public uint HasRegisterInformation;

        public int Register;

        public int Offset;

        public ClrDataAddress Address;

        public ClrDataAddress Object;

        public uint Flags;

        public uint SourceType;

        public ClrDataAddress Source;

        public ClrDataAddress StackPointer;
    }
}