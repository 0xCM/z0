//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm.Check
{
    using System;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;
    using System.Linq;

    using static Seed;

    public interface IExtractAnalyzerBroker : IWorkflowRelay
    {
        HostMembersLocated MembersLocated => HostMembersLocated.Empty;

        HostMembersExtracted MembersExtracted => HostMembersExtracted.Empty;

        ExtractReportCreated ExtractReportCreated => ExtractReportCreated.Empty;

        ExtractReportSaved ExtractReportSaved => ExtractReportSaved.Empty;

        AnalyzingExtractReport AnalyzingExtractReport => AnalyzingExtractReport.Empty;
    }

    sealed class ExtractAnalyzerBroker : AppEventRelay, IExtractAnalyzerBroker
    {
        [MethodImpl(Inline)]
        public new static IExtractAnalyzerBroker Create()
            => new ExtractAnalyzerBroker();
    }

    public interface IExtractAnalyzer : IAsmWorkflow
    {
        
    }

    class ExtractAnalyzer : TestContext<ExtractAnalyzer,IAsmContext>, IExtractAnalyzer
    {
        public static IExtractAnalyzer Create(IAsmContext context)    
            => new ExtractAnalyzer(context);

        ExtractAnalyzer(IAsmContext context)
            : base(context)
        {
            ApiSet = context.ApiSet;
            Sink = context;
            Extractor = Context.HostExtractor();
            MemberLocator = Context.MemberLocator();            
            Decoder = context.AsmFunctionDecoder();
            var format = Context.AsmFormat.WithSectionDelimiter();
            Formatter = Context.AsmFormatter(format);
            
            Paths = RootEmissionPaths.Define(RootEmissionPath);
            Paths.Clear();
            var broker = ExtractAnalyzerBroker.Create();
            Broker = broker;
            ConnectReceivers(broker);
        }

        readonly IAppEventRelay Broker;

        readonly IHostOpExtractor Extractor;

        readonly IMemberLocator MemberLocator;

        readonly IApiSet ApiSet;

        readonly IAppMsgSink Sink;

        readonly RootEmissionPaths Paths;

        readonly IAsmFunctionDecoder Decoder;

        readonly IAsmFormatter Formatter;

        void ConnectReceivers(IExtractAnalyzerBroker broker)
        {
            broker.Error.Subscribe(broker, OnError);
            broker.MembersLocated.Subscribe(broker, OnEvent);
            broker.MembersExtracted.Subscribe(broker, OnEvent);
            broker.ExtractReportCreated.Subscribe(broker, OnEvent);
            broker.ExtractReportSaved.Subscribe(broker, OnEvent);
            broker.AnalyzingExtractReport.Subscribe(broker, OnEvent);
        }

        [MethodImpl(Inline)]
        ref readonly E Raise<E>(in E e)
            where E : IAppEvent
                => ref Broker.Raise(e);

        void OnError(WorkflowError e)
        {
            Report(AppMsg.Error(e.Payload));    
        }

        void OnEvent(HostMembersLocated e)
        {
            Report(AppMsg.Colorize(e.Format(), AppMsgColor.Blue));
        }

        void OnEvent(HostMembersExtracted e)
        {
            Report(AppMsg.Colorize(e.Format(), AppMsgColor.Blue));
        }

        void OnEvent(ExtractReportCreated e)
        {
            Report(AppMsg.Colorize(e.Format(), AppMsgColor.Blue));
        }

        void OnEvent(ExtractReportSaved e)
        {            
            Report(AppMsg.Colorize(e.Format(), AppMsgColor.Cyan));
        }

        void OnEvent(AnalyzingExtractReport e)
        {            
            Report(AppMsg.Colorize(e.Format(), AppMsgColor.Magenta));
        }

        public void Report(AppMsg msg)
            => Sink.NotifyConsole(msg);
        
        public void Error(object content)
            => Sink.NotifyConsole(AppMsg.NoCaller(content, AppMsgKind.Error));

        public void Report(object content, AppMsgColor color = AppMsgColor.Green)
            => Sink.NotifyConsole(content, color);

        FolderPath RootEmissionPath
            => Context.Paths.TestDataDir(GetType());                

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

        void AnalyzeExtracts(MemberExtract[] src)
        {
            Raise(AnalyzingExtracts.Define(src));

        }

        OpIndex<ApiMember> MemberIndex(IApiHost host)
            => MemberLocator.Hosted(host).ToOpIndex();

        Option<IApiHost> Host(ApiHostUri uri)
            => ApiSet.FindHost(uri).TryMap(x => x as IApiHost);        

        MemberExtractReport CreateReport(IApiHost host, MemberExtract[] src)
        {
            var report = MemberExtractReport.Create(host.UriPath, src); 
            Raise(report.CreatedEvent());
            return report;
        }

        Option<FilePath> SaveReport(MemberExtractReport src, FilePath dst)
            => src.Save(dst).OnSome(f => Raise(ExtractReportSaved.Define(src.ApiHost, src.GetType(), src.RecordCount, f)));

        ApiMember[] LocateMembers(IApiHost host)
        {
            var located = MemberLocator.Located(host).ToArray();
            Raise(HostMembersLocated.Define(host.UriPath, located));
            return located;
        }

        MemberExtract[] ExtractMembers(IApiHost host)
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
                    var paths = Paths.HostPaths(host.UriPath);                
                    SaveReport(report, paths.ExtractPath).OnSome(AnalyzeExtracts);
                }
            }
        }               
    }
}