//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
 
    using static Seed;
    using static Memories;

    public readonly struct ParsedCode : ILocatedCode<ParsedCode,LocatedCode>
    {
        public MemoryAddress Address {get;}

        public LocatedCode Unparsed {get;}

        public LocatedCode Encoded {get;}

        public bool IsNonEmpty { [MethodImpl(Inline)] get => Encoded.IsNonEmpty; }

        public bool IsEmpty { [MethodImpl(Inline)] get => Encoded.IsEmpty; }

        public ReadOnlySpan<byte> Bytes  { [MethodImpl(Inline)] get => Encoded.Bytes; }

        public MemoryRange MemorySegment { [MethodImpl(Inline)] get => Encoded.MemorySegment;}

        [MethodImpl(Inline)]
        public static ParsedCode Define(MemoryAddress src, byte[] raw, byte[] parsed)
            => new ParsedCode(src, raw, parsed);

        [MethodImpl(Inline)]
        public static ParsedCode Define(MemoryAddress src, LocatedCode raw, LocatedCode parsed)
            => new ParsedCode(src, raw, parsed);

        [MethodImpl(Inline)]
        ParsedCode(MemoryAddress src, LocatedCode raw, LocatedCode parsed)
        {
            Address = insist(src, x => x.NonZero);
            insist(src.Equals(raw.Address));
            insist(src.Equals(parsed.Address));
            Unparsed = raw;
            Encoded = parsed;
        }

        [MethodImpl(Inline)]
        ParsedCode(MemoryAddress src, byte[] raw, byte[] parsed)
        {
            Address = insist(src, x => x.NonZero);
            Unparsed = LocatedCode.Define(src, raw);
            Encoded = LocatedCode.Define(src, parsed);
        }

        [MethodImpl(Inline)]
        public bool Equals(ParsedCode src)
            => Encoded.Equals(src.Encoded);
    }
}