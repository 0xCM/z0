//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Collections.Generic;
    using System.Linq;
    
    using static zfunc;

    readonly struct AsmCaptureFlow : IExecutable
    {
        public IAsmContext Context {get;}

        [MethodImpl(Inline)]
        public static IExecutable Create(IAsmContext context)
            => new AsmCaptureFlow(context);

        [MethodImpl(Inline)]
        AsmCaptureFlow(IAsmContext context)
        {
            this.Context = context;
        }
        
        public void Execute()
        {
            var hosts = Context.Assemblies.Catalogs.SelectMany(c => c.ApiHosts);//.Where(c => c.HostingType.Name != "CpuVector");
            var extractor = Context.EncodingExtractor();
            var parser = Context.EncodingParser();
            var decoder = Context.Decoder();
            var config = Context.AsmFormat.WithSectionDelimiter();

            foreach(var host in hosts)
                RunCaptureWorkflow(host);            
        }

        void Decode(CapturedEncoding captured, ParsedEncoding encoded, IAsmDecoder decoder,  IAsmFunctionWriter dst)
        {
            var op = captured.GetOpInfo();
            var bits = CaptureBits.Define(captured.Data, encoded.Data);
            var count = encoded.Length;
            var range = MemoryRange.Define(captured.Address, captured.Address + (ulong)count);
            var tc = encoded.TermCode;

            var final = CaptureState.Define(op.Id, count, range.End, bits.Trimmed.Last());
            var outcome = CaptureOutcome.Define(final, range, tc);
            var summary = CaptureSummary.Define(outcome, bits);
            dst.Write(decoder.DecodeFunction(op, summary));
        }

        CapturedEncodings Capture(ApiHost host)
        {
            var extractor = Context.EncodingExtractor();
            var captured = extractor.Extract(host);
            var target = AsmReports.EncodingExtract(host);                
            captured.Save(target)
                        .OnSome(file => print($"Emitted {host} encodings to {file}"))
                        .OnNone(() => errout($"Error emitting {host} encodings"));                       
            return captured;
        }

        ParsedEncodings Parse(ApiHost host, CapturedEncodings captured)
        {
            var parser = Context.EncodingParser();
            var parsed = parser.Parse(host,captured);
            var target = Paths.ParsedEncoding(host);
            parsed.Save(target)
                        .OnSome(file => print($"Emitted parsed {host} encodings to {file}"))
                        .OnNone(() => errout($"Error parsing {host} encodings"));                       

            require(captured.RecordCount == parsed.RecordCount);
            return parsed;
        }

        void Decode(ApiHost host, CapturedEncodings captured, ParsedEncodings parsed)
        {
            var path = Paths.DecodedEncoding(host);
            var decoder = Context.Decoder();            
            using var dst = Context.AsmWriter(Context.AsmFormat.WithSectionDelimiter(), path);
            for(var i=0; i< captured.RecordCount; i++)
                Decode(captured[i], parsed[i], decoder, dst);
        }

        void RunCaptureWorkflow(ApiHost host)        
        {
            var captured = Capture(host);            
            var parsed = Parse(host, captured);
            Decode(host, captured, parsed);

        }
    }
}