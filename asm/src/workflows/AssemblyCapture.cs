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

        // AsmHostExtract RunHostCaptureFlow(ApiHost host)        
        // {
        //     Context.Enqueue($"Executing {host} capture workflow");
        //     var captured = CaptureHostOps(host);
        //     var parsed = Parse(host, captured);
        //     var decoded = Decode(host, captured, parsed);        
        //     return (host.Path, captured, parsed, decoded);
        // }

        OpExtractReport CaptureHost(ApiHost host)
        {
            var capture = Context.HostExtractor();
            var captured = capture.ExtractOps(host);
            var target = Paths.RawCapturePath(host.Path);  
            var sink = Context;
            captured.Save(target)
                     .OnSome(file => sink.Enqueue(ExractedEncodings(host.Path,file)))
                     .OnNone(() => sink.Enqueue(HostExtrationFailed(host.Path)));
            return captured;
        }

        CapturedOp[] CaptureHostOps(ApiHost src)
        {
            var extracts = list<CapturedOp>();            
            Context.Notify($"Executing {src} capture workflow");            

            var capture = Context.HostExtractor();
            var captured = capture.ExtractOps(src);
            var target = Paths.RawCapturePath(src.Path);  
            var sink = Context;
            captured.Save(target)
                     .OnSome(file => sink.Enqueue(ExractedEncodings(src.Path,file)))
                     .OnNone(() => sink.Enqueue(HostExtrationFailed(src.Path)));

            


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