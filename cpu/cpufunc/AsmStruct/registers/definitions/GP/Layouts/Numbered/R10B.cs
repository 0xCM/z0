//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 20110
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
        public struct R10B : IGpReg8<R10B>
        {
            [FieldOffset(0)]
            byte content;

            public const GpRegId Id = GpRegId.r10b;          

            [MethodImpl(Inline)]
            public static byte operator !(R10B r)
                => r.content;

            [MethodImpl(Inline)]
            public static implicit operator R10B(byte src)
                => new R10B(src);            

            [MethodImpl(Inline)]
            public R10B(byte src)
                => this.content = src;

            GpRegId IGpReg.Id 
                => Id; 
        }
    }
}