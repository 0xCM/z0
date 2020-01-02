//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
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
        /// If applicable, receives the 6th integral/pointer parameter 
        /// to a called function, preceded respectively by rdi, rsi, rdx,
        /// rcx and r8 for the first five parameters
        /// </summary>
        [StructLayout(LayoutKind.Explicit)]
        public struct R9 : IGpReg64<R9>
        {
            [FieldOffset(0)]
            ulong content;

            [FieldOffset(0)]
            R9D r9d;

            [FieldOffset(0)]
            R9W r9w;

            [FieldOffset(0)]
            R9B r9b;
 
            public const GpRegId Id = GpRegId.r9;            

            [MethodImpl(Inline)]
            public static implicit operator ulong(R9 src)
                => src.content;

            [MethodImpl(Inline)]
            public static implicit operator R9(ulong src)
                => new R9(src);

            [MethodImpl(Inline)]
            public R9(ulong src)
                : this()
            {
                content = src;
            }

            public GpRegId64 RegKind 
                => GpRegId64.r9;

            public Volatility Volatility
                => Volatility.Volatile;

            byte IGpReg64<R9>.Lo8 
            { 
                [MethodImpl(Inline)]
                get => !r9b; 
 
                [MethodImpl(Inline)]
                set => r9b = value;
            }
            
            ushort IGpReg64<R9>.Lo16 
            { 
                [MethodImpl(Inline)]
                get => r9w; 
 
                [MethodImpl(Inline)]
                set => r9w = value;
            }

            uint IGpReg64<R9>.Lo32
            { 
                [MethodImpl(Inline)]
                get => r9d; 
 
                [MethodImpl(Inline)]
                set => r9d = value;
            }

            GpRegId IGpReg.Id 
                => Id;
       }
    }
}