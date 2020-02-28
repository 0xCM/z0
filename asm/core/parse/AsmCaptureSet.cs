//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    public class AsmCaptureSet
    {
        public static AsmCaptureSet Define(ApiHostPath host, CapturedEncodingReport captured, ParsedEncodingReport parsed, FilePath decoded)
            => new AsmCaptureSet
            {
                Host = host,
                Captured = captured,
                Parsed = parsed,
                DecodedPath = decoded
            };

        public ApiHostPath Host {get;set;}        

        public CapturedEncodingReport Captured {get;set;}

        public ParsedEncodingReport Parsed {get;set;}

        public FilePath DecodedPath {get;set;}
    }
}