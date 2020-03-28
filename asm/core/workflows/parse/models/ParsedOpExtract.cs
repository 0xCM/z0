//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Reflection;
    using System.Linq;
    using System.Runtime.CompilerServices;
 
    using static root;    

    public readonly struct ParsedExtract
    {
        [MethodImpl(Inline)]
        public static ParsedExtract Define(MemberExtract src, int seq, ExtractTermCode term, MemoryExtract parsed)
            => new ParsedExtract(src, seq, term,parsed);

        [MethodImpl(Inline)]
        ParsedExtract(MemberExtract src, int seq, ExtractTermCode term, MemoryExtract parsed)
        {
            this.SourceExtract = src;
            this.SourceSequence = seq;
            this.TermCode = term;
            this.ParsedContent = parsed;
        }        

        /// <summary>
        /// The extracted member,
        /// </summary>
        public readonly MemberExtract SourceExtract;

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
        public readonly MemoryExtract ParsedContent;   

        /// <summary>
        /// The host-relative operation identifier
        /// </summary>
        public OpIdentity Id 
            => SourceExtract.Id;

        /// <summary>
        /// The globally-unique operation uri 
        /// </summary>
        public OpUri Uri 
            => SourceExtract.Uri;

        /// <summary>
        /// The extract data
        /// </summary>
        public MemoryExtract SourceContent 
            => SourceExtract.EncodedData;

        /// <summary>
        /// The operation memory address
        /// </summary>
        public MemoryAddress Address 
            => SourceContent.Address;

        public MethodInfo SourceMember 
            => SourceExtract.Member.Method;

        public ApiMemberInfo Descriptor 
            => ApiMemberInfo.Define(Uri, SourceMember.Signature().Format());
        
        public AsmCode Code
            => AsmCode.Define(Id, ParsedContent);
    }

    public readonly struct ParsedOpExtract
    {
        public readonly ApiMemberInfo Operation;        

        public readonly ExtractTermCode TermCode;

        public readonly MemoryExtract Content;   

        [MethodImpl(Inline)]
        public static ParsedOpExtract Define(ApiMemberInfo op, ExtractTermCode term, MemoryExtract parsed)
            => new ParsedOpExtract(op,term,parsed);

        [MethodImpl(Inline)]
        ParsedOpExtract(ApiMemberInfo op, ExtractTermCode term, MemoryExtract parsed)
        {
            this.Operation = op;
            this.Content = parsed;
            this.TermCode = term;
        }        
    }

    public readonly struct ParsedOpExtracts : IFiniteSeq<ParsedOpExtract>
    {
        [MethodImpl(Inline)]
        public static implicit operator ParsedOpExtracts(ParsedOpExtract[] src)
            => new ParsedOpExtracts(src);
        
        [MethodImpl(Inline)]
        public ParsedOpExtracts(ParsedOpExtract[] content)
        {
            this.Content = content;
        }
        
        public ParsedOpExtract[] Content {get;}
    }    
}