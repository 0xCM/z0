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

    public readonly struct X86MemberRefinement
    {
        /// <summary>
        /// The extracted code
        /// </summary>
        public readonly X86MemberExtract Extracted;

        /// <summary>
        /// The parsed code
        /// </summary>
        public readonly X86Code Encoded {get;}

        /// <summary>
        /// The extracted member sequence
        /// </summary>
        public readonly int Sequence;

        /// <summary>
        /// The reason for extract completion
        /// </summary>
        public readonly ExtractTermCode TermCode;

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
        public X86MemberRefinement(X86MemberExtract extracted, int seq, ExtractTermCode term, X86Code parsed)
        {
            z.insist(extracted.Address, parsed.Address);
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

        public bool Equals(X86MemberRefinement src)
            => Encoded.Equals(src.Encoded);

        public string Format()
            => Encoded.Format();

        public override string ToString()
            => Format();
    }
}