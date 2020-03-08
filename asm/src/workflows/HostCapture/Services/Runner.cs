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
        internal class Runner : IWorkflowRunner
        {
            public IAsmContext Context {get;}

            readonly IHostOpExtractor Extractor;

            readonly IOpExtractParser Parser;

            readonly IAsmFunctionDecoder Decoder;

            readonly AsmFormatConfig Format;

            readonly Dictionary<Type, IAppEventSink> Sinks;

            public Runner(IAsmContext context)
            {
                this.Context = context;
                Extractor = Context.HostExtractor(Context.DefaultBufferLength);
                Parser = Context.ExtractParser(Context.DefaultBufferLength);
                Decoder = Context.AsmFunctionDecoder();
                Format = Context.AsmFormat.WithSectionDelimiter();
                Sinks = new Dictionary<Type, IAppEventSink>();
            }

            public EventSinks ConnectSinks()
                => EventSinks.Connect(this);

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

            public LocatedMember[] LocateMembers(in ApiHost host)
            {
                var locator = Context.MemberLocator();                
                return locator.Located(host).ToArray();
            }

            public MemberExtract[] ExtractMembers(in ApiHost host)
            {
                var members = LocateMembers(host);            
                var dst = Extractor.Extract(members);                
                return dst;
            }

            public void SaveCode(in ApiHost host, ParsedExtract[] src, FilePath dst)
            {                    
                using var writer = Context.CodeWriter(dst);
                var code = src.Map(x => x.Code);
                writer.Write(code);

                RaiseEvent(AsmCodeSaved.Define(host, code, dst));
            }

            public void SaveDecoded(in ApiHost host, AsmFunction[] src, FilePath dst)
            {
                using var writer = Context.AsmWriter(Format, dst);                
                writer.Write(src);
            }

            public ParsedExtract[] ParseMembers(in ApiHost host,  MemberExtract[] extracts)
            {
                var parsed = Parser.Parse(extracts);                
                RaiseEvent(new ExtractsParsed(host, parsed));
                return parsed;
            }

            public AsmFunction[] DecodeParsed(in ApiHost host, ParsedExtract[] parsed)
            {
                var functions = Decoder.Decode(parsed);
                RaiseEvent(new FunctionsDecoded(host, functions));
                return functions;
            }

            public void CaptureHost(in ApiHost host, in RootEmissionPaths dst)
            {
                var paths = dst.HostPaths(host);
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
                   .OnSome(f => RaiseEvent(ApiHostReportSaved.Define(src.ApiHost, src.GetType(), src.RecordCount, f)));
            }

            void SaveReport(MemberParseReport src, FilePath dst)
            {
                src.Save(dst)
                   .OnSome(f => RaiseEvent(ApiHostReportSaved.Define(src.ApiHost, src.GetType(), src.RecordCount, f)));
            }

            MemberParseReport CreateReport(in ApiHost host, ParsedExtract[] src)
            {
                var report = MemberParseReport.Create(host,src);                    
                RaiseEvent(report.CreatedEvent());
                return report;
            }

            MemberExtractReport CreateReport(in ApiHost host, MemberExtract[] src)
            {
                var report = MemberExtractReport.Create(host.Path, src); 
                RaiseEvent(report.CreatedEvent());
                return report;
            }
        }   
    }
}