//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    public readonly struct ExtractParseFailed : IWfEvent<ExtractParseFailed>
    {
        public const string EventName = nameof(ExtractParseFailed);
        
        public WfEventId EventId {get;}                
        
        [MethodImpl(Inline)]
        public ExtractParseFailed(ExtractParseFailure data)
        {
            Data = data;
            EventId = WfEventId.define(EventName);
        }
        
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
            
        public ExtractParseFailed Zero => Empty;            

        public static ExtractParseFailed Empty 
            => new ExtractParseFailed(ExtractParseFailure.Empty);
    }    
}