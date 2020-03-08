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
        internal class WorkflowService : IWorkflowService
        {
            public IAsmContext Context {get;}

            readonly IHostOpExtractor Extractor;

            readonly IOpExtractParser Parser;

            readonly IAsmFunctionDecoder Decoder;

            readonly AsmFormatConfig Format;

            readonly Dictionary<Type, IAppEventSink> Sinks;

            public WorkflowService(IAsmContext context)
            {
                this.Context = context;
                Extractor = Context.HostExtractor(Context.DefaultBufferLength);
                Parser = Context.ExtractParser(Context.DefaultBufferLength);
                Decoder = Context.AsmFunctionDecoder();
                Format = Context.AsmFormat.WithSectionDelimiter();
                Sinks = new Dictionary<Type, IAppEventSink>();
            }

            public void ExecuteWorkflow(FolderPath dst)
            {
                var root = RootEmissionPaths.Define(dst).Clear();
                var catalogs = Context.Compostion.Catalogs;

                foreach(var catalog in catalogs)   
                {
                    Capture(catalog, root);
                }
            }

            void SaveReport(MemberExtractReport src, FilePath dst)
            {
                src.Save(dst)
                   .OnSome(f => RaiseEvent(ApiHostReportSaved.Define(src.ApiHost, src.GetType(), src.RecordCount, f)));
            }

            void SaveReport(MemberParseReport src, FilePath dst)
            {
                src.Save(dst)
                   .OnSome(f => RaiseEvent(ApiHostReportSaved.Define(src.ApiHost, src.GetType(), src.RecordCount, f)));
            }

            void SaveCode(in ApiHost host, ParsedExtract[] src, FilePath dst)
            {                    
                using var writer = Context.CodeWriter(dst);
                var code = src.Map(x => x.Code);
                writer.Write(code);

                RaiseEvent(AsmCodeSaved.Define(host, code, dst));
            }

            void SaveDecoded(in ApiHost host, AsmFunction[] src, FilePath dst)
            {
                using var writer = Context.AsmWriter(Format, dst);
                
                writer.Write(src);
            }

            LocatedMember[] LocateMembers(in ApiHost host)
            {
                var locator = Context.MemberLocator();
                
                return locator.Members(host).ToArray();
            }

            MemberExtract[] Extract(in ApiHost host)
            {
                var members = LocateMembers(host);            
                var dst = Extractor.Extract(members);
                
                return dst;
            }

            MemberExtractReport CreateReport(in ApiHost host, MemberExtract[] src)
            {
                var report = MemberExtractReport.Create(host.Path, src); 
                RaiseEvent(report.CreatedEvent());
                return report;
            }

            ParsedExtract[] Parse(MemberExtract[] src)
            {
                var dst = Parser.Parse(src);
                
                return dst;
            }

            MemberParseReport CreateReport(in ApiHost host, ParsedExtract[] src)
            {
                var report = MemberParseReport.Create(host,src);                    
                RaiseEvent(report.CreatedEvent());
                return report;
            }

            AsmFunction[] Decode(in ApiHost host, ParsedExtract[] extracts)
            {
                var functions = Decoder.Decode(extracts);
                RaiseEvent(new AsmFunctionsDecoded(host, functions));
                return functions;
            }

            void Capture(in ApiHost host, in RootEmissionPaths dst)
            {
                var paths = HostEmissionPaths.Define(host,dst);                
                var extracts = Extract(host);                

                if(extracts.Length == 0)
                    return;
                
                SaveReport(CreateReport(host, extracts), paths.ExtractPath);

                var parsed = Parse(extracts);
                SaveReport(CreateReport(host,parsed), paths.ParsedPath);
                SaveCode(host, parsed, paths.CodePath);
                
                var decoded = Decode(host, parsed);
                SaveDecoded(host, decoded, paths.DecodedPath);
            }

            void Capture(IOpCatalog src, in RootEmissionPaths dst)
            {
                foreach(var host in src.ApiHosts)
                {
                    Capture(host, dst);
                }
            }


            void RaiseEvent<E>(in E e)
                where E : IAppEvent
            {                
                if(Sinks.TryGetValue(e.GetType(), out var sink))
                {
                    ((IAppEventSink<E>)sink).Accept(e);
                }
            }
 
            public void WithSink<S,E>(S sink, E model = default) 
                where E : IAppEvent
                where S : IAppEventSink<E>

            {
                Sinks[typeof(E)] = sink;
            }

            public EventSinks ConnectSinks()
                => EventSinks.Connect(this);
        }   
    }
}