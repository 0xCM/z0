//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Seed;
    using E = ExtractEvents.ExtractParseFailed;

    partial class ExtractEvents
    {
        public enum ExtractParseFailedField
        {
            Title,

            Term,

            Uri,
        }

        public readonly struct ExtractParseFailed : IAppEvent<E>
        {
            public static E Empty => new E(ExtractParseFailure.Empty);

            [MethodImpl(Inline)]
            public static E Define(ExtractParseFailure data)
                => new E(data);
            
            [MethodImpl(Inline)]
            ExtractParseFailed(ExtractParseFailure data)
            {
                Data = data;
            }
            
            public ExtractParseFailure Data {get;}
            
            const string Title = "Extract Parse Failure";
            
            const string TermLabel = "term";

            const string UriLabel = "uri";

            const string Delimiter = " | ";

            public string Description
                => text.label(Title, 
                    text.concat(
                        text.assign(TermLabel, Data.TermCode), Delimiter, 
                        text.assign(UriLabel, Data.OpUri)
                        ));
                
            public E Zero => Empty;            
        }    
    }
}