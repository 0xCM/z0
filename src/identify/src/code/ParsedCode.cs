//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
 
    using static Konst;
    using static Memories;

    public readonly struct ParsedCode : ILocatedCode<ParsedCode,LocatedCode>
    {
        public MemoryAddress Address {get;}

        public LocatedCode Unparsed {get;}

        public LocatedCode Encoded {get;}

        public ReadOnlySpan<byte> Bytes  { [MethodImpl(Inline)] get => Encoded.Bytes; }

        public int Length { [MethodImpl(Inline)] get => Encoded.Length; }

        public bool IsEmpty { [MethodImpl(Inline)] get => Encoded.IsEmpty; }

        public bool IsNonEmpty { [MethodImpl(Inline)] get => Encoded.IsNonEmpty; }

        public ref readonly byte Head { [MethodImpl(Inline)] get => ref Encoded.Head;}

        public ref readonly byte this[int index] { [MethodImpl(Inline)] get => ref Encoded[index]; }

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
            Address = insist(src, x => x.IsNonEmpty);
            insist(src.Equals(raw.Address));
            insist(src.Equals(parsed.Address));
            Unparsed = raw;
            Encoded = parsed;
        }

        [MethodImpl(Inline)]
        ParsedCode(MemoryAddress src, byte[] raw, byte[] parsed)
        {
            Address = insist(src, x => x.IsNonEmpty);
            Unparsed = LocatedCode.Define(src, raw);
            Encoded = LocatedCode.Define(src, parsed);
        }

        [MethodImpl(Inline)]
        public bool Equals(ParsedCode src)
            => Encoded.Equals(src.Encoded);
        
        public string Format()
            => Encoded.Format();
        
        public override string ToString()
            => Format();

    }
}