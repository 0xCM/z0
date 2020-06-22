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

    public readonly struct ParsedOperation : ILocatedCode<ParsedOperation,LocatedCode>
    {
        public MemoryAddress Address {get;}

        public LocatedCode Unparsed {get;}

        public LocatedCode Encoded {get;}

        public byte[] Data 
        { 
            [MethodImpl(Inline)] 
            get => Encoded.Data;
        }
        
        public int Length 
        { 
            [MethodImpl(Inline)] 
            get => Encoded.Length; 
        }

        public ref readonly byte this[int index] 
        { 
            [MethodImpl(Inline)] 
            get => ref Encoded[index]; 
        }

        public bool IsEmpty 
        { 
            [MethodImpl(Inline)] 
            get => Encoded.IsEmpty; 
        }

        public bool IsNonEmpty 
        { 
            [MethodImpl(Inline)] 
            get => Encoded.IsNonEmpty; 
        }

        [MethodImpl(Inline)]
        public ParsedOperation(MemoryAddress src, LocatedCode raw, LocatedCode parsed)
        {
            Address = insist(src, x => x.IsNonEmpty);
            insist(src.Equals(raw.Address));
            insist(src.Equals(parsed.Address));
            Unparsed = raw;
            Encoded = parsed;
        }

        [MethodImpl(Inline)]
        public ParsedOperation(MemoryAddress src, byte[] raw, byte[] parsed)
        {
            Address = insist(src, x => x.IsNonEmpty);
            Unparsed = new LocatedCode(src, raw);
            Encoded = new LocatedCode(src, parsed);
        }
 
        [MethodImpl(Inline)]
        public bool Equals(ParsedOperation src)
            => Encoded.Equals(src.Encoded);
        
        public string Format()
            => Encoded.Format();
        
        public override string ToString()
            => Format();
    }
}