//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.CpuModel
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
            byte content;

            public const GpRegId Id = GpRegId.bh;            

            [MethodImpl(Inline)]
            public static byte operator !(BH r)
                => r.content;

            [MethodImpl(Inline)]
            public static implicit operator BH(byte src)
                => new BH(src);

            [MethodImpl(Inline)]
            public BH(byte src)
                => content = src;

            GpRegId IGpReg.Id 
                => Id;
        }
    }
}