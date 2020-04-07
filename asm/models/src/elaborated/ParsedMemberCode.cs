//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;
 
    using static Seed;    

    public readonly struct ParsedMemberCode
    {
        public readonly OpUri MemberUri;

        public readonly string MemberSig;
        
        public readonly MemoryExtract Content;   
        
        public readonly ExtractTermCode TermCode;

        [MethodImpl(Inline)]
        public static ParsedMemberCode Define(OpUri uri, string sig, ExtractTermCode term, MemoryExtract extract)
            => new ParsedMemberCode(uri, sig, term, extract);

        [MethodImpl(Inline)]
        ParsedMemberCode(OpUri uri, string sig, ExtractTermCode term, MemoryExtract parsed)
        {
            this.MemberUri = uri;
            this.MemberSig = sig;
            this.Content = parsed;
            this.TermCode = term;
        }        
    }
}