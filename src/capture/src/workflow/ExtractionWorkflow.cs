//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;
    using System.Linq;

    using static Seed;
    using static AsmEvents;
    using static ExtractionEvents;

    class ExtractionWorkflow : IExtractionWorkflow
    {
        public static IExtractionWorkflow Create(IAsmContext context)    
            => new ExtractionWorkflow(context);

        readonly IAsmContext Context;
        ExtractionWorkflow(IAsmContext context)
        {
            Context = context;
            ApiSet = context.ApiSet;
            Sink = context;
            Extractor = context.HostExtractor();
            MemberLocator = context.MemberLocator();            
            Decoder = context.AsmFunctionDecoder();
            var format = context.AsmFormat.WithSectionDelimiter();
            Formatter = context.AsmFormatter(format);
            
            CodeArchive = CaptureArchive.Define(ArchiveRoot);
            CodeArchive.Clear();
            var relay = ExtractionBroker.Create();
            Relay = relay;
            ConnectReceivers(relay);
        }

        readonly IEventBroker Relay;

        readonly IHostCodeExtractor Extractor;

        readonly IMemberLocator MemberLocator;

        readonly IApiSet ApiSet;

        readonly IAppMsgSink Sink;

        readonly ICaptureArchive CodeArchive;

        readonly IAsmFunctionDecoder Decoder;

        readonly IAsmFormatter Formatter;

        void ConnectReceivers(IExtractionBroker broker)
        {
            broker.Error.Subscribe(broker, OnError);
            broker.MembersLocated.Subscribe(broker, OnEvent);
            broker.MembersExtracted.Subscribe(broker, OnEvent);
            broker.ExtractReportCreated.Subscribe(broker, OnEvent);
            broker.ExtractReportSaved.Subscribe(broker, OnEvent);
            broker.AnalyzingExtractReport.Subscribe(broker, OnEvent);
        }

        static string Format(IAppEvent e) => e?.Format() ?? string.Empty;

        [MethodImpl(Inline)]
        ref readonly E Raise<E>(in E e)
            where E : IAppEvent
                => ref Relay.Raise(e);

        void OnError(AppErrorEvent e)
        {
            Report(AppMsg.Error(e.Payload));    
        }

        void OnEvent(HostMembersLocated e)
        {
            Report(AppMsg.Colorize(Format(e), AppMsgColor.Blue));
        }

        void OnEvent(HostMembersExtracted e)
        {
            Report(AppMsg.Colorize(Format(e), AppMsgColor.Blue));
        }

        void OnEvent(ExtractReportCreated e)
        {
            Report(AppMsg.Colorize(Format(e), AppMsgColor.Blue));
        }

        void OnEvent(ExtractReportSaved e)
        {            
            Report(AppMsg.Colorize(Format(e), AppMsgColor.Cyan));
        }

        void OnEvent(AnalyzingExtractReport e)
        {            
            Report(AppMsg.Colorize(Format(e), AppMsgColor.Magenta));
        }

        public void Report(AppMsg msg)
            => Sink.NotifyConsole(msg);
        
        public void Error(object content)
            => Sink.NotifyConsole(AppMsg.NoCaller(content, AppMsgKind.Error));

        public void Report(object content, AppMsgColor color = AppMsgColor.Green)
            => Sink.NotifyConsole(content, color);

        FolderPath ArchiveRoot
            => Context.AppPaths.TestDataDir(GetType());                

        IEnumerable<IApiCatalog> Catalogs
            => ApiSet.Catalogs.Where(c => c.ApiHostCount !=0 && c.HasApiHostContent);

        IEnumerable<IApiHost> Hosts
            => from c in Catalogs
                from h in c.ApiHosts
                select h as IApiHost;

        void AnalyzeExtracts(FilePath src)
        {
            Raise(AnalyzingExtractReport.Define(src));
            var reader = Context.MemberExtractReader(ApiSet);

            var extracts = reader.ReadExtracts(src);
            Report($"Loaded {extracts.Length} member extracts from {src}");
        }

        void AnalyzeExtracts(ApiMemberExtract[] src)
        {
            Raise(AnalyzingExtracts.Define(src));

        }

        ApiIndex MemberIndex(IApiHost host)
            => ApiIndex.Create(MemberLocator.Hosted(host));

        Option<IApiHost> Host(ApiHostUri uri)
            => ApiSet.FindHost(uri).TryMap(x => x as IApiHost);        

        ApiExtractReport CreateReport(IApiHost host, ApiMemberExtract[] src)
        {
            var report = ApiExtractReport.Create(host.UriPath, src); 
            Raise(ExtractReportCreated.Define(report));
            return report;
        }

        Option<FilePath> SaveReport(ApiExtractReport src, FilePath dst)
            => src.Save(dst).OnSome(f => Raise(ExtractReportSaved.Define(src.ApiHost, src.GetType(), src.RecordCount, f)));

        ApiMember[] LocateMembers(IApiHost host)
        {
            var located = MemberLocator.Located(host).ToArray();
            Raise(HostMembersLocated.Define(host.UriPath, located));
            return located;
        }

        ApiMemberExtract[] ExtractMembers(IApiHost host)
        {
            var members = LocateMembers(host);            
            var extracted = Extractor.Extract(members);
            Raise(HostMembersExtracted.Define(host.UriPath, extracted));            
            return extracted;
        }

        public void Run()
        {
            foreach(var host in Hosts)
            {
                var members = ExtractMembers(host);
                if(members.Length !=0)
                {
                    var report = CreateReport(host,members);
                    var paths = CodeArchive.HostArchive(host.UriPath);                
                    SaveReport(report, paths.ExtractPath).OnSome(AnalyzeExtracts);
                }
            }
        }               
    }
}