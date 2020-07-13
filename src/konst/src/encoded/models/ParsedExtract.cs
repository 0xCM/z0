//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Reflection;
    using System.Runtime.CompilerServices;
 
    using static Konst;    
    
    public readonly struct ParsedExtract : IParsedExtract<ParsedExtract,LocatedCode>
    {
        /// <summary>
        /// The extracted code
        /// </summary>
        readonly ExtractedCode Extracted;

        /// <summary>
        /// The parsed code
        /// </summary>
        public LocatedCode Encoded {get;}

        /// <summary>
        /// The extracted member sequence
        /// </summary>
        public int Sequence {get;}

        /// <summary>
        /// The reason for extract completion
        /// </summary>
        public ExtractTermCode TermCode {get;}

        public byte[] Data
        { 
            [MethodImpl(Inline)] 
            get => Encoded.Data; 
        }
        
        public ref readonly byte this[int index] 
        { 
            [MethodImpl(Inline)] 
            get => ref Encoded[index]; 
        }

        public int Length 
        { 
            [MethodImpl(Inline)] 
            get => Encoded.Length; 
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
        public ParsedExtract(ExtractedCode extracted, int seq, ExtractTermCode term, LocatedCode parsed)
        {
            z.insist(extracted.Address,parsed.Address);           
            Extracted = extracted;
            Sequence = seq;
            TermCode = term;
            Encoded = parsed;
        }
        
        public MemoryAddress Address 
        { 
            [MethodImpl(Inline)] 
            get => Encoded.Address; 
        }

        /// <summary>
        /// The operation uri 
        /// </summary>
        public OpUri OpUri 
            => Extracted.OpUri;

        /// <summary>
        /// The operation identifier
        /// </summary>
        public OpIdentity Id 
            => OpUri.OpId;

        /// <summary>
        /// The member operation, reflected
        /// </summary>
        public MethodInfo Method 
            => Extracted.Member.Method;            

        /// <summary>
        /// The member kind, if known
        /// </summary>
        public OpKindId KindId 
            => Extracted.Member.KindId;

        public bool Equals(ParsedExtract src)
            => Encoded.Equals(src.Encoded);
        
        public string Format()
            => Encoded.Format();
        
        public override string ToString()
            => Format();
    }
}