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
        /// If applicable, receives the third integral/pointer parameter 
        /// to a called function, preceded respectively by rdi and rsi for 
        /// the first two parametes and followed respecively by rcx, r8 and r9 
        /// for three additional parameters
        /// </summary>
        [StructLayout(LayoutKind.Explicit)]
        public struct RDX : IGpReg64<RDX>
        {
            [FieldOffset(0)]
            public ulong rdx;

            [FieldOffset(0)]
            public EDX edx;

            [FieldOffset(0)]
            public DX dx;

            [FieldOffset(0)]
            public DL dl;

            [FieldOffset(1)]
            public DH dh;

            public const GpRegId Id = GpRegId.rdx;

            /// <summary>
            /// Dereferences rdx to produce its content [rdx]
            /// </summary>
            /// <param name="r">The source register</param>
            [MethodImpl(Inline)]
            public static ulong operator !(RDX r)
                => r.rdx;

            [MethodImpl(Inline)]
            public static implicit operator RDX(ulong src)
                => new RDX(src);

            [MethodImpl(Inline)]
            public RDX(ulong src)
                : this()
            {
                rdx = src;
            }

            public GpRegId64 RegKind 
                => GpRegId64.rdx;

            public Volatility Volatility
                => Volatility.Volatile;

            byte IGpReg64<RDX>.Lo8 
            { 
                [MethodImpl(Inline)]
                get => !dl; 
 
                [MethodImpl(Inline)]
                set => dl = value;
            }
            
            ushort IGpReg64<RDX>.Lo16 
            { 
                [MethodImpl(Inline)]
                get => !dx; 
 
                [MethodImpl(Inline)]
                set => dx = value;
            }

            uint IGpReg64<RDX>.Lo32
            { 
                [MethodImpl(Inline)]
                get => !edx; 
 
                [MethodImpl(Inline)]
                set => edx = value;
            }
   
            GpRegId IGpReg.Id 
                => Id;
        }
    }
}