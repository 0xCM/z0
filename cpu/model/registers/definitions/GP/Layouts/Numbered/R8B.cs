//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2018
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
        public struct R8B : IGpReg8<R8B>
        {
            [FieldOffset(0)]
            byte content;

            public const GpRegId Id = GpRegId.r8b;

            [MethodImpl(Inline)]
            public static byte operator !(R8B r)
                => r.content;

            [MethodImpl(Inline)]
            public static implicit operator R8B(byte src)
                => new R8B(src);            

            [MethodImpl(Inline)]
            public R8B(byte src)
                => this.content = src;

            GpRegId IGpReg.Id 
                => Id;

        }
    }
}