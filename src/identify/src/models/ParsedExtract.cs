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

    public readonly struct ParsedExtract
    {
        [MethodImpl(Inline)]
        public static ParsedExtract Define(ApiMemberExtract src, int seq, ExtractTermCode term, Addressable parsed)
            => new ParsedExtract(src, seq, term,parsed);

        [MethodImpl(Inline)]
        ParsedExtract(ApiMemberExtract src, int seq, ExtractTermCode term, Addressable parsed)
        {
            this.Source = src;
            this.SourceSequence = seq;
            this.TermCode = term;
            this.ParsedContent = parsed;
        }        

        /// <summary>
        /// The extracted member,
        /// </summary>
        public readonly ApiMemberExtract Source;

        /// <summary>
        /// The extracted member sequence
        /// </summary>
        public readonly int SourceSequence;

        /// <summary>
        /// The reason for extract completion
        /// </summary>
        public readonly ExtractTermCode TermCode;

        /// <summary>
        /// The parsed extract
        /// </summary>
        public readonly Addressable ParsedContent;   

        /// <summary>
        /// The host-relative operation identifier
        /// </summary>
        public OpIdentity Id 
            => Source.Id;

        /// <summary>
        /// The globally-unique operation uri 
        /// </summary>
        public OpUri Uri 
            => Source.Uri;

        /// <summary>
        /// The extract data
        /// </summary>
        public Addressable SourceContent 
            => Source.EncodedData;

        /// <summary>
        /// The operation memory address
        /// </summary>
        public MemoryAddress Address 
            => SourceContent.Address;

        public MethodInfo SourceMember 
            => Source.Member.Method;
        
        public ApiBits ParsedBits
            => ApiBits.Define(Id, ParsedContent);
    }
}