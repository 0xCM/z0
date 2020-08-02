//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    using E = ExtractParseFailed;

    public readonly struct ExtractParseFailed : IAppEvent<E>
    {
        [MethodImpl(Inline)]
        public static E create(ExtractParseFailure data)
            => new E(data);
        
        [MethodImpl(Inline)]
        public ExtractParseFailed(ExtractParseFailure data)
            => Data = data;
        
        public ExtractParseFailure Data {get;}
        
        const string Title = "Extract Parse Failure";
        
        const string TermLabel = "term";

        const string UriLabel = "uri";

        const string Delimiter = " | ";

        public string Format()
            => text.label(Title, 
                text.concat(
                    text.assign(TermLabel, Data.TermCode), Delimiter, 
                    text.assign(UriLabel, Data.OpUri)
                    ));
            
        public E Zero => Empty;            

        public static E Empty 
            => new E(ExtractParseFailure.Empty);
    }    
}