//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Collections.Generic;
    using System.Linq;
    using System.Reflection;

    using static Seed;
    using static Memories;
    using static AsmServiceMessages;

    readonly struct HostCaptureService : IHostCapture
    {
        public IAsmContext Context {get;}

        readonly IApiSet ApiSet;

        readonly IAsmFunctionDecoder Decoder;

        public HashSet<PartId> Selected {get;}

        [MethodImpl(Inline)]
        public static IHostCapture Create(IAsmContext context, IAsmFunctionDecoder decoder, params PartId[] selected)
            => new HostCaptureService(context, decoder, selected);

        [MethodImpl(Inline)]
        HostCaptureService(IAsmContext context, IAsmFunctionDecoder decoder, PartId[] selected)
        {
            this.Context = context;
            this.Decoder = decoder;
            this.ApiSet = context.ApiSet;
            this.Selected = selected.Length == 0 ? context.ApiSet.PartIdentities.ToHashSet() : selected.ToHashSet();
        }

        AsmEmissionPaths Paths
            => Context.EmissionPaths();

        Option<MemberLocationReport> LocationReport(PartId src)
            => from a in ResolvedAssembly(src)
                let methods = a.GetTypes().DeclaredMethods().Static().NonGeneric().WithoutConversionOperators()
                select MemberLocationReport.Create(src, methods);
        
        Option<Assembly> ResolvedAssembly(PartId id)
            =>  (from r in  ApiSet.Composition.Resolved
                where r.Id == id
                select r.Owner).FirstOrDefault();

        void CreateLocationReport(PartId id)
            => LocationReport(id).OnSome(report => report.Save());
        
        public IEnumerable<ApiHostCapture> Execute(params string[] args)
        {            
            var owners = ApiSet.Composition.Catalogs.SelectMany(c => c.ApiHosts).GroupBy(x => x.Owner);
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

        Option<AsmFunction> Decode(MemberParseRecord src, IFunctionStreamWriter dst)
        {            
            var f = Decoder.DecodeParsed(src.ToParsedEncoding());
            f.OnSome(x => dst.Write(x)).OnNone(() => term.error($"Decoding {src.Uri} failed"));
            return f;
        }

        static void EmitCil(Assembly src)
        {
            var index = src.CreateClrIndex();
            var dir = AsmEmissionPaths.Define().CilDir;
            var srcId = src.Id();

            foreach(var host in src.ApiHosts())
            {
                var dstPath = AsmEmissionPaths.Define().CilPath(host.UriPath);
                //var functions = capture.CaptureFunctions(host);
                //context.CilEmitter().EmitCil(functions, dstPath).OnSome(e => throw e);
            }            
        }

        MemberExtractReport Extract(IApiHost host)
        {
            var extractor = Context.HostExtractor();
            var ops = extractor.Extract(host);
            var report = MemberExtractReport.Create(host.UriPath, ops);

            //var report = extractor.ExtractOps(host);
            var dstpath = Paths.ExtractPath(host.UriPath);  
            var sink = Context;
            report.Save(dstpath)
                     .OnSome(file => sink.Notify(ExractedHost(host.UriPath,file)))
                     .OnNone(() => sink.Notify(HostExtractionFailed(host.UriPath)));
            return report;
        }

        MemberParseReport Parse(IApiHost host, MemberExtractReport extract)
        {
            var parser = Context.ExtractParser(new byte[Context.DefaultBufferLength]);
            var parsed = parser.Parse(host,extract);
            var target = Paths.ParsedPath(host.UriPath);
            var sink = Context;
            parsed.Save(target)
                        .OnSome(file => sink.Notify(ParsedExtracts(host.UriPath,file)))
                        .OnNone(() => sink.Notify(ExtractParseFailure(host.UriPath)));
            require(extract.RecordCount == parsed.RecordCount);
            return parsed;
        }

        AsmFunctionList Decode(IApiHost host, MemberExtractReport captured, MemberParseReport parsed)
        {
            var path = Paths.DecodedPath(host.UriPath);
            var functions = new AsmFunction[captured.RecordCount];
            using var dst = Context.AsmWriter(path, Context.AsmFormat.WithSectionDelimiter());            
            for(var i=0; i< captured.RecordCount; i++)
            {
                var record = parsed[i];
                if(record.Length != 0)
                {   
                    var f = Decode(record,dst);
                    if(f)
                        functions[i] = f.Value;
                }
                else
                    functions[i] = AsmFunction.Empty;
            }
            return AsmFunctionList.Define(functions);
        }

        public ApiHostCapture CaptureHostOps(ApiHost host)        
        {
            Context.Notify($"Executing {host} capture workflow");
            var extracted = Extract(host);
            var parsed = Parse(host, extracted);
            var decoded = Decode(host, extracted, parsed);        
            return ApiHostCapture.Define(host.UriPath, extracted, parsed, decoded);
        }
    }
}