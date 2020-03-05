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
        public struct R11 : IGpReg64<R11>
        { 
            [FieldOffset(0)]
            ulong content;

            [FieldOffset(0)]
            R11D r11d;

            [FieldOffset(0)]
            R11W r11w;

            [FieldOffset(0)]
            R11B r11b;

            public const GpRegId Id = GpRegId.r11;            

            [MethodImpl(Inline)]
            public static implicit operator ulong(R11 src)
                => src.content;

            [MethodImpl(Inline)]
            public static implicit operator R11(ulong src)
                => new R11(src);

            [MethodImpl(Inline)]
            public R11(ulong src)
                : this()
            {
                content = src;
            }

            public GpRegId64 RegKind 
                => GpRegId64.r11;

            public VolatilityKind Volatility
                => VolatilityKind.Volatile;

            byte IGpReg64<R11>.Lo8 
            { 
                [MethodImpl(Inline)]
                get => !r11b; 
 
                [MethodImpl(Inline)]
                set => r11b = value;
            }
            
            ushort IGpReg64<R11>.Lo16 
            { 
                [MethodImpl(Inline)]
                get => r11w; 
 
                [MethodImpl(Inline)]
                set => r11w = value;
            }

            uint IGpReg64<R11>.Lo32
            { 
                [MethodImpl(Inline)]
                get => r11d; 
 
                [MethodImpl(Inline)]
                set => r11d = value;
            }
 
            GpRegId IGpReg.Id 
                => Id;
       }
    }
}