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
        public struct R10 : IGpReg64<R10>
        { 
            [FieldOffset(0)]
            ulong content;

            [FieldOffset(0)]
            R10D r10d;

            [FieldOffset(0)]
            R10W r10w;

            [FieldOffset(0)]
            R10B r10b;

            public const GpRegId Id = GpRegId.r10;            

            [MethodImpl(Inline)]
            public static implicit operator ulong(R10 src)
                => src.content;

            [MethodImpl(Inline)]
            public static implicit operator R10(ulong src)
                => new R10(src);

            [MethodImpl(Inline)]
            public R10(ulong src)
                : this()
            {
                content = src;
            }

            public GpRegId64 RegKind 
                => GpRegId64.r10;

            public Volatility Volatility
                => Volatility.Volatile;

            byte IGpReg64<R10>.Lo8 
            { 
                [MethodImpl(Inline)]
                get => !r10b; 
 
                [MethodImpl(Inline)]
                set => r10b = value;
            }
            
            ushort IGpReg64<R10>.Lo16 
            { 
                [MethodImpl(Inline)]
                get => r10w; 
 
                [MethodImpl(Inline)]
                set => r10w = value;
            }

            uint IGpReg64<R10>.Lo32
            { 
                [MethodImpl(Inline)]
                get => r10d; 
 
                [MethodImpl(Inline)]
                set => r10d = value;
            }
 
            GpRegId IGpReg.Id 
                => Id;
       }
    }
}