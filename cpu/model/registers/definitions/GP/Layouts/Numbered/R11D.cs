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
        public struct R11D : IGpReg32<R11>
        {
            [FieldOffset(0)]
            uint content;

            [FieldOffset(0)]
            R11W r11w;

            [FieldOffset(0)]
            R11B r11b;
 
            public const GpRegId Id = GpRegId.r11;            

            [MethodImpl(Inline)]
            public static implicit operator uint(R11D src)
                => src.content;

            [MethodImpl(Inline)]
            public static implicit operator R11D(uint src)
                => new R11D(src);

            [MethodImpl(Inline)]
            public R11D(uint src)
                : this()
            {
                content = src;
            }

            byte IGpReg32<R11>.Lo8 
            { 
                [MethodImpl(Inline)]
                get => !r11b; 
 
                [MethodImpl(Inline)]
                set => r11b = value;
            }
            
            ushort IGpReg32<R11>.Lo16 
            { 
                [MethodImpl(Inline)]
                get => r11w; 
 
                [MethodImpl(Inline)]
                set => r11w = value;
            }
 
            GpRegId IGpReg.Id 
                => Id;
       }
    }
}