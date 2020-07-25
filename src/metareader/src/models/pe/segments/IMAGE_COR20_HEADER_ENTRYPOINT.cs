//-----------------------------------------------------------------------------
// Derivative Work
// Copyright  : Microsft/.Net foundation
// Copyright  : (c) Chris Moore, 2020
// License    :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.InteropServices;

    partial struct PeFile
    {
        [StructLayout(LayoutKind.Explicit)]
        public struct IMAGE_COR20_HEADER_ENTRYPOINT
        {
            [FieldOffset(0)]
            public readonly uint Token;
            [FieldOffset(0)]
            public readonly uint RVA;
        }        
    }
}