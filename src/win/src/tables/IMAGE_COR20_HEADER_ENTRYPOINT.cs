//-----------------------------------------------------------------------------
// Derivative Work
// Copyright  : Microsoft/.Net foundation
// Copyright  : (c) Chris Moore, 2020
// License    :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Image
{
    using System;
    using System.Runtime.InteropServices;

    [Table, StructLayout(LayoutKind.Explicit)]
    public struct IMAGE_COR20_HEADER_ENTRYPOINT
    {
        [FieldOffset(0)]
        public readonly uint Token;
        
        [FieldOffset(0)]
        public readonly uint RVA;
    }        
}