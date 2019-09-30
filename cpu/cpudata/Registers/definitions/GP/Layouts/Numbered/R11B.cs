//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 20111
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
        public struct R11B : IGpReg8<R11B>
        {
            [FieldOffset(0)]
            byte content;

            public const GpRegId Id = GpRegId.r11b;          

            [MethodImpl(Inline)]
            public static byte operator !(R11B r)
                => r.content;

            [MethodImpl(Inline)]
            public static implicit operator R11B(byte src)
                => new R11B(src);            

            [MethodImpl(Inline)]
            public R11B(byte src)
                => this.content = src;

            GpRegId IGpReg.Id 
                => Id; 
        }
    }
}