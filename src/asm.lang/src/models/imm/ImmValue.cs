//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    partial struct AsmLang
    {
        /// <summary>
        /// Defines an immediate value of any width in the range [0..64]
        /// </summary>
        public readonly struct ImmValue : ITextual
        {
            readonly ulong Data;

            [MethodImpl(Inline)]
            public ImmValue(byte src)
                => Data = src;

            [MethodImpl(Inline)]
            public ImmValue(ushort src)
                => Data = src;

            [MethodImpl(Inline)]
            public ImmValue(uint src)
                => Data = src;

            [MethodImpl(Inline)]
            public ImmValue(ulong src)
                => Data = src;

            public uint Width
            {
                [MethodImpl(Inline)]
                get => Bits.effwidth(Data);
            }

            [MethodImpl(Inline)]
            public string Format()
                => Data.FormatHex(false);

            [MethodImpl(Inline)]
            public static implicit operator ImmValue(byte src)
                => new ImmValue(src);

            [MethodImpl(Inline)]
            public static implicit operator ImmValue(ushort src)
                => new ImmValue(src);

            [MethodImpl(Inline)]
            public static implicit operator ImmValue(uint src)
                => new ImmValue(src);

            [MethodImpl(Inline)]
            public static implicit operator ImmValue(ulong src)
                => new ImmValue(src);
        }
    }
}