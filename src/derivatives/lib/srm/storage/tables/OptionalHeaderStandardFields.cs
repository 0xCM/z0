//-----------------------------------------------------------------------------
// Derivative Work
// Copyright  : Microsoft/.Net foundation
// Copyright  : (c) Chris Moore, 2020
// License    :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Derivatives.SRM
{
    using System;
    using System.Runtime.InteropServices;

    [StructLayout(LayoutKind.Sequential)]
    public struct OptionalHeaderStandardFields
    {
        public PEMagic PEMagic;

        public byte MajorLinkerVersion;

        public byte MinorLinkerVersion;

        public int SizeOfCode;

        public int SizeOfInitializedData;

        public int SizeOfUninitializedData;

        public int RVAOfEntryPoint;

        public int BaseOfCode;

        public int BaseOfData;
    }
}