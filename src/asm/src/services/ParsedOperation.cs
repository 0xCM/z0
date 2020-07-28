//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
 
    using static Konst;

    public readonly struct ParsedOperation : ILocatedCode<ParsedOperation,LocatedCode>
    {
        readonly BinaryCode Input;

        public LocatedCode ParseResult {get;}
        
        public LocatedCode Encoded
        {
            [MethodImpl(Inline)] 
            get => ParseResult;
        }

        public LocatedCode ParseInput
        {
            [MethodImpl(Inline)] 
            get => new LocatedCode(Address, Input);
        }

        public MemoryAddress Address  
        {
            [MethodImpl(Inline)] 
            get => Encoded.Address;
        }

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
            z.insist(src, raw.Address);
            z.insist(src, parsed.Address);
            Input = raw;
            ParseResult = parsed;
        }

        [MethodImpl(Inline)]
        public ParsedOperation(LocatedCode src, LocatedCode parsed)
        {
            z.insist(src.Address, parsed.Address);
            Input = src;
            ParseResult = parsed;
        }

        [MethodImpl(Inline)]
        public ParsedOperation(MemoryAddress src, byte[] raw, byte[] parsed)
        {
            Input = new LocatedCode(src, raw);
            ParseResult = new LocatedCode(src, parsed);
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