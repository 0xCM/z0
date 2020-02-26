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

    readonly struct AsmCaptureFlow : IAsmCaptureFlow
    {
        public IAsmContext Context {get;}

        public HashSet<AssemblyId> Selected {get;}

        [MethodImpl(Inline)]
        public static IAsmCaptureFlow Create(IAsmContext context, params AssemblyId[] selected)
            => new AsmCaptureFlow(context,selected);

        [MethodImpl(Inline)]
        AsmCaptureFlow(IAsmContext context, AssemblyId[] selected)
        {
            this.Context = context;
            this.Selected = selected.Length == 0 ? context.Assemblies.ToHashSet() : selected.ToHashSet();
        }

        AsmEmissionPaths EmissionPaths
            => Context.EmissionPaths();

        void CreateLocationReport(AssemblyId id)
            => Context.MemberLocations(id).OnSome(report => report.Save());

        public IEnumerable<AsmCaptureSet> Execute()
        {            
            var owners = Context.Compostion.Catalogs.SelectMany(c => c.ApiHosts).GroupBy(x => x.Owner);
            var config = Context.AsmFormat.WithSectionDelimiter();
            foreach(var owner in owners)
            {
                var id = owner.Key;
                if(Selected.Contains(id))
                {
                    EmissionPaths.DataFolderDir(id).Clear();

                    foreach(var host in owner)
                       yield return RunCaptureWorkflow(host);
                }
            }

            iter(Selected, CreateLocationReport);
        }

        void Decode(CapturedEncodingRecord captured, ParsedEncoding encoded, IAsmDecoder decoder,  IAsmFunctionWriter dst)
        {
            var count = encoded.Length;
            if(count != 0)
            {
                var op = captured.GetDescription();
                var bits = CaptureBits.Define(captured.Data, encoded.Data);
                var range = MemoryRange.Define(captured.Address, captured.Address + (MemoryAddress)count);
                var tc = encoded.TermCode;

                var final = CaptureState.Define(op.Id, count, range.End, bits.Trimmed.Last());
                var outcome = CaptureOutcome.Define(final, range, tc);
                var summary = CaptureSummary.Define(outcome, bits);
                dst.Write(decoder.DecodeFunction(op, summary));
            }
        }

        (CapturedEncodingReport result, FilePath target) Capture(ApiHost host)
        {
            var extractor = Context.EncodingExtractor();
            var captured = extractor.Extract(host);
            var target = EmissionPaths.CaptureSummaryPath(host);                
            captured.Save(target)
                        .OnSome(file => print($"Emitted {host} encodings to {file}"))
                        .OnNone(() => error($"Error emitting {host} encodings"));                       
            return (captured,target);
        }

        (ParsedEncodings,FilePath) Parse(ApiHost host, CapturedEncodingReport captured)
        {
            var parser = Context.EncodingParser();
            var parsed = parser.Parse(host,captured);
            var target = EmissionPaths.ParsedPath(host);
            parsed.Save(target)
                        .OnSome(file => print($"Emitted parsed {host} encodings to {file}"))
                        .OnNone(() => error($"Error parsing {host} encodings"));                       

            require(captured.RecordCount == parsed.RecordCount);
            return (parsed,target);
        }

        FilePath Decode(ApiHost host, CapturedEncodingReport captured, ParsedEncodings parsed)
        {
            var path = EmissionPaths.DetailPath(host);
            var decoder = Context.Decoder();            
            using var dst = Context.AsmWriter(Context.AsmFormat.WithSectionDelimiter(), path);
            for(var i=0; i< captured.RecordCount; i++)
                Decode(captured[i], parsed[i], decoder, dst);
            return path;
        }

        AsmCaptureSet RunCaptureWorkflow(ApiHost host)        
        {
            print($"Capturing {host}");
            (var captured, var capturePath) = Capture(host);            
            (var parsed, var parsedPath) = Parse(host, captured);
            var decodingPath = Decode(host, captured, parsed);
            return new AsmCaptureSet
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