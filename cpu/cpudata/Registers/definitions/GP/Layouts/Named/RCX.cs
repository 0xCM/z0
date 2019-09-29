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
        /// If applicable, receives the fourth integral/pointer parameter 
        /// to an called function, preceded respectively by rdi, rsi and rdx 
        /// for the first three parametes and followed respecively by  r8 and r9 
        /// for two additional parameters
        /// </summary>
        [StructLayout(LayoutKind.Explicit)]
        public struct RCX : IGpReg64<RCX>
        {
            [FieldOffset(0)]
            public ulong rcx;

            [FieldOffset(0)]
            public ECX ecx;

            [FieldOffset(0)]
            public CX cx;

            [FieldOffset(0)]
            public CL cl;

            [FieldOffset(1)]
            public CH ch;

            public const GpRegId Id = GpRegId.rcx;

            /// <summary>
            /// Dereferences rcx to produce its content [rcx]
            /// </summary>
            /// <param name="r">The source register</param>
            [MethodImpl(Inline)]
            public static ulong operator !(RCX r)
                => r.rcx;

            [MethodImpl(Inline)]
            public static implicit operator RCX(ulong src)
                => new RCX(src);

            [MethodImpl(Inline)]
            public RCX(ulong src)
                : this()
            {
                rcx = src;
            }

            byte IGpReg64<RCX>.Lo8 
            { 
                [MethodImpl(Inline)]
                get => cl; 
 
                [MethodImpl(Inline)]
                set => cl = value;
            }
            
            ushort IGpReg64<RCX>.Lo16 
            { 
                [MethodImpl(Inline)]
                get => cx; 
 
                [MethodImpl(Inline)]
                set => cx = value;
            }

            uint IGpReg64<RCX>.Lo32
            { 
                [MethodImpl(Inline)]
                get => ecx; 
 
                [MethodImpl(Inline)]
                set => ecx = value;
            }
  
            GpRegId IGpReg.Id 
                => Id;
 
        }
    }
}