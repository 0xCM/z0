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

        public MemberExtract[] Extract(ApiHost host)
        {
            var capture = Context.HostExtractor();
            var extract = capture.Extract(host);
            var report = MemberExtractReport.Create(host.UriPath, extract);            
            var target = Paths.ExtractPath(host.UriPath);  
            var saved = report.Save(target);
            var sink = Context;            
            saved.OnSome(file => sink.Notify(ExractedHost(host.UriPath, file)))
                .OnNone(() => sink.Notify(HostExtractionFailed(host.UriPath)));
            return extract;
        }

        public ParsedExtract[] Parse(MemberExtract[] src)
        {
            var parser = Context.ExtractParser(new byte[Context.DefaultBufferLength]);
            var parsed = parser.Parse(src);
            return parsed;
        }

        public AsmFunction[] Decode(ApiHost host, ParsedExtract[] parsed)
        {
            var path = Paths.DecodedPath(host.UriPath);
            var decoder = Context.AsmFunctionDecoder();
            var functions = new AsmFunction[parsed.Length];
            for(var i=0; i<parsed.Length; i++)
                functions[i] = require(decoder.DecodeExtract(parsed[i]));

            using var dst = Context.AsmWriter(path, Context.AsmFormat.WithSectionDelimiter());  
            for(var i=0 ;i<functions.Length; i++)          
                dst.Write(functions[i]);

            return functions;
        }
    }
}