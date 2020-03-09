//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Collections.Generic;
    using System.Linq;

    using static Root;
    using static AsmWorkflowReports;


    partial class HostCaptureWorkflow
    {
        class WorkflowRunner : IWorkflowRunner
        {
            public IAsmContext Context {get;}

            readonly IHostOpExtractor Extractor;

            readonly IOpExtractParser Parser;

            readonly IAsmFunctionDecoder Decoder;

            readonly AsmFormatConfig Format;

            readonly IWorkflowEventRelay Broker;

            public WorkflowRunner(IAsmContext context)
            {
                this.Context = context;
                Extractor = Context.HostExtractor(Context.DefaultBufferLength);
                Parser = Context.ExtractParser(Context.DefaultBufferLength);
                Decoder = Context.AsmFunctionDecoder();
                Format = Context.AsmFormat.WithSectionDelimiter();
                Broker = EventBroker.Connect(this);
            }

            IWorkflowEventBroker IWorkflowRunner.EventBroker
                => Broker;

            public void CaptureCatalog(IOpCatalog src, in RootEmissionPaths dst)
            {
                foreach(var host in src.ApiHosts)
                {
                    CaptureHost(host, dst);
                }
            }

            public void Run(FolderPath dst)
            {
                var root = RootEmissionPaths.Define(dst);
                Run(root);
            }

            public void Run(RootEmissionPaths root)
            {
                root.Clear();
                var catalogs = Context.Compostion.Catalogs;

                foreach(var catalog in catalogs)   
                {
                    CaptureCatalog(catalog, root);
                }
            }

            public LocatedMember[] LocateMembers(in ApiHost host)
            {
                var locator = Context.MemberLocator();  
                var located = locator.Located(host).ToArray();
                Broker.RaiseEvent(MembersLocated.Define(host, located));              
                return located;
            }

            public MemberExtract[] ExtractMembers(in ApiHost host)
            {
                var members = LocateMembers(host);            
                var dst = Extractor.Extract(members);                
                return dst;
            }

            AsmOpData[] HandleSave(in ApiHost host, ParsedExtract[] src, FilePath dst)
            {
                using var writer = Context.HexWriter(dst);
                var data = src.Map(x => AsmOpData.Define(x.Uri, x.ParsedContent.Bytes));
                writer.Write(data);
                return data;
            }

            public void SaveCode(in ApiHost host, ParsedExtract[] src, FilePath dst)
                => Broker.RaiseEvent(AsmHexSaved.Define(host, HandleSave(host, src, dst), dst));

            public void SaveDecoded(in ApiHost host, AsmFunction[] src, FilePath dst)
            {
                using var writer = Context.AsmWriter(Format, dst);                
                writer.Write(src);
            }

            public ParsedExtract[] ParseMembers(in ApiHost host,  MemberExtract[] extracts)
            {
                var parsed = Parser.Parse(extracts);                
                Broker.RaiseEvent(new ExtractsParsed(host, parsed));
                return parsed;
            }

            public AsmFunction[] DecodeParsed(in ApiHost host, ParsedExtract[] parsed)
            {
                var functions = Decoder.Decode(parsed);
                Broker.RaiseEvent(new FunctionsDecoded(host, functions));
                return functions;
            }

            public void CaptureHost(in ApiHost host, in RootEmissionPaths dst)
            {
                var paths = dst.HostPaths(host);
                if(host.Owner.IsNone())
                    return;

                var extracts = ExtractMembers(host);                

                if(extracts.Length == 0)
                    return;
                
                SaveReport(CreateReport(host, extracts), paths.ExtractPath);

                var parsed = ParseMembers(host, extracts);
                SaveReport(CreateReport(host, parsed), paths.ParsedPath);
                SaveCode(host, parsed, paths.CodePath);
                
                var decoded = DecodeParsed(host, parsed);
                SaveDecoded(host, decoded, paths.DecodedPath);
            }

            void SaveReport(MemberExtractReport src, FilePath dst)
            {
                src.Save(dst)
                   .OnSome(f => Broker.RaiseEvent(ExtractReportSaved.Define(src.ApiHost, src.GetType(), src.RecordCount, f)));
            }

            void SaveReport(MemberParseReport src, FilePath dst)
            {
                src.Save(dst)
                   .OnSome(f => Broker.RaiseEvent(ExtractReportSaved.Define(src.ApiHost, src.GetType(), src.RecordCount, f)));
            }

            MemberParseReport CreateReport(in ApiHost host, ParsedExtract[] src)
            {
                var report = MemberParseReport.Create(host,src);                    
                Broker.RaiseEvent(report.CreatedEvent());
                return report;
            }

            MemberExtractReport CreateReport(in ApiHost host, MemberExtract[] src)
            {
                var report = MemberExtractReport.Create(host.Path, src); 
                Broker.RaiseEvent(report.CreatedEvent());
                return report;
            }
        }   
    }
}