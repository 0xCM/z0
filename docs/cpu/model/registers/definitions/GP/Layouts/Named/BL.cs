//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.CpuModel
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    
    using static Root;
    
    partial class Registers
    {
        [StructLayout(LayoutKind.Explicit)]
        public struct BL : IGpReg8<BL>
        {
            [FieldOffset(0)]
            byte content;

            public const GpRegId Id = GpRegId.bl;            

            [MethodImpl(Inline)]
            public static byte operator !(BL r)
                => r.content;

            [MethodImpl(Inline)]
            public static implicit operator BL(byte src)
                => new BL(src);

            [MethodImpl(Inline)]
            public BL(byte src)
                => content = src;
                
            GpRegId IGpReg.Id 
                => Id;
        }
    }
}