//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;

    using static Seed;
    using static AsmSpecs;

    using specs = AsmSpecs;

    partial class AsmTypes
    {
        /// <summary>
        /// Defines a polyphasic immediate value representation
        /// </summary>
        [StructLayout(LayoutKind.Explicit, Size=64)]
        public readonly struct imm : 
            specs.imm<imm,W8,byte>, 
            specs.imm<imm,W16,ushort>, 
            specs.imm<imm,W32,uint>, 
            specs.imm<imm,W64,ulong>
        {
            [FieldOffset(0)]
            readonly ulong L64;

            [FieldOffset(0)]
            readonly uint L32;

            [FieldOffset(0)]
            readonly ushort L16;

            [FieldOffset(0)]
            readonly byte L8;

            [MethodImpl(Inline)]
            public static implicit operator byte(imm src)
                => src.L8;

            [MethodImpl(Inline)]
            public static implicit operator imm(byte src)
                => new imm(src);

            [MethodImpl(Inline)]
            public static implicit operator ushort(imm src)
                => src.L16;

            [MethodImpl(Inline)]
            public static implicit operator imm(ushort src)
                => new imm(src);

            [MethodImpl(Inline)]
            public static implicit operator uint(imm src)
                => src.L32;

            [MethodImpl(Inline)]
            public static implicit operator imm(uint src)
                => new imm(src);

            [MethodImpl(Inline)]
            public static implicit operator ulong(imm src)
                => src.L64;

            [MethodImpl(Inline)]
            public static implicit operator imm(ulong src)
                => new imm(src);

            [MethodImpl(Inline)]
            public static implicit operator imm8(imm src)
                => new imm8(src.L8);

            [MethodImpl(Inline)]
            public static implicit operator imm(imm8 src)
                => new imm(src.Literal);

            [MethodImpl(Inline)]
            public static implicit operator imm16(imm src)
                => new imm16(src.L16);

            [MethodImpl(Inline)]
            public static implicit operator imm(imm16 src)
                => new imm(src.Literal);

            [MethodImpl(Inline)]
            public static implicit operator imm32(imm src)
                => new imm32(src.L32);

            [MethodImpl(Inline)]
            public static implicit operator imm(imm32 src)
                => new imm(src.Literal);


            [MethodImpl(Inline)]
            public static implicit operator imm64(imm src)
                => new imm64(src.L64);

            [MethodImpl(Inline)]
            public static implicit operator imm(imm64 src)
                => new imm(src.Literal);
            
            [MethodImpl(Inline)]
            public imm(byte value)
                : this()
            {
                L64 = value;
            }

            [MethodImpl(Inline)]
            public imm(ushort value)
                : this()
            {
                L64 = value;
            }

            [MethodImpl(Inline)]
            public imm(uint value)
                : this()
            {
                L64 = value;
            }             

            [MethodImpl(Inline)]
            public imm(ulong value)
                : this()
            {
                L64 = value;
            }

            byte constant<byte>.Literal => L8;

            ushort constant<ushort>.Literal => L16;

            uint constant<uint>.Literal => L32;            

            ulong constant<ulong>.Literal => L64;            
        }
    }
}