//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Seed;

    /// <summary>
    /// Pairs a sequence number with a short memory offset
    /// </summary>
    public readonly struct OffsetSeq : ITextual
    {
        public static OffsetSeq Zero => default(OffsetSeq);

        public readonly ushort Seq {get;}

        public readonly ushort Offset {get;}

        [MethodImpl(Inline)]
        public static OffsetSeq operator ++(OffsetSeq src)
            => src.NextSeq();

        [MethodImpl(Inline)]
        public static implicit operator OffsetSeq((ushort seq, ushort offset) src)
            => new OffsetSeq(src.seq, src.offset);
        
        [MethodImpl(Inline)]
        public OffsetSeq(ushort seq, ushort offset)
        {
            Seq = seq;
            Offset = offset;
        }

        [MethodImpl(Inline)]
        public OffsetSeq NextSeq()
            => new OffsetSeq((ushort)(Seq + 1), Offset);

        [MethodImpl(Inline)]
        public OffsetSeq AccrueOffset(ushort dx)
            => new OffsetSeq((ushort)(Seq + 1), ((ushort) (Offset + dx)));

        public string Format(int seqpad)
            => String.Concat(
                Seq.ToString().PadLeft(seqpad, Chars.D0), 
                Chars.Space,  
                Offset.FormatSmallHex(true)
                );

        public string Format()
            => Format(3);

        public override string ToString()
            => Format();
    }
}