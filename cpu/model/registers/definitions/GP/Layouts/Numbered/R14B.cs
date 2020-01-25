//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 20141
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
        public struct R14B : IGpReg8<R14B>
        {
            [FieldOffset(0)]
            byte content;

            public const GpRegId Id = GpRegId.r14b;          

            [MethodImpl(Inline)]
            public static byte operator !(R14B r)
                => r.content;

            [MethodImpl(Inline)]
            public static implicit operator R14B(byte src)
                => new R14B(src);            

            [MethodImpl(Inline)]
            public R14B(byte src)
                => this.content = src;

            GpRegId IGpReg.Id 
                => Id; 
        }
    }
}