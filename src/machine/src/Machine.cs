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

        IMachineIndexBuilder IndexBuilder {get;}            

        ICaptureArchive Archive 
            => Context.Archive;

        Machine(IMachineContext context)
        {
            Sink = context.AppMsgSink;
            Context = context;
            Broker = new EventBroker();
            Files = new MachineFiles(context);            
            IndexBuilder = MachineIndex.Builder;
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

        public void OnEvent(DecodedMachine e)
        {
            Sink.Deposit(e);
        }

        public void OnEvent(DecodedPart e)
        {
            Sink.Deposit(e);

            var formatter = MachineWorkflow.Create(Context);
            formatter.Run(e.Instructions);
        }

        public void Run()
        {
            ParseReports();
        }

        void ParseReports()
        {
            Control.iter(Files.ParseFiles, ParseReport);
            Broker.Raise(IndexedCode.Create(IndexBuilder.Freeze()));
        }
        
        void ParseReport(FilePath src)
        {
            ApiServices.ParseReportParser.Parse(src)
                    .OnFailure(fail => term.error(fail.Reason))
                    .OnSuccess(value => Broker.Raise(LoadedParseReport.Create(value, src)));
        }

        void DecodeParts(MachineIndex src)
        {
            var dst = list<PartInstructions>();
            var parts = src.Parts;
            
            for(var k=0; k<parts.Length; k++)
            {
                var part = parts[k];
                var pcs = src.CodeSet(part);
                dst.Add(DecodePart(pcs));
            }

            Broker.Raise(DecodedMachine.Create(src, dst.ToArray()));
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
            var inxs = list<MemberInstructions>();    
            
            var dst = list<Instruction>();
            void OnDecoded(Instruction inxs)
                => dst.Add(inxs);
            
            var hostaddr = MemoryAddress.Empty;
            var decoder = Context.Decoder;        

            for(var i=0; i<hcs.MemberCount; i++)
            {
                dst.Clear();
                var uriCode = hcs[i];
                decoder.Decode(uriCode, OnDecoded);
                
                if(i == 0)
                    hostaddr = dst[0].IP;

                var member = MemberInstructions.Create(hostaddr, uriCode, dst.ToArray());
                inxs.Add(member);
            }

            return HostInstructions.Create(hcs.Id, inxs.ToArray());
        }

        void Index(MemberParseReport report)
        {
            Control.iter(report.Records, Index);            
        }

        void Index(MemberParseRecord record)
        {
            IndexBuilder.Include(UriCode.Define(record.Uri, record.Data));
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