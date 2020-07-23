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
    /// Pairs a sequence number with a short memory offset
    /// </summary>
    public readonly struct OffsetSequence : ITextual
    {
        public readonly ushort Seq;

        public readonly ushort Offset;

        [MethodImpl(Inline)]
        public static OffsetSequence operator ++(OffsetSequence src)
            => src.NextSeq();

        [MethodImpl(Inline)]
        public static implicit operator OffsetSequence((ushort seq, ushort offset) src)
            => new OffsetSequence(src.seq, src.offset);
        
        [MethodImpl(Inline)]
        public OffsetSequence(ushort seq, ushort offset)
        {
            Seq = seq;
            Offset = offset;
        }

        [MethodImpl(Inline)]
        public OffsetSequence NextSeq()
            => new OffsetSequence((ushort)(Seq + 1), Offset);

        [MethodImpl(Inline)]
        public OffsetSequence AccrueOffset(ushort dx)
            => new OffsetSequence((ushort)(Seq + 1), ((ushort) (Offset + dx)));

        [MethodImpl(Inline)]
        public OffsetSequence AccrueOffset(int dx)
            => AccrueOffset((ushort)dx);

        public string Format(int seqpad)
            => text.concat(Seq.ToString().PadLeft(seqpad, Chars.D0), Chars.Space,  Offset.FormatSmallHex(true));

        public string Format()
            => Format(3);

        public override string ToString()
            => Format();

        public static OffsetSequence Zero => default(OffsetSequence);
    }
}