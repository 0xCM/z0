//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    public class AsmCaptureSet
    {
        public static AsmCaptureSet Define(ApiHostPath host, CapturedEncodingReport captured, Report<ParsedEncodingRecord> parsed, FilePath decoded)
            => new AsmCaptureSet
            {
                Host = host,
                Captured = captured,
                Parsed = parsed,
                DecodedPath = decoded
            };

        public ApiHostPath Host {get;set;}        

        public CapturedEncodingReport Captured {get;set;}

        public Report<ParsedEncodingRecord> Parsed {get;set;}

        public FilePath DecodedPath {get;set;}
    }
}