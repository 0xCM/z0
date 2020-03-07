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

    public static partial class HostCaptureWorkflow
    {
        [MethodImpl(Inline)]
        public static IHostCaptureWorkflow Create(IAsmContext context)
            => new Service(context);
        
        readonly struct Service : IHostCaptureWorkflow
        {
            public IAsmContext Context {get;}

            readonly IHostOpExtractor Extractor;

            readonly IOpExtractParser Parser;

            readonly IAsmFunctionDecoder Decoder;

            readonly AsmFormatConfig Format;

            readonly Dictionary<Type, AppEventReceiver> Receivers;

            readonly Dictionary<Type, IAppEventSink> Sinks;

            public Service(IAsmContext context)
            {
                this.Context = context;
                Extractor = Context.HostExtractor(Context.DefaultBufferLength);
                Parser = Context.ExtractParser(Context.DefaultBufferLength);
                Decoder = Context.AsmFunctionDecoder();
                Format = Context.AsmFormat.WithSectionDelimiter();
                Receivers = new Dictionary<Type, AppEventReceiver>();
                Sinks = new Dictionary<Type, IAppEventSink>();
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

            void Save(MemberExtractReport src, FilePath dst)
            {
                src.Save(dst);
            }

            void Save(MemberParseReport src, FilePath dst)
            {
                src.Save(dst);
            }

            ParsedExtract[] Parse(MemberExtract[] src)
            {
                var dst = Parser.Parse(src);
                
                return dst;
            }

            MemberParseReport CreateReport(ParsedExtract[] src)
            {
                var report = MemberParseReport.Create(src);                    
                RaiseEvent(report.CreatedEvent());
                return report;
            }

            AsmFunction[] Decode(in ApiHost host, ParsedExtract[] extracts)
            {
                var functions = Decoder.Decode(extracts);
                RaiseEvent(new FunctionsDecoded(host, functions));
                return functions;
            }

            void Save(in ApiHost host, AsmFunction[] src, FilePath dst)
            {
                using var writer = Context.AsmWriter(Format, dst);
                
                writer.Write(src);
            }

            void Capture(in ApiHost host, in RootEmissionPaths dst)
            {
                var paths = HostEmissionPaths.Define(host,dst);
                
                var extracts = Extract(host);                
                Save(CreateReport(host, extracts), paths.ExtractPath);

                var parsed = Parse(extracts);
                Save(CreateReport(parsed), paths.ParsedPath);
                
                var decoded = Decode(host, parsed);
                Save(host, decoded, paths.DecodedPath);
            }

            void Capture(IOpCatalog src, in RootEmissionPaths dst)
            {
                foreach(var host in src.ApiHosts)
                {
                    Capture(host, dst);
                }
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

            void RaiseEvent<E>(in E e)
                where E : IAppEvent
            {
                if(Receivers.TryGetValue(e.GetType(), out var receiver))
                    receiver?.Invoke(e);
                
                if(Sinks.TryGetValue(e.GetType(), out var sink))
                {
                    ((IAppEventSink<E>)sink).Accept(e);
                }
            }
 
            public void WithReceiver<E>(Action<E> receiver, E model = default)
                where E : IAppEvent
            {
                Receivers[typeof(E)] = e => receiver((E)e);
            }

            public void WithSink<S,E>(S sink, E model = default) 
                where E : IAppEvent
                where S : IAppEventSink<E>

            {
                Sinks[typeof(E)] = sink;
            }
        }   

    }

}