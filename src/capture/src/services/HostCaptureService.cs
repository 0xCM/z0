//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static Memories;

    readonly struct HostCaptureService : IHostCaptureService
    {
        public IAsmContext Context {get;}

        readonly FolderName Area;

        readonly FolderName Subject;

        readonly FolderPath Root;

        readonly IMemberExtractor Extractor;

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
            Root = (context.RootCaptureArchive.ArchiveRoot + area) + subject;
            Extractor = Capture.Services.HostExtractor();
            Parser = Z0.Extract.Services.ExtractParser(new byte[Context.DefaultBufferLength]);
        }

        [MethodImpl(Inline)]
        internal HostCaptureService(IAsmContext context, FolderPath root)
        {
            Context = context;
            Area = FolderName.Empty;
            Subject = FolderName.Empty;
            Root = root;
            Extractor = Capture.Services.HostExtractor();
            Parser = Z0.Extract.Services.ExtractParser(new byte[Context.DefaultBufferLength]);
        }

        public ExtractedMember[] Extract(ApiHostUri host, bool save)
            => Extract(FindHost(host),save);

        public ParsedMember[] Parse(ApiHostUri host, ExtractedMember[] src, bool save)
        {
            var outcome = Parser.Parse(src);
            if(outcome.Parsed.Length != 0 && save)
                Save(host,outcome.Parsed);
            return outcome.Parsed;
        }

        [MethodImpl(Inline)]
        public AsmFunction[] Decode(ApiHostUri host, ParsedMember[] parsed, bool save)
            => Decode(FindHost(host), parsed, save);

        public CapturedHost CaptureHost(ApiHostUri host, bool save)
        {
            var extracts = Extract(host, save);
            var parsed = Parse(host,extracts, save);
            var decoded = Decode(host,parsed,save);
            return CapturedHost.Define(host, extracts,parsed,decoded);
        }

        void Save(ApiHostUri host, ParsedMember[] src)
        {         
            try
            {
                var hostArchive = CodeArchive.HostArchive(host);
                var report = MemberParseReport.Create(host,src);
                report.Save(hostArchive.ParsedPath);

                using var writer = Archives.Services.UriHexWriter(hostArchive.HexPath);
                var data = src.Map(x => UriHex.Define(x.OpUri, x.Encoded.Encoded));
                writer.Write(data);
            }
            catch(Exception e)
            {
                term.errlabel(e, $"Failure saving parse report for {host}");
                throw;
            }
        }

        void Save(ApiHostUri host, ExtractedMember[] extracts)
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
                    decoded[i] = insist(Context.Decoder.Decode(parsed[i]));

                if(save)
                    Save(host.Uri, decoded);

                return decoded;
            }
            else
                return Arrays.empty<AsmFunction>();
        }

        ExtractedMember[] Extract(Option<IApiHost> mayhaps, bool save)
        {            
            if(mayhaps)
            {
                var host = mayhaps.Value;
                var extract = Extractor.Extract(host);
                if(save)
                    Save(host.Uri,extract);
                return extract;
            }
            else
                return Arrays.empty<ExtractedMember>();
        }

        ExtractedMember[] Extracted(ApiHostUri host, ExtractedMember[] extracts, Option<FilePath> dst)
        {
            if(!dst)
                this.ExtractionFailure(host);
            return extracts;
        }    

        [MethodImpl(Inline)]
        Option<IApiHost> FindHost(ApiHostUri uri)
            => Context.Hosts.TryFind(h => h.Uri == uri);

        public void Deposit(IAppMsg src)
            => Context.Deposit(src);
    }
}