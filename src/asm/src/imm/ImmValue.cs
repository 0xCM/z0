//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    /// <summary>
    /// Defines an immediate value of any width in the range [0..64]
    /// </summary>
    public readonly struct ImmValue : ITextual
    {
        const string RenderPattern = "x{0}";

        readonly ulong Data;

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

        public byte Width
        {
            [MethodImpl(Inline)]
            get => Bits.effwidth(Data);
        }

        public byte Size
        {
            [MethodImpl(Inline)]
            get => Bits.effsize(Data);
        }

        [MethodImpl(Inline)]
        public string Format()
            => Data.ToString(text.format(RenderPattern, Size*2));
    }
}