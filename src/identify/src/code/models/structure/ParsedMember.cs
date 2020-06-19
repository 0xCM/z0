//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Reflection;
    using System.Linq;
    using System.Runtime.CompilerServices;
 
    using static Konst;    
    using static Memories;

    public readonly struct ParsedMember : 
        IReflectedCode<ParsedMember,LocatedCode>, 
        IUriCode<ParsedMember,LocatedCode>
    {
        /// <summary>
        /// The extracted code
        /// </summary>
        readonly ExtractedMember Extracted;

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

        /// <summary>
        /// The operation uri 
        /// </summary>
        public OpUri OpUri 
            => Extracted.Uri;

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
        

        public bool Equals(ParsedMember src)
            => Encoded.Equals(src.Encoded);
        
        public string Format()
            => Encoded.Format();
        
        public override string ToString()
            => Format();

        [MethodImpl(Inline)]
        public ParsedMember(ExtractedMember extracted, int seq, ExtractTermCode term, LocatedCode parsed)
        {
            insist(extracted.Address,parsed.Address);           
            Extracted = extracted;
            Sequence = seq;
            TermCode = term;
            Encoded = parsed;
        }
    }
}