//-----------------------------------------------------------------------------
// Derivative Work
// Copyright  : Microsft/.Net foundation
// Copyright  : (c) Chris Moore, 2020
// License    :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Image
{
    using System;
    using System.Runtime.InteropServices;

    [StructLayout(LayoutKind.Sequential)]
    [Table]
    public struct IMAGE_COR_ILMETHOD
    {
        public uint FlagsSizeStack;
        
        public uint CodeSize;
        
        public uint LocalVarSignatureToken;

        public const uint FormatShift = 3;
        
        public const uint FormatMask = (uint)(1 << (int)FormatShift) - 1;
        
        public const uint TinyFormat = 0x2;
        
        public const uint mdSignatureNil = 0x11000000;
    }
}