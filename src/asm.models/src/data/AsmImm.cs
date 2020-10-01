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
    public readonly struct AsmImm : ITextual
    {
        const string RenderPattern = "x{0}";

        readonly ulong Data;

        [MethodImpl(Inline)]
        public static implicit operator AsmImm(byte src)
            => new AsmImm(src);

        [MethodImpl(Inline)]
        public static implicit operator AsmImm(ushort src)
            => new AsmImm(src);

        [MethodImpl(Inline)]
        public static implicit operator AsmImm(uint src)
            => new AsmImm(src);

        [MethodImpl(Inline)]
        public static implicit operator AsmImm(ulong src)
            => new AsmImm(src);

        [MethodImpl(Inline)]
        public AsmImm(byte src)
            => Data = src;

        [MethodImpl(Inline)]
        public AsmImm(ushort src)
            => Data = src;

        [MethodImpl(Inline)]
        public AsmImm(uint src)
            => Data = src;

        [MethodImpl(Inline)]
        public AsmImm(ulong src)
            => Data = src;

        public uint Width
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