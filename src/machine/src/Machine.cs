//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;
    using System.Collections.Generic;

    using Asm;

    using static Seed;
    using static Memories;
    using static MachineEvents;

    public class Machine : IMachine
    {
        public IMachineContext Context {get;}

        public IEventBroker Broker {get;}

        public IAppMsgSink Sink {get;}

        IMachineFiles Files {get;}

        IUriCodeIndexer CodeIndexer {get;}
            = UriCodeIndexer.Service;

        ICaptureArchive Archive => Context.Archive;

        IAsmFunctionDecoder Decoder => Context.Decoder;

        Machine(IMachineContext context)
        {
            Sink = context.AppMsgSink;
            Context = context;
            Broker = new EventBroker();
            Files = new MachineFiles(context);            
            (this as IMachineEvents).Connect();            
        }

        public void Run()
        {
            ParseReports();
        }

        void ParseReports()
        {
            Control.iter(Files.ParseFiles, ParseReport);
            Broker.Raise(IndexedCode.Create(CodeIndexer.Freeze()));
        }
        void ParseReport(FilePath src)
        {
            ApiServices.ParseReportParser.Parse(src)
                    .OnFailure(fail => term.error(fail.Reason))
                    .OnSuccess(value => Broker.Raise(LoadedParseReport.Create(value, src)));
        }

        public void OnEvent(LoadedParseReport e)
        {
            Index(Sink.Deposit(e).Report);
        }
        
        public void OnEvent(IndexedCode e)
        {
            Sink.Deposit(e);

            Decode(e.Index);            
        }

        void Decode(UriCodeIndex src)
        {
            var dst = list<HostCodeInstructions>();
            foreach(var host in src.Hosts)
            {
                var code = src[host];
                var decoded = Decode(host,code);
                dst.Add(decoded);
                Broker.Raise(DecodedHost.Create(decoded));
            }

            var result = dst.ToArray();
            Broker.Raise(DecodedIndex.Create(src, result));

        }

        public void OnEvent(DecodedIndex e)
        {
            Sink.Deposit(e);
        }

        public void OnEvent(DecodedHost e)
        {
            Sink.Deposit(e);
            if(e.Part == PartId.Cast)
            {
                var formatter = SemanticFormatter.Create(Context);
                formatter.Format(e.Instructions);
            }
        }

        HostCodeInstructions Decode(ApiHostUri host, UriCode[] src)
        {
            var inxs = list<UriCodeInstructions>();            
            Control.iter(src, code => inxs.Add(Decode(code)));
            return HostCodeInstructions.Create(host, inxs.ToArray());
        }

        UriCodeInstructions Decode(UriCode src)
        {
            var seq = 0;
            var dst =  list<UriCodeInstruction>();
            void OnDecoded(Instruction inxs)
                => dst.Add((src, (seq++, inxs)));
            
            Decoder.Decode(src.Encoded, OnDecoded);
            return UriCodeInstructions.Create(src, dst.ToArray());
        }

        void Index(MemberParseReport report)
        {
            Control.iter(report.Records, Index);            
        }

        void Index(MemberParseRecord record)
        {
            CodeIndexer.Include(UriCode.Define(record.Uri, record.Data));
        }

        void Describe()
        {            
            Control.iter(Files.ParseFiles, term.print);
            Control.iter(Files.AsmFiles,term.print);
            Control.iter(Files.CodeFiles,term.print);
            Control.iter(Archive.ImmDirs(Context.Parts), term.print);
            Control.iter(Archive.ImmHostDirs(Context.Parts), term.print);
        }
        
        public void Dispose()
        {

        }

        public static void Run(IMachineContext context)
        {
            try
            {            
                using var machine = new Machine(context); 
                machine.Run();   
            }
            catch(Exception e)
            {
                term.error(e);
            }
        }
    }
}