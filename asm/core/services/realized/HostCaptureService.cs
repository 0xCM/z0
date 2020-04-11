//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Reflection;
    using System.Linq;

    using static Z0.Seed;
    using static Memories;
    using Z0;

    readonly struct HostCaptureService : IHostCaptureService
    {
        public IAsmContext Context {get;}

        IHostCaptureService S => this;

        readonly IHostOpExtractor Extractor;

        readonly IOpExtractParser Parser;

        [MethodImpl(Inline)]
        public static HostCaptureService Create(IAsmContext context)
            => new HostCaptureService(context);

        [MethodImpl(Inline)]
        HostCaptureService(IAsmContext context)
        {
            Context = context;
            Extractor = Context.HostExtractor();
            Parser = Context.ExtractParser(new byte[Context.DefaultBufferLength]);
        }

        [MethodImpl(Inline)]
        public MemberExtract[] Extract(ApiHostUri host)
            => Extract(Host(host));

        [MethodImpl(Inline)]
        public ParsedExtract[] Parse(MemberExtract[] src)
            => Parser.Parse(src);
                
        [MethodImpl(Inline)]
        public AsmFunction[] Decode(ApiHostUri host, ParsedExtract[] parsed)
            => Decode(Host(host), parsed);

        MemberExtract[] Extract(IApiHost host)
        {            
            var extract = Extractor.Extract(host);
            var report = MemberExtractReport.Create(host.UriPath, extract);            
            var target = S.EmissionPaths.ExtractPath(host.UriPath);  
            return Extracted(host.UriPath, extract, report.Save(target));
        }

        AsmFunction[] Decode(IApiHost host, ParsedExtract[] parsed)
        {
            var path = S.EmissionPaths.DecodedPath(host.UriPath);
            var functions = new AsmFunction[parsed.Length];
            for(var i=0; i<parsed.Length; i++)
                functions[i] = require(S.Decoder.DecodeExtract(parsed[i]));

            using var dst = S.Writer(path);
            for(var i=0 ;i<functions.Length; i++)          
                dst.Write(functions[i]);

            return functions;
        }

        [MethodImpl(Inline)]
        Option<IApiHost> Host(ApiHostUri uri)
            => S.Hosts.TryFind(h => h.UriPath == uri);

        [MethodImpl(Inline)]
        AsmFunction[] Decode(Option<IApiHost> host, ParsedExtract[] parsed)
            => host ? Decode(host.Value, parsed) : Arrays.empty<AsmFunction>();

        [MethodImpl(Inline)]
        MemberExtract[] Extract(Option<IApiHost> host)
            => host ? Extract(host.Value) : Arrays.empty<MemberExtract>();

        MemberExtract[] Extracted(ApiHostUri host, MemberExtract[] extracts, Option<FilePath> dst)
        {
            if(dst)
                S.ExractedHost(host,dst.Value);
            else
                S.HostExtractionFailed(host);
            return extracts;
        }    
    }
}