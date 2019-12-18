//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
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
        /// <summary>
        /// If applicable, receives the fifth integral/pointer parameter 
        /// to an called function, preceded respectively by rdi, rsi, rdx 
        /// and rcx for the first four parameters and followed by r9
        /// for an additional parameter
        /// </summary>
        [StructLayout(LayoutKind.Explicit)]
        public struct R8 : IGpReg64<R8>
        {
            [FieldOffset(0)]
            ulong content;

            [FieldOffset(0)]
            R8D r8d;

            [FieldOffset(0)]
            R8W r8w;

            [FieldOffset(0)]
            R8B r8b;

            public const GpRegId Id = GpRegId.r8;

            [MethodImpl(Inline)]
            public static implicit operator ulong(R8 src)
                => src.content;

            [MethodImpl(Inline)]
            public static implicit operator R8(ulong src)
                => new R8(src);

            [MethodImpl(Inline)]
            public R8(ulong src)
                : this()
            {
                content = src;
            }

            public GpRegId64 RegKind 
                => GpRegId64.r8;

            public Volatility Volatility
                => Volatility.Volatile;

            byte IGpReg64<R8>.Lo8 
            { 
                [MethodImpl(Inline)]
                get => !r8b; 
 
                [MethodImpl(Inline)]
                set => r8b = value;
            }
            
            ushort IGpReg64<R8>.Lo16 
            { 
                [MethodImpl(Inline)]
                get => r8w; 
 
                [MethodImpl(Inline)]
                set => r8w = value;
            }

            uint IGpReg64<R8>.Lo32
            { 
                [MethodImpl(Inline)]
                get => r8d; 
 
                [MethodImpl(Inline)]
                set => r8d = value;
            }

            GpRegId IGpReg.Id 
                => Id;

       }
    }
}