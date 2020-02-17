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

    public class AsmCaptureFlowOutcome
    {
        public ApiHostPath Host {get;set;}
        
        public FilePath CapturedPath {get;set;}

        public CapturedEncodings Captured {get;set;}

        public FilePath ParsedPath {get;set;}

        public ParsedEncodings Parsed {get;set;}

        public FilePath DecodedPath {get;set;}

    }

    public interface IAsmCaptureFlow : IExecutable<AsmCaptureFlowOutcome>
    {

    }

    readonly struct AsmCaptureFlow : IAsmCaptureFlow
    {
        public IAsmContext Context {get;}

        [MethodImpl(Inline)]
        public static IAsmCaptureFlow Create(IAsmContext context)
            => new AsmCaptureFlow(context);

        [MethodImpl(Inline)]
        AsmCaptureFlow(IAsmContext context)
        {
            this.Context = context;
        }
        
        void CreateLocationReport(AssemblyId id)
            => Context.MemberLocations(id).OnSome(report => report.Save());

        public IEnumerable<AsmCaptureFlowOutcome> Execute()
        {            
            var hosts = Context.Compostion.Catalogs.SelectMany(c => c.ApiHosts);
            var config = Context.AsmFormat.WithSectionDelimiter();
            foreach(var host in hosts)
                yield return RunCaptureWorkflow(host);

            iter(Context.Assemblies, CreateLocationReport);
        }

        void Decode(CapturedEncoding captured, ParsedEncoding encoded, IAsmDecoder decoder,  IAsmFunctionWriter dst)
        {
            var count = encoded.Length;
            if(count != 0)
            {
                var op = captured.GetOpInfo();
                var bits = CaptureBits.Define(captured.Data, encoded.Data);
                var range = MemoryRange.Define(captured.Address, captured.Address + (ulong)count);
                var tc = encoded.TermCode;

                var final = CaptureState.Define(op.Id, count, range.End, bits.Trimmed.Last());
                var outcome = CaptureOutcome.Define(final, range, tc);
                var summary = CaptureSummary.Define(outcome, bits);
                dst.Write(decoder.DecodeFunction(op, summary));
            }
        }

        (CapturedEncodings result, FilePath target) Capture(ApiHost host)
        {
            var extractor = Context.EncodingExtractor();
            var captured = extractor.Extract(host);
            var target = AsmReports.EncodingExtract(host);                
            captured.Save(target)
                        .OnSome(file => print($"Emitted {host} encodings to {file}"))
                        .OnNone(() => errout($"Error emitting {host} encodings"));                       
            return (captured,target);
        }


        (ParsedEncodings,FilePath) Parse(ApiHost host, CapturedEncodings captured)
        {
            var parser = Context.EncodingParser();
            var parsed = parser.Parse(host,captured);
            var target = Paths.ParsedEncoding(host);
            parsed.Save(target)
                        .OnSome(file => print($"Emitted parsed {host} encodings to {file}"))
                        .OnNone(() => errout($"Error parsing {host} encodings"));                       

            require(captured.RecordCount == parsed.RecordCount);
            return (parsed,target);
        }

        FilePath Decode(ApiHost host, CapturedEncodings captured, ParsedEncodings parsed)
        {
            var path = Paths.DecodedEncoding(host);
            var decoder = Context.Decoder();            
            using var dst = Context.AsmWriter(Context.AsmFormat.WithSectionDelimiter(), path);
            for(var i=0; i< captured.RecordCount; i++)
                Decode(captured[i], parsed[i], decoder, dst);
            return path;
        }

        AsmCaptureFlowOutcome RunCaptureWorkflow(ApiHost host)        
        {
            print($"Capturing {host}");
            (var captured, var capturePath) = Capture(host);            
            (var parsed, var parsedPath) = Parse(host, captured);
            var decodingPath = Decode(host, captured, parsed);
            return new AsmCaptureFlowOutcome
            {
                Host = host.Path,
                CapturedPath = capturePath,
                Captured = captured,
                ParsedPath = parsedPath,
                Parsed = parsed,
                DecodedPath = decodingPath
            };
        }
    }
}