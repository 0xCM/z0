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

    
    class HostCaptureService : IHostCaptureService
    {
        public IAsmContext Context {get;}

        [MethodImpl(Inline)]
        public static HostCaptureService Create(IAsmContext context)
            => new HostCaptureService(context);

        [MethodImpl(Inline)]
        HostCaptureService(IAsmContext context)
        {
            Context = context;
            Extractor = Context.HostExtractor();
            Paths = Context.EmissionPaths();
            Sink = context;
            Parser = Context.ExtractParser(new byte[Context.DefaultBufferLength]);
            Decoder = Context.AsmFunctionDecoder();
            WriterFactory = Context.AsmWriterFactory();
            Formatter = Context.AsmFormatter();
        }


        readonly IAppMsgSink Sink;
        
        readonly AsmEmissionPaths Paths;

        readonly IHostOpExtractor Extractor;

        readonly IOpExtractParser Parser;

        readonly IAsmFunctionDecoder Decoder;

        readonly IAsmFormatter Formatter;

        readonly AsmWriterFactory WriterFactory;

        public MemberExtract[] Extract(ApiHost host)
        {            
            var extract = Extractor.Extract(host);
            var report = MemberExtractReport.Create(host.UriPath, extract);            
            var target = Paths.ExtractPath(host.UriPath);  
            var saved = report.Save(target);
            saved.OnSome(file => Sink.Notify(ExractedHost(host.UriPath, file)))
                .OnNone(() => Sink.Notify(HostExtractionFailed(host.UriPath)));
            return extract;
        }

        public ParsedExtract[] Parse(MemberExtract[] src)
            => Parser.Parse(src);

        public AsmFunction[] Decode(ApiHost host, ParsedExtract[] parsed)
        {
            var path = Paths.DecodedPath(host.UriPath);
            var functions = new AsmFunction[parsed.Length];
            for(var i=0; i<parsed.Length; i++)
                functions[i] = require(Decoder.DecodeExtract(parsed[i]));

            using var dst = WriterFactory(path,Formatter);
            for(var i=0 ;i<functions.Length; i++)          
                dst.Write(functions[i]);

            return functions;
        }
    }
}