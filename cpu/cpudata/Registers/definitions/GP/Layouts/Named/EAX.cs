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
        /// Accumulator for operands and results data
        /// </summary>
        [StructLayout(LayoutKind.Explicit)]
        public struct EAX : IGpReg32<EAX>
        {
            [FieldOffset(0)]
            uint content;

            [FieldOffset(0)]
            AX ax;

            [FieldOffset(0)]
            AL al;

            [FieldOffset(1)]
            AH ah;

            public const GpRegId Id = GpRegId.eax;          

            [MethodImpl(Inline)]
            public static uint operator !(EAX r)
                => r.content;

            [MethodImpl(Inline)]
            public static implicit operator EAX(uint src)
                => new EAX(src);

            [MethodImpl(Inline)]
            public EAX(uint src)
                : this()
            {
                this.content = src;
            }


            byte IGpReg32<EAX>.Lo8 
            { 
                [MethodImpl(Inline)]
                get => !al; 
 
                [MethodImpl(Inline)]
                set => al = value;
            }
            
            ushort IGpReg32<EAX>.Lo16 
            { 
                [MethodImpl(Inline)]
                get => !ax; 
 
                [MethodImpl(Inline)]
                set => ax = value;
            }
 
            GpRegId IGpReg.Id 
                => Id;
        }
    }
}