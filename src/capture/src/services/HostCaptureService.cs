//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Seed;
    using static Memories;

    readonly struct HostCaptureService : IHostCaptureService
    {
        public IAsmContext Context {get;}

        readonly FolderName Area;

        readonly FolderName Subject;

        readonly FolderPath Root;

        readonly IHostCodeExtractor Extractor;

        readonly IExtractParser Parser;

        ICaptureArchive CodeArchive 
        {
            get             
            {
                if(Area.IsNonEmpty || Subject.IsNonEmpty)
                    return Context.CaptureArchive(Area, Subject);
                else
                    return Archives.Services.CaptureArchive(Root);
            }
        }

        [MethodImpl(Inline)]
        internal HostCaptureService(IAsmContext context, FolderName area, FolderName subject)
        {
            Context = context;
            Area = area;
            Subject = subject;
            Root = (context.RootCaptureArchive.RootDir + area) + subject;
            Extractor = AsmWorkflows.Stateless.HostExtractor();
            Parser = Z0.Extract.Services.ExtractParser(new byte[Context.DefaultBufferLength]);
        }

        [MethodImpl(Inline)]
        internal HostCaptureService(IAsmContext context, FolderPath root)
        {
            Context = context;
            Area = FolderName.Empty;
            Subject = FolderName.Empty;
            Root = root;
            Extractor = AsmWorkflows.Stateless.HostExtractor();
            Parser = Z0.Extract.Services.ExtractParser(new byte[Context.DefaultBufferLength]);
        }

        public MemberExtract[] Extract(ApiHostUri host, bool save)
            => Extract(FindHost(host),save);

        public ParsedMember[] Parse(ApiHostUri host, MemberExtract[] src, bool save)
        {
            var outcome = Parser.Parse(src);
            if(outcome.Parsed.Length != 0 && save)
                Save(host,outcome.Parsed);
            return outcome.Parsed;
        }

        [MethodImpl(Inline)]
        public AsmFunction[] Decode(ApiHostUri host, ParsedMember[] parsed, bool save)
            => Decode(FindHost(host), parsed, save);

        public HostCapture CaptureHost(ApiHostUri host, bool save)
        {
            var extracts = Extract(host, save);
            var parsed = Parse(host,extracts, save);
            var decoded = Decode(host,parsed,save);
            return HostCapture.Define(host, extracts,parsed,decoded);
        }

        void Save(ApiHostUri host, ParsedMember[] src)
        {
            var hostArchive = CodeArchive.HostArchive(host);
            var report = MemberParseReport.Create(host,src);
            report.Save(hostArchive.ParsedPath);

            using var writer = Archives.Services.UriBitsWriter(hostArchive.HexPath);
            var data = src.Map(x => UriBits.Define(x.Uri, x.ParsedContent.Content));
            writer.Write(data);
        }

        void Save(ApiHostUri host, MemberExtract[] extracts)
        {
            var hostArchive = CodeArchive.HostArchive(host);
            var report = ExtractReport.Create(host, extracts);            
            Extracted(host, extracts, report.Save(hostArchive.ExtractPath));
        }

        void Save(ApiHostUri host, AsmFunction[] decoded)
        {
            var hostArchive = CodeArchive.HostArchive(host);
            using var writer = Context.Writer(hostArchive.AsmPath);
            for(var i=0 ;i<decoded.Length; i++)          
                writer.WriteAsm(decoded[i]);
        }

        AsmFunction[] Decode(Option<IApiHost> mayhaps, ParsedMember[] parsed, bool save)
        {
            if(mayhaps)
            {
                var host = mayhaps.Value;
                var decoded = new AsmFunction[parsed.Length];
                for(var i=0; i<parsed.Length; i++)
                    decoded[i] = require(Context.Decoder.Decode(parsed[i]));

                if(save)
                    Save(host.UriPath, decoded);

                return decoded;
            }
            else
                return Arrays.empty<AsmFunction>();
        }

        MemberExtract[] Extract(Option<IApiHost> mayhaps, bool save)
        {            
            if(mayhaps)
            {
                var host = mayhaps.Value;
                var extract = Extractor.Extract(host);
                if(save)
                    Save(host.UriPath,extract);
                return extract;
            }
            else
                return Arrays.empty<MemberExtract>();
        }

        MemberExtract[] Extracted(ApiHostUri host, MemberExtract[] extracts, Option<FilePath> dst)
        {
            if(!dst)
                this.ExtractionFailure(host);
            return extracts;
        }    

        [MethodImpl(Inline)]
        Option<IApiHost> FindHost(ApiHostUri uri)
            => Context.Hosts.TryFind(h => h.UriPath == uri);

        public void Deposit(IAppMsg src)
            => Context.Deposit(src);
    }
}