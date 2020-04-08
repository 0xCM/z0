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

    using static Core;
    using static AsmWorkflowReports;

    partial class HostCaptureWorkflow
    {
        class HostCaptureRunner : IHostCaptureRunner
        {
            public IAsmContext Context {get;}

            readonly IHostOpExtractor Extractor;

            readonly IOpExtractParser Parser;

            readonly IAsmFunctionDecoder Decoder;

            readonly AsmFormatConfig Format;

            IHostCaptureEventRelay Broker {get;}

            public HostCaptureRunner(IAsmContext context, IHostCaptureEventRelay broker)
            {
                this.Context = context;
                Extractor = Context.HostExtractor();
                Parser = Context.ExtractParser();
                Decoder = Context.AsmFunctionDecoder();
                Format = Context.AsmFormat.WithSectionDelimiter();
                Broker = broker;
                step = 0;
            }

            int step;


            [MethodImpl(Inline)]
            CorrelationToken Correlate()
                => CorrelationToken.From(increment(ref step));

            [MethodImpl(Inline)]
            WorkflowError Error(Exception e)
                => e;

            [MethodImpl(Inline)]
            ref readonly E Raise<E>(in E e)
                where E : IAppEvent
                    => ref Broker.RaiseEvent(e);

            public void Run(HostCaptureConfig config)
            {
                var root = RootEmissionPaths.Define(config.EmissionRoot);
                Run(root);
            }

            public void Run(RootEmissionPaths root)
            {                
                root.Clear();
                var catalogs = Context.Compostion.Catalogs;

                foreach(var catalog in catalogs)   
                {
                    if(catalog.ApiHostCount != 0)                    
                        CaptureCatalog(catalog, root);
                }
            }

            public void CaptureCatalog(IApiCatalog src, in RootEmissionPaths dst)
            {
                if(src.HasApiHostContent)
                {
                    var step = Raise(WorkflowSteps.Started(src, Correlate()));

                    foreach(var host in src.ApiHosts)
                    {
                        CaptureHost(host, dst);
                    }
                    Raise(WorkflowSteps.Ended(src, step.Correlation));
                }
            }

            public void CaptureHost(in ApiHost host, in RootEmissionPaths dst)
            {
                var step = Raise(WorkflowSteps.Started(host, Correlate()));

                try
                {
                    var paths = dst.HostPaths(host);
                    if(host.Owner.IsNone())
                        return;

                    var extracts = ExtractMembers(host);                

                    if(extracts.Length == 0)
                        return;
                    
                    SaveReport(CreateReport(host, extracts), paths.ExtractPath);

                    var parsed = ParseMembers(host, extracts);
                    if(parsed.Length != 0)
                    {
                        SaveReport(CreateReport(host, parsed), paths.ParsedPath);
                        SaveCode(host, parsed, paths.CodePath);
                        
                        var decoded = DecodeParsed(host, parsed);
                        SaveDecoded(host, decoded, paths.DecodedPath);
                    }
                }
                catch(Exception e)
                {
                    Raise(Error(e));
                }
                finally
                {
                    Raise(WorkflowSteps.Ended(host, step.Correlation));

                }

            }

            public ApiLocatedMember[] LocateMembers(in ApiHost host)
            {
                var locator = Context.MemberLocator();  
                var located = locator.Located(host).ToArray();
                Raise(MembersLocated.Define(host, located));              
                return located;
            }

            public MemberExtract[] ExtractMembers(in ApiHost host)
            {
                var members = LocateMembers(host);            
                var dst = Extractor.Extract(members);                
                return dst;
            }

            AsmOpBits[] HandleSave(in ApiHost host, ParsedExtract[] src, FilePath dst)
            {
                using var writer = Context.HexWriter(dst);
                var data = src.Map(x => AsmOpBits.Define(x.Uri, x.ParsedContent.Bytes));
                writer.Write(data);
                return data;
            }

            public void SaveCode(in ApiHost host, ParsedExtract[] src, FilePath dst)
                => Raise(AsmHexSaved.Define(host, HandleSave(host, src, dst), dst));

            public void SaveDecoded(in ApiHost host, AsmFunction[] src, FilePath dst)
            {
                using var writer = Context.AsmWriter(Format, dst);                
                writer.Write(src);
            }

            public ParsedExtract[] ParseMembers(in ApiHost host, MemberExtract[] extracts)
            {
                var parsed = Parser.Parse(extracts);                
                Raise(new ExtractsParsed(host, parsed));
                return parsed;
            }

            public AsmFunction[] DecodeParsed(in ApiHost host, ParsedExtract[] parsed)
            {                
                var functions = Decoder.Decode(parsed);
                Raise(new FunctionsDecoded(host, functions));
                return functions;
            }

            void SaveReport(MemberExtractReport src, FilePath dst)
            {
                src.Save(dst)
                   .OnSome(f => Raise(ExtractReportSaved.Define(src.ApiHost, src.GetType(), src.RecordCount, f)));
            }

            void SaveReport(MemberParseReport src, FilePath dst)
            {
                src.Save(dst)
                   .OnSome(f => Raise(ExtractReportSaved.Define(src.ApiHost, src.GetType(), src.RecordCount, f)));
            }

            MemberParseReport CreateReport(in ApiHost host, ParsedExtract[] src)
            {
                var report = MemberParseReport.Create(host,src);                    
                Raise(report.CreatedEvent());
                return report;
            }

            MemberExtractReport CreateReport(in ApiHost host, MemberExtract[] src)
            {
                var report = MemberExtractReport.Create(host.Path, src); 
                Raise(report.CreatedEvent());
                return report;
            }

        }   
    }
}