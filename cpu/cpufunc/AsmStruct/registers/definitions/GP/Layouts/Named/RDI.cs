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
        /// If applicable, receives the first integral/pointer parameter to
        /// a called function, followed by rsi, rdx, rcx, r8 and r9
        /// respectively for the next 5 function parameters
        /// </summary>
        [StructLayout(LayoutKind.Explicit)]
        public struct RDI : IGpReg64<RDI>
        {
            [FieldOffset(0)]
            public ulong rdi;

            [FieldOffset(0)]
            public EDI edi;

            [FieldOffset(0)]
            public DI di;

            [FieldOffset(0)]
            public DIL dil;

            public const GpRegId Id = GpRegId.rdi;

            [MethodImpl(Inline)]
            public static ulong operator !(RDI r)
                => r.rdi;

            [MethodImpl(Inline)]
            public static implicit operator RDI(ulong src)
                => new RDI(src);

            [MethodImpl(Inline)]
            public RDI(ulong src)
                : this()
            {
                rdi = src;
            }

            public GpRegId64 RegKind 
                => GpRegId64.rdi;

            byte IGpReg64<RDI>.Lo8 
            { 
                [MethodImpl(Inline)]
                get => !dil; 
 
                [MethodImpl(Inline)]
                set => dil = value;
            }
            
            ushort IGpReg64<RDI>.Lo16 
            { 
                [MethodImpl(Inline)]
                get => !di; 
 
                [MethodImpl(Inline)]
                set => di = value;
            }

            uint IGpReg64<RDI>.Lo32
            { 
                [MethodImpl(Inline)]
                get => edi; 
 
                [MethodImpl(Inline)]
                set => edi = value;
            }

            GpRegId IGpReg.Id 
                => Id; 
        }

    }

}