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

    public readonly struct ParsedMember
    {
        /// <summary>
        /// The extracted member,
        /// </summary>
        public readonly MemberExtract Source;

        /// <summary>
        /// The extracted member sequence
        /// </summary>
        public readonly int SourceSequence;

        /// <summary>
        /// The reason for extract completion
        /// </summary>
        public readonly ExtractTermCode TermCode;

        /// <summary>
        /// The parsed code
        /// </summary>
        public readonly LocatedCode ParsedContent;   

        [MethodImpl(Inline)]
        public ParsedMember(MemberExtract src, int seq, ExtractTermCode term, LocatedCode parsed)
        {
            this.Source = src;
            this.SourceSequence = seq;
            this.TermCode = term;
            this.ParsedContent = parsed;
        }        

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
        /// The member kind, if known
        /// </summary>
        public OpKindId KindId
            => Source.Member.KindId;

        /// <summary>
        /// Specifies whether the parsed member is of known kind
        /// </summary>
        public bool IsKinded
            => KindId != 0;

        /// <summary>
        /// The extract data
        /// </summary>
        public LocatedCode SourceContent 
            => Source.Content;

        /// <summary>
        /// The operation memory address
        /// </summary>
        public MemoryAddress Address 
            => SourceContent.Address;

        public MethodInfo Reflected 
            => Source.Member.Method;
        
        public OperationBits ParsedBits 
            => OperationBits.Define(Uri, ParsedContent);
    }
}