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
 
    using static Seed;    
    using static Memories;

    public readonly struct ParsedMember : 
        IMemberCode<ParsedMember,LocatedCode>, 
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
        public OpUri Uri => Extracted.Uri;

        /// <summary>
        /// The operation identifier
        /// </summary>
        public OpIdentity Id => Uri.OpId;

        /// <summary>
        /// The operation memory address
        /// </summary>
        public MemoryAddress Address => Encoded.Address;

        /// <summary>
        /// The member operation, reflected
        /// </summary>
        public MethodInfo Method => Extracted.Member.Method;            

        /// <summary>
        /// The member kind, if known
        /// </summary>
        public OpKindId KindId => Extracted.Member.KindId;

        public int Length { [MethodImpl(Inline)] get => Encoded.Length; }

        public ReadOnlySpan<byte> Bytes { [MethodImpl(Inline)] get => Encoded.Bytes; }

        public bool IsEmpty { [MethodImpl(Inline)] get => !Address.NonZero; }

        public bool IsNonEmpty { [MethodImpl(Inline)] get => Address.NonZero; }

        public MemoryRange MemorySegment { [MethodImpl(Inline)] get => Encoded.MemorySegment; }

        public bool Equals(ParsedMember src)
            => Encoded.Equals(src.Encoded);

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