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
 
    using static Root;    

    public readonly struct ParsedExtract
    {
        [MethodImpl(Inline)]
        public static ParsedExtract Define(MemberExtract src, ExtractTermCode term, MemoryExtract parsed)
            => new ParsedExtract(src,term,parsed);

        [MethodImpl(Inline)]
        ParsedExtract(MemberExtract src, ExtractTermCode term, MemoryExtract parsed)
        {
            this.SourceExtract = src;
            this.TermCode = term;
            this.ParsedContent = parsed;
        }        

        public readonly MemberExtract SourceExtract;

        public readonly ExtractTermCode TermCode;

        public readonly MemoryExtract ParsedContent;   

        public OpIdentity Id 
            => SourceExtract.Id;

        public OpUri Uri 
            => SourceExtract.Uri;

        public MemoryExtract SourceContent 
            => SourceExtract.EncodedData;

        public MemoryAddress Address 
            => SourceContent.Address;

        public MethodInfo SourceMember 
            => SourceExtract.Member.Member;

        public MemberDescriptor Descriptor 
            => MemberDescriptor.Define(Uri, SourceMember.Signature().Format());
    }

    public readonly struct ParsedOpExtract
    {
        public readonly MemberDescriptor Operation;        

        public readonly ExtractTermCode TermCode;

        public readonly MemoryExtract Content;   

        [MethodImpl(Inline)]
        public static ParsedOpExtract Define(MemberDescriptor op, ExtractTermCode term, MemoryExtract parsed)
            => new ParsedOpExtract(op,term,parsed);

        [MethodImpl(Inline)]
        ParsedOpExtract(MemberDescriptor op, ExtractTermCode term, MemoryExtract parsed)
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