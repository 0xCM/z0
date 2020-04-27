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

        readonly IHostCodeExtractor Extractor;

        readonly IExtractParser Parser;

        ICaptureArchive CodeArchive => Context.CaptureArchive(Area, Subject);

        [MethodImpl(Inline)]
        public static HostCaptureService Create(IAsmContext context, FolderName area, FolderName subject = null)
            => new HostCaptureService(context, area ?? FolderName.Empty, subject ?? FolderName.Empty);

        [MethodImpl(Inline)]
        HostCaptureService(IAsmContext context, FolderName area, FolderName subject)
        {
            Context = context;
            Area = area;
            Subject = subject;
            Extractor = AsmStatelessCore.Factory.HostExtractor();
            Parser = StatelessExtract.Factory.ExtractParser(new byte[Context.DefaultBufferLength]);
        }

        public MemberExtract[] Extract(ApiHostUri host, bool save)
            => Extract(FindHost(host),save);

        public ParsedMemberExtract[] Parse(ApiHostUri host, MemberExtract[] src, bool save)
        {
            var parsed = Parser.Parse(src);
            if(parsed.Length != 0 && save)
                Save(host, parsed);            
            return parsed;
        }

        [MethodImpl(Inline)]
        public AsmFunction[] Decode(ApiHostUri host, ParsedMemberExtract[] parsed, bool save)
            => Decode(FindHost(host), parsed, save);

        public ApiHostCapture CaptureHost(ApiHostUri host, bool save )
        {
            var extracts = Extract(host, save);
            var parsed = Parse(host,extracts, save);
            var decoded = Decode(host,parsed,save);
            return ApiHostCapture.Define(host, extracts,parsed,decoded);
        }

        void Save(ApiHostUri host, ParsedMemberExtract[] src)
        {
            var hostArchive = CodeArchive.CaptureArchive(host);
            var report = MemberParseReport.Create(host,src);
            report.Save(hostArchive.ParsedPath);

            using var writer = UriBitsWriter.Create(hostArchive.HexPath);
            var data = src.Map(x => UriBits.Define(x.Uri, x.ParsedContent.Content));
            writer.Write(data);
        }

        void Save(ApiHostUri host, MemberExtract[] extracts)
        {
            var hostArchive = CodeArchive.CaptureArchive(host);
            var report = ExtractReport.Create(host, extracts);            
            Extracted(host, extracts, report.Save(hostArchive.ExtractPath));
        }

        void Save(ApiHostUri host, AsmFunction[] decoded)
        {
            var hostArchive = CodeArchive.CaptureArchive(host);
            using var writer = Context.Writer(hostArchive.AsmPath);
            for(var i=0 ;i<decoded.Length; i++)          
                writer.Write(decoded[i]);
        }

        AsmFunction[] Decode(Option<IApiHost> mayhaps, ParsedMemberExtract[] parsed, bool save)
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
            if(dst)
                this.ExtractionSuccess(host,dst.Value);
            else
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