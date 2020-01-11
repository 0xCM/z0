//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    
    using static zfunc;

    partial class Registers
    {
        [StructLayout(LayoutKind.Explicit)]
        public struct BPL : IGpReg8<BPL>
        {
            [FieldOffset(0)]
            byte content;

            public const GpRegId Id = GpRegId.bpl;

            [MethodImpl(Inline)]
            public static byte operator !(BPL r)
                => r.content;

            [MethodImpl(Inline)]
            public static implicit operator BPL(byte src)
                => new BPL(src);

            [MethodImpl(Inline)]
            public BPL(byte src)
                : this()
            {
                content = src;
            }
            
            GpRegId IGpReg.Id 
                => Id;
        }
    }
}