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
    using System.Reflection;
    using Z0.Asm;

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
            EmissionPaths.DecodedDir.Clear();
            foreach(var owner in owners)
            {
                var id = owner.Key;
                if(Selected.Contains(id))
                {

                    foreach(var host in owner)
                       yield return RunCaptureWorkflow(host);
                }
            }

            iter(Selected, CreateLocationReport);
        }

        void Decode(ParsedEncodingRecord src, IAsmFunctionDecoder decoder,  IAsmFunctionWriter dst)
        {
            var parsed = src.ToParsedEncoding();
            dst.Write(decoder.DecodeFunction(parsed));
        }

        static void EmitCil(Assembly src)
        {
            var index = ClrMetadataIndex.Create(src);
            var dir = AsmEmissionPaths.Current.CilDir;
            var srcId = src.AssemblyId();
            var context = AsmContext.New(index, DataResourceIndex.Empty, AsmFormatConfig.Default.WithSectionDelimiter());

            foreach(var host in src.ApiHosts())
            {
                var dstPath = AsmEmissionPaths.Current.CilPath(host);
                //var functions = capture.CaptureFunctions(host);
                //context.CilEmitter().EmitCil(functions, dstPath).OnSome(e => throw e);
            }            
        }

        (CapturedEncodingReport result, FilePath target) Capture(ApiHost host)
        {
            var extractor = Context.EncodingExtractor();
            var captured = extractor.Extract(host);
            var target = EmissionPaths.CapturePath(host);                
            captured.Save(target)
                        .OnSome(file => print($"Emitted {host} encodings to {file}"))
                        .OnNone(() => error($"Error emitting {host} encodings"));                       
            return (captured,target);
        }

        (ParsedEncodingReport,FilePath) Parse(ApiHost host, CapturedEncodingReport captured)
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

        FilePath Decode(ApiHost host, CapturedEncodingReport captured, ParsedEncodingReport parsed)
        {
            var path = EmissionPaths.DecodedPath(host);
            var decoder = Context.FunctionDecoder();
            using var dst = Context.AsmWriter(Context.AsmFormat.WithSectionDelimiter(), path);            
            for(var i=0; i< captured.RecordCount; i++)
            {
                var record = parsed[i];
                if(record.Length != 0)
                    Decode(record, decoder, dst);
            }
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