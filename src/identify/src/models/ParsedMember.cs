//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
 
    using static Seed;    

    public readonly struct ParsedMember
    {
        public readonly OpUri MemberUri;

        public readonly string MemberSig;
        
        public readonly LocatedCode Content;   
        
        public readonly ExtractTermCode TermCode;

        [MethodImpl(Inline)]
        public static ParsedMember Define(OpUri uri, string sig, ExtractTermCode term, LocatedCode extract)
            => new ParsedMember(uri, sig, term, extract);

        [MethodImpl(Inline)]
        ParsedMember(OpUri uri, string sig, ExtractTermCode term, LocatedCode parsed)
        {
            this.MemberUri = uri;
            this.MemberSig = sig;
            this.Content = parsed;
            this.TermCode = term;
        }        
    }
}