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
    public readonly struct AsmImmOp : ITextual, IAsmImmOp
    {
        const string RenderPattern = "x{0}";

        readonly ulong Data;

        [MethodImpl(Inline)]
        public static implicit operator AsmImmOp(byte src)
            => new AsmImmOp(src);

        [MethodImpl(Inline)]
        public static implicit operator AsmImmOp(ushort src)
            => new AsmImmOp(src);

        [MethodImpl(Inline)]
        public static implicit operator AsmImmOp(uint src)
            => new AsmImmOp(src);

        [MethodImpl(Inline)]
        public static implicit operator AsmImmOp(ulong src)
            => new AsmImmOp(src);

        [MethodImpl(Inline)]
        public AsmImmOp(byte src)
            => Data = src;

        [MethodImpl(Inline)]
        public AsmImmOp(ushort src)
            => Data = src;

        [MethodImpl(Inline)]
        public AsmImmOp(uint src)
            => Data = src;

        [MethodImpl(Inline)]
        public AsmImmOp(ulong src)
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