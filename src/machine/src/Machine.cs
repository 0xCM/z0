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


        public void OnEvent(LoadedParseReport e)
        {
            Index(Sink.Deposit(e).Report);
        }
        
        public void OnEvent(IndexedCode e)
        {
            Sink.Deposit(e);

            DecodeParts(e.Index);
        }

        public void OnEvent(DecodedIndex e)
        {
            Sink.Deposit(e);
        }

        public void OnEvent(DecodedPart e)
        {
            Sink.Deposit(e);

            var formatter = SemanticFormatter.Create(Context);
            formatter.Render(e.Instructions);
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

        void DecodeParts(UriCodeIndex src)
        {
            var dst = list<PartInstructions>();
            var parts = src.Parts;
            
            for(var k=0; k<parts.Length; k++)
            {
                var part = parts[k];
                var pcs = src.CodeSet(part);
                dst.Add(DecodePart(pcs));
            }

            Broker.Raise(DecodedIndex.Create(src, dst.ToArray()));
        }

        PartInstructions DecodePart(PartCode pcs)
        {
            var dst = list<HostInstructions>();
            var hcSets = pcs.Code;
            for(var i=0; i<hcSets.Length; i++)
            {
                var hcs = hcSets[i];
                var decoded = Decode(hcs);
                dst.Add(decoded);
                Broker.Raise(DecodedHost.Create(decoded));
            }  

            var inxs = PartInstructions.Create(pcs.Part, dst.ToArray());
            Broker.Raise(DecodedPart.Create(inxs));
            return inxs;                        
        }

        HostInstructions Decode(HostCode hcs)
        {
            var inxs = list<OpInstructions>();            
            Control.iter(hcs.Code, code => inxs.Add(Decode(code)));
            return HostInstructions.Create(hcs.Id, inxs.ToArray());
        }

        OpInstructions Decode(UriCode src)
        {
            var seq = 0;
            var dst =  list<OpInstruction>();
            void OnDecoded(Instruction inxs)
                => dst.Add(OpInstruction.Define(src.Address, src.OpUri, seq++, inxs));
            
            Decoder.Decode(src.Encoded, OnDecoded);
            return OpInstructions.Create(src.OpUri, dst.ToArray());
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