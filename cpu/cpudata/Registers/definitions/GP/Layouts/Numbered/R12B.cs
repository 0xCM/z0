//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 20121
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
        public struct R12B : IGpReg8<R12B>
        {
            [FieldOffset(0)]
            byte content;

            public const GpRegId Id = GpRegId.r12b;          

            [MethodImpl(Inline)]
            public static byte operator !(R12B r)
                => r.content;

            [MethodImpl(Inline)]
            public static implicit operator R12B(byte src)
                => new R12B(src);            

            [MethodImpl(Inline)]
            public R12B(byte src)
                => this.content = src;

            GpRegId IGpReg.Id 
                => Id; 
        }
    }
}