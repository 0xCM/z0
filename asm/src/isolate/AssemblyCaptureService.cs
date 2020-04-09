//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Reflection;

    using static Seed;
    using static Memories;
    using static AsmServiceMessages;

    readonly struct AssemblyCaptureService : IAssemblyCapture
    {
        public IAsmContext Context {get;}

        [MethodImpl(Inline)]
        public static AssemblyCaptureService Create(IAsmContext context)
            => new AssemblyCaptureService(context);

        [MethodImpl(Inline)]
        AssemblyCaptureService(IAsmContext context)
        {
            this.Context = context;
        }

        AsmEmissionPaths Paths
            => Context.EmissionPaths();

        public Option<MemberExtractReport> ExtractOps(ApiHost host)
        {
            var capture = Context.HostExtractor();
            var ops = capture.Extract(host);
            var report = MemberExtractReport.Create(host.UriPath, ops);            
            var target = Paths.ExtractPath(host.UriPath);  
            var saved = report.Save(target);
            var sink = Context;            
            saved.OnSome(file => sink.Notify(ExractedHost(host.UriPath, file)))
                .OnNone(() => sink.Notify(HostExtractionFailed(host.UriPath)));
            return saved ? some(report) : none<MemberExtractReport>();
        }

        public ParsedExtract[] Parse(MemberExtract[] src)
        {
            var parser = Context.ExtractParser(new byte[Context.DefaultBufferLength]);
            var parsed = parser.Parse(src);
            return parsed;
        }

        AsmFunctionList Decode(ApiHost host, MemberExtract[] extracted, ParsedMemberCode[] parsed)
        {
            var path = Paths.DecodedPath(host.UriPath);
            var decoder = Context.AsmFunctionDecoder();
            var functions = new AsmFunction[extracted.Length];
            using var dst = Context.AsmWriter(path, Context.AsmFormat.WithSectionDelimiter());            
            return AsmFunctionList.Define(functions);
        }

        CapturedOp[] CaptureHostOps(ApiHost host)
        {
            var extracts = list<CapturedOp>();
            Context.Notify($"Executing {host} capture workflow");            

            var capture = Context.HostExtractor();
            var extract = capture.Extract(host);
            var report = MemberExtractReport.Create(host.UriPath, extract);
            var target = Paths.ExtractPath(host.UriPath);  
            var sink = Context;
            report.Save(target)
                     .OnSome(file => sink.Notify(ExractedHost(host.UriPath, file)))
                     .OnNone(() => sink.Notify(HostExtractionFailed(host.UriPath)));
        

            return extracts.ToArray();
        }

        CapturedOp[] RunWorkflow(Assembly src)        
        {
            Context.Notify($"Executing {src.Id().Format()} capture workflow");

            var extracts = list<CapturedOp>();

            foreach(var host in src.ApiHosts())
                extracts.AddRange(CaptureHostOps(host));

            return extracts.ToArray();
        }

    }
}