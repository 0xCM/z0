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
        public struct AL : IGpReg8<AL>
        {
            [FieldOffset(0)]
            internal byte content;

            public const GpRegId Id = GpRegId.al;            

            [MethodImpl(Inline)]
            public static byte operator !(AL r)
                => r.content;

            [MethodImpl(Inline)]
            public static implicit operator AL(byte src)
                => new AL(src);

            [MethodImpl(Inline)]
            public AL(byte src)
                =>content = src;

            GpRegId IGpReg.Id 
                => Id;
        }
    }
}