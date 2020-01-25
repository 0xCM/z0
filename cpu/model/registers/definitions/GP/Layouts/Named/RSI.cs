//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
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

        /// <summary>
        /// If applicable, receives the second integral/pointer parameter to a 
        /// called function, preceded by rdi that receives the first parameter
        /// and followed respecively by rdx, rcx, r8 and r9 for four additional parameters
        /// </summary>
        [StructLayout(LayoutKind.Explicit)]
        public struct RSI : IGpReg64<RSI>
        {
            [FieldOffset(0)]
            ulong content;

            [FieldOffset(0)]
            ESI esi;

            [FieldOffset(0)]
            SI si;

            [FieldOffset(0)]
            SIL sil;

            public const GpRegId Id = GpRegId.rsi;

            [MethodImpl(Inline)]
            public static ulong operator !(RSI r)
                => r.content;

            [MethodImpl(Inline)]
            public static implicit operator RSI(ulong src)
                => new RSI(src);

            [MethodImpl(Inline)]
            public RSI(ulong src)
                : this()
            {
                content = src;
            }

            public GpRegId64 RegKind 
                => GpRegId64.rsi;

            byte IGpReg64<RSI>.Lo8 
            { 
                [MethodImpl(Inline)]
                get => sil; 
 
                [MethodImpl(Inline)]
                set => sil = value;
            }
            
            ushort IGpReg64<RSI>.Lo16 
            { 
                [MethodImpl(Inline)]
                get => !si; 
 
                [MethodImpl(Inline)]
                set => si = value;
            }

            uint IGpReg64<RSI>.Lo32
            { 
                [MethodImpl(Inline)]
                get => esi; 
 
                [MethodImpl(Inline)]
                set => esi = value;
            }
   
            GpRegId IGpReg.Id 
                => Id;
 
        }
    }

}