//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 20151
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
        public struct R15B : IGpReg8<R15B>
        {
            [FieldOffset(0)]
            byte content;

            public const GpRegId Id = GpRegId.r15b;          

            [MethodImpl(Inline)]
            public static byte operator !(R15B r)
                => r.content;

            [MethodImpl(Inline)]
            public static implicit operator R15B(byte src)
                => new R15B(src);            

            [MethodImpl(Inline)]
            public R15B(byte src)
                => this.content = src;

            GpRegId IGpReg.Id 
                => Id; 
        }
    }
}