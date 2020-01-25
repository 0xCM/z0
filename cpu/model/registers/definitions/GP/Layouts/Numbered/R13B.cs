//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 20131
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
        public struct R13B : IGpReg8<R13B>
        {
            [FieldOffset(0)]
            byte content;

            public const GpRegId Id = GpRegId.r13b;          

            [MethodImpl(Inline)]
            public static byte operator !(R13B r)
                => r.content;

            [MethodImpl(Inline)]
            public static implicit operator R13B(byte src)
                => new R13B(src);            

            [MethodImpl(Inline)]
            public R13B(byte src)
                => this.content = src;

            GpRegId IGpReg.Id 
                => Id; 
        }
    }
}