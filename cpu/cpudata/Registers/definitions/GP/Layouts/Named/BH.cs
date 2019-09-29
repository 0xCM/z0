//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
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
        public struct BH : IGpReg8<BH>
        {
            [FieldOffset(0)]
            public byte bh;

            public const GpRegId Id = GpRegId.bh;            

            /// <summary>
            /// Dereferences bh to produce its content [bh]
            /// </summary>
            /// <param name="r">The source register</param>
            [MethodImpl(Inline)]
            public static byte operator !(BH r)
                => r.bh;

            [MethodImpl(Inline)]
            public static implicit operator BH(byte src)
                => new BH(src);

            [MethodImpl(Inline)]
            public BH(byte src)
                => bh = src;

            GpRegId IGpReg.Id 
                => Id;
        }
    }
}