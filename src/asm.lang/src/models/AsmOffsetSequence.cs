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
    public readonly struct AsmOffsetSequence : ITextual
    {
        public ushort Seq {get;}

        public uint Offset {get;}

        [MethodImpl(Inline)]
        public AsmOffsetSequence(ushort seq, uint offset)
        {
            Seq = seq;
            Offset = offset;
        }

        [MethodImpl(Inline)]
        public AsmOffsetSequence Next()
            => new AsmOffsetSequence((ushort)(Seq + 1), Offset);

        [MethodImpl(Inline)]
        public AsmOffsetSequence AccrueOffset(uint dx)
            => new AsmOffsetSequence((ushort)(Seq + 1), Offset + dx);

        public string Format(int seqpad)
            => text.concat(Seq.ToString().PadLeft(seqpad, Chars.D0), Chars.Space,  Offset.FormatAsmHex(4));

        public string Format()
            => Format(3);

        public override string ToString()
            => Format();

        public static AsmOffsetSequence Zero
            => default(AsmOffsetSequence);

        [MethodImpl(Inline)]
        public static AsmOffsetSequence operator ++(AsmOffsetSequence src)
            => src.Next();

        [MethodImpl(Inline)]
        public static implicit operator AsmOffsetSequence((ushort seq, ushort offset) src)
            => new AsmOffsetSequence(src.seq, src.offset);
    }
}