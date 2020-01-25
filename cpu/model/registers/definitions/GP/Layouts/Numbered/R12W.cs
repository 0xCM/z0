//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 20121
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
        public struct R12W : IGpReg16<R12W>
        {

            [FieldOffset(0)]
            ushort content;

            [FieldOffset(0)]
            R12B r12b;

            public const GpRegId Id = GpRegId.r12w;            

            [MethodImpl(Inline)]
            public static implicit operator ushort(R12W src)
                => src.content;

            [MethodImpl(Inline)]
            public static implicit operator R12W(ushort src)
                => new R12W(src);

            [MethodImpl(Inline)]
            public R12W(ushort src)
                : this()
            {
                content = src;
            }
            byte IGpReg16<R12W>.Lo8 
            { 
                [MethodImpl(Inline)]
                get => !r12b; 
 
                [MethodImpl(Inline)]
                set => r12b = value;
            }

            GpRegId IGpReg.Id 
                => Id;
       }
    }
}