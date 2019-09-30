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
        public struct R9B : IGpReg8<R9B>
        {
            [FieldOffset(0)]
            byte content;

            public const GpRegId Id = GpRegId.r9b;          

            [MethodImpl(Inline)]
            public static byte operator !(R9B r)
                => r.content;

            [MethodImpl(Inline)]
            public static implicit operator R9B(byte src)
                => new R9B(src);            

            [MethodImpl(Inline)]
            public R9B(byte src)
                => this.content = src;

            GpRegId IGpReg.Id 
                => Id; 
        }
    }
}