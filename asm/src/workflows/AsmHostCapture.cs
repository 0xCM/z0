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

    using static AsmServiceMessages;
    using static Root;

    readonly struct AsmHostCapture : IHostCapture
    {
        public IAsmContext Context {get;}

        public HashSet<AssemblyId> Selected {get;}

        [MethodImpl(Inline)]
        public static IHostCapture Create(IAsmContext context, params AssemblyId[] selected)
            => new AsmHostCapture(context,selected);

        [MethodImpl(Inline)]
        AsmHostCapture(IAsmContext context, AssemblyId[] selected)
        {
            this.Context = context;
            this.Selected = selected.Length == 0 ? context.Assemblies.ToHashSet() : selected.ToHashSet();
        }

        AsmEmissionPaths Paths
            => Context.EmissionPaths();

        void CreateLocationReport(AssemblyId id)
            => Context.LocationReport(id).OnSome(report => report.Save());
        
        public IEnumerable<CapturedHost> Execute()
        {            
            var owners = Context.Compostion.Catalogs.SelectMany(c => c.ApiHosts).GroupBy(x => x.Owner);
            var config = Context.AsmFormat.WithSectionDelimiter();
            Paths.DecodedDir.Clear();
            Paths.ParsedDir.Clear();
            Paths.ExtractDir.Clear();

            foreach(var owner in owners)
            {
                var id = owner.Key;
                if(Selected.Contains(id))
                    foreach(var host in owner)
                       yield return CaptureHostOps(host);
            }

            iter(Selected, CreateLocationReport);
        }

        AsmFunction Decode(ParsedOpRecord src, IAsmFunctionDecoder decoder,  IAsmFunctionWriter dst)
        {
            var f = decoder.DecodeFunction(src);
            dst.Write(f);
            return f;
        }

        static void EmitCil(Assembly src)
        {
            var index = src.CreateIndex();
            var dir = AsmEmissionPaths.Current.CilDir;
            var srcId = src.AssemblyId();
            var context = AsmContext.New(index, DataResourceIndex.Empty, AsmFormatConfig.Default.WithSectionDelimiter());

            foreach(var host in src.ApiHosts())
            {
                var dstPath = AsmEmissionPaths.Current.CilPath(host.Path);
                //var functions = capture.CaptureFunctions(host);
                //context.CilEmitter().EmitCil(functions, dstPath).OnSome(e => throw e);
            }            
        }

        OpExtractReport Extract(ApiHost host)
        {
            var extractor = Context.HostExtractor();
            var report = extractor.ExtractOps(host);
            var dstpath = Paths.ExtractPath(host.Path);  
            var sink = Context;
            report.Save(dstpath)
                     .OnSome(file => sink.Notify(ExractedHost(host.Path,file)))
                     .OnNone(() => sink.Notify(HostExtractionFailed(host.Path)));
            return report;
        }

        ParsedOpReport Parse(ApiHost host, OpExtractReport extract)
        {
            var parser = Context.ExtractParser(new byte[Context.DefaultBufferLength]);
            var parsed = parser.Parse(host,extract);
            var target = Paths.ParsedPath(host.Path);
            var sink = Context;
            parsed.Save(target)
                        .OnSome(file => sink.Enqueue(ParsedExtracts(host.Path,file)))
                        .OnNone(() => sink.Enqueue(ExtractParseFailure(host.Path)));
            require(extract.RecordCount == parsed.RecordCount);
            return parsed;
        }

        AsmFunctionList Decode(ApiHost host, OpExtractReport captured, ParsedOpReport parsed)
        {
            var path = Paths.DecodedPath(host.Path);
            var decoder = Context.FunctionDecoder();
            var functions = new AsmFunction[captured.RecordCount];
            using var dst = Context.AsmWriter(Context.AsmFormat.WithSectionDelimiter(), path);            
            for(var i=0; i< captured.RecordCount; i++)
            {
                var record = parsed[i];
                if(record.Length != 0)
                    functions[i] = Decode(record, decoder, dst);
                else
                    functions[i] = AsmFunction.Empty;
            }
            return AsmFunctionList.Define(functions);
        }

        public CapturedHost CaptureHostOps(ApiHost host)        
        {
            Context.Enqueue($"Executing {host} capture workflow");
            var extracted = Extract(host);
            var parsed = Parse(host, extracted);
            var decoded = Decode(host, extracted, parsed);        
            return CapturedHost.Define(host.Path, extracted, parsed, decoded);
        }
    }
}