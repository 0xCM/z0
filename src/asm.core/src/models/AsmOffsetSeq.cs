//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    /// <summary>
    /// Pairs a sequence number with a memory offset
    /// </summary>
    public readonly struct AsmOffsetSeq : ITextual
    {
        public ushort Seq {get;}

        public uint Offset {get;}

        [MethodImpl(Inline)]
        public AsmOffsetSeq(ushort seq, uint offset)
        {
            Seq = seq;
            Offset = offset;
        }

        [MethodImpl(Inline)]
        public AsmOffsetSeq Next()
            => new AsmOffsetSeq((ushort)(Seq + 1), Offset);

        [MethodImpl(Inline)]
        public AsmOffsetSeq AccrueOffset(uint dx)
            => new AsmOffsetSeq((ushort)(Seq + 1), Offset + dx);

        public string Format(int seqpad)
            => text.concat(Seq.ToString().PadLeft(seqpad, Chars.D0), Chars.Space,  Offset.FormatAsmHex(4));

        public string Format()
            => Format(3);

        public override string ToString()
            => Format();

        public static AsmOffsetSeq Zero
            => default(AsmOffsetSeq);

        [MethodImpl(Inline)]
        public static AsmOffsetSeq operator ++(AsmOffsetSeq src)
            => src.Next();

        [MethodImpl(Inline)]
        public static implicit operator AsmOffsetSeq((ushort seq, ushort offset) src)
            => new AsmOffsetSeq(src.seq, src.offset);
    }
}