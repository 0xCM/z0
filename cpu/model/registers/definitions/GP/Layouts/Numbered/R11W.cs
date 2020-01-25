//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 20111
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
        public struct R11W : IGpReg16<R11W>
        {

            [FieldOffset(0)]
            ushort content;

            [FieldOffset(0)]
            R11B r11b;

            public const GpRegId Id = GpRegId.r11w;            

            [MethodImpl(Inline)]
            public static implicit operator ushort(R11W src)
                => src.content;

            [MethodImpl(Inline)]
            public static implicit operator R11W(ushort src)
                => new R11W(src);

            [MethodImpl(Inline)]
            public R11W(ushort src)
                : this()
            {
                content = src;
            }
            byte IGpReg16<R11W>.Lo8 
            { 
                [MethodImpl(Inline)]
                get => !r11b; 
 
                [MethodImpl(Inline)]
                set => r11b = value;
            }

            GpRegId IGpReg.Id 
                => Id;
       }
    }
}