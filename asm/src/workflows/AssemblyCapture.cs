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

    using Asm;
    using static AsmServiceMessages;
    using static Root;

    readonly struct AssemblyCapture : IAssemblyCapture
    {
        public IAsmContext Context {get;}

        [MethodImpl(Inline)]
        public static AssemblyCapture Create(IAsmContext context)
            => new AssemblyCapture(context);

        [MethodImpl(Inline)]
        AssemblyCapture(IAsmContext context)
        {
            this.Context = context;
        }

        AsmEmissionPaths Paths
            => Context.EmissionPaths();

        public FiniteSeq<CapturedOp> Capture(AssemblyId src)
        {
            return default;
        }

        public Option<OpExtractReport> ExtractOps(ApiHost host)
        {
            var capture = Context.HostExtractor();
            var ops = capture.Extract(host);
            var report = OpExtractReport.Create(ops);            
            var target = Paths.ExtractPath(host.Path);  
            var saved = report.Save(target);
            var sink = Context;            
            saved.OnSome(file => sink.Notify(ExractedHost(host.Path,file)))
                .OnNone(() => sink.Notify(HostExtractionFailed(host.Path)));
            return saved ? some(report) : none<OpExtractReport>();
        }

        public ParsedExtract[] Parse(OpExtract[] src)
        {
            var parser = Context.ExtractParser(new byte[Context.DefaultBufferLength]);
            var parsed = parser.Parse(src);
            return parsed;
        }

        AsmFunctionList Decode(ApiHost host, OpExtract[] extracted, ParsedOpExtract[] parsed)
        {
            var path = Paths.DecodedPath(host.Path);
            var decoder = Context.FunctionDecoder();
            var functions = new AsmFunction[extracted.Length];
            using var dst = Context.AsmWriter(Context.AsmFormat.WithSectionDelimiter(), path);            
            // for(var i=0; i< extracted.Length; i++)
            // {
            //     var record = parsed[i];
            //     if(record.Length != 0)
            //         functions[i] = Decode(record, decoder, dst);
            //     else
            //         functions[i] = AsmFunction.Empty;
            // }
            return AsmFunctionList.Define(functions);
        }

        CapturedOp[] CaptureHostOps(ApiHost src)
        {
            var extracts = list<CapturedOp>();            
            Context.Notify($"Executing {src} capture workflow");            

            var capture = Context.HostExtractor();
            var captured = capture.ExtractOps(src);
            var target = Paths.ExtractPath(src.Path);  
            var sink = Context;
            captured.Save(target)
                     .OnSome(file => sink.Notify(ExractedHost(src.Path,file)))
                     .OnNone(() => sink.Notify(HostExtractionFailed(src.Path)));
        

            return extracts.ToArray();
        }

        CapturedOp[] RunWorkflow(Assembly src)        
        {
            Context.Notify($"Executing {src.AssemblyId().Format()} capture workflow");

            var extracts = list<CapturedOp>();

            foreach(var host in src.ApiHosts())
                extracts.AddRange(CaptureHostOps(host));

            return extracts.ToArray();
        }

    }
}