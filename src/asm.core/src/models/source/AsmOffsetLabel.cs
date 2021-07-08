//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    /// <summary>
    /// Represents an line offset label
    /// </summary>
    public readonly struct AsmOffsetLabel : ITextual
    {
        const ulong OffsetMask = 0xFF_FF_FF_FF_FF_FF_FF;

        const byte Cut = 56;

        readonly ulong Data;

        [MethodImpl(Inline)]
        public AsmOffsetLabel(byte width, ulong offset)
        {
            Data = ((ulong)width << Cut) | (offset & OffsetMask);
        }

        public ulong OffsetValue
        {
            [MethodImpl(Inline)]
            get => Data & OffsetMask;
        }

        /// <summary>
        /// The offset bit-width
        /// </summary>
        public byte OffsetWidth
        {
            [MethodImpl(Inline)]
            get => (byte)((ulong)Data >> Cut);
        }

        public string Format()
            => AsmRender.format(this);

        public override string ToString()
            => Format();
    }
}