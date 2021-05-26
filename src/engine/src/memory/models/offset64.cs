//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;
    using static AsmRegs;

    partial struct AsmMem
    {
        /// <summary>
        /// Represents an offset in 64-bit mode
        /// </summary>
        /// <remarks>
        /// Documentation from Intel Vol1 3-23
        /// </remarks>
        public readonly struct offset64<T>
            where T : unmanaged
        {
            /// <summary>
            /// Displacement, an 8-bit, 16-bit or 32-bit value
            /// </summary>
            /// <remarks>
            /// A displacement alone represents a direct (uncomputed) offset to the operand. Because the displacement
            /// is encoded in the instruction, this form of an address is sometimes called an absolute or static address.
            /// It is commonly used to access a statically allocated scalar operand.
            /// </remarks>
            public T Dx {get;}

            /// <summary>
            /// The base address as specified in a 64-bit register
            /// </summary>
            /// <remarks>
            /// A base alone represents an indirect offset to the operand. Since the value in the base register can change,
            /// it can be used for dynamic storage of variables and data structures.
            /// </remarks>
            public r64 Base {get;}

            /// <summary>
            /// The index as specified in a 64-bit register
            /// </summary>
            public r64 Index {get;}

            /// <summary>
            /// A value of 2, 4 or 8 that is multiplied by the index value
            /// </summary>
            public ScaleFactor Scale {get;}

            [MethodImpl(Inline)]
            public offset64(T dx, r64 @base, r64 index, ScaleFactor scale)
            {
                Dx = dx;
                Base = @base;
                Index = index;
                Scale = scale;
            }

            public MemoryAddress EffectiveAddress
            {
                [MethodImpl(Inline)]
                get =>  Base.Content + (Index.Content * (byte)Scale) + memory.u32(Dx);
            }
        }

        /// <summary>
        /// Represents an offset in 64-bit mode with an 8-bit displacement
        /// </summary>
        public readonly struct offset64x8
        {
            public Cell8 Dx {get;}

            public r64 Base {get;}

            public r64 Index {get;}

            public ScaleFactor Scale {get;}

            [MethodImpl(Inline)]
            public offset64x8(Cell8 dx, r64 @base, r64 index, ScaleFactor scale)
            {
                Dx = dx;
                Base = @base;
                Index = index;
                Scale = scale;
            }
       }

        /// <summary>
        /// Represents an offset in 64-bit mode with a 16-bit displacement
        /// </summary>
        public readonly struct offset64x16
        {
            public Cell16 Dx {get;}

            public r64 Base {get;}

            public r64 Index {get;}

            public ScaleFactor Scale {get;}

            [MethodImpl(Inline)]
            public offset64x16(Cell16 dx, r64 @base, r64 index, ScaleFactor scale)
            {
                Dx = dx;
                Base = @base;
                Index = index;
                Scale = scale;
            }
       }

        /// <summary>
        /// Represents an offset in 64-bit mode with a 32-bit displacement
        /// </summary>
        public readonly struct offset64x32
        {
            public Cell32 Dx {get;}

            public r64 Base {get;}

            public r64 Index {get;}

            public ScaleFactor Scale {get;}

            [MethodImpl(Inline)]
            public offset64x32(Cell32 dx, r64 @base, r64 index, ScaleFactor scale)
            {
                Dx = dx;
                Base = @base;
                Index = index;
                Scale = scale;
            }
       }
    }
}