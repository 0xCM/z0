//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;

    using Z0.Asm;

    using static Konst;
    using static RunMachineStep;
    using static z;
    
    public class RunMachine : IMachine
    {
        public static void create(WfContext wf, CorrelationToken ct)
            => new RunMachine(wf, ct);

        readonly WfContext Wf;

        readonly CorrelationToken Ct;
        
        readonly IAsmContext Asm;

        public IWfBroker Broker {get;}

        public IWfEventSink Sink {get;}

        PartFiles Files {get;}

        EncodedIndexBuilder IndexBuilder {get;}            

        readonly FolderPath TargetDir;
        
        internal RunMachine(WfContext wf, CorrelationToken ct)
        {
            Wf = wf;
            Ct = ct;
            Sink = wf.Broker.Sink;
            TargetDir = Wf.AppPaths.AppDataRoot + FolderName.Define(WorkerName);
            Asm = ContextFactory.asm(wf.ContextRoot);
            Broker = new WfBroker(Ct);
            Files = PartFiles.create(Asm);            
            IndexBuilder = Encoded.indexer();
            (this as IMachineEventClient).Connect();            
        }

        public void OnEvent(LoadedParseReport e)
        {
            Index(Sink.Deposit(e).Report);
        }
        
        public void OnEvent(IndexedEncoded e)
        {
            Sink.Deposit(e);

            DecodeParts(e.Index);
        }

        public void OnEvent(DecodedMachine e)
        {
            try
            {
                Sink.Deposit(e);
                var index = LocatedInstructions.create(e.Instructions.ToArray());
                using var step = new AnalyzeCalls(Wf, index, TargetDir, Ct);
                step.Run();
            }
            catch(Exception error)
            {
                Wf.Error(error, Ct);
            }            
        }

        public void OnEvent(DecodedPart e)
        {
            try
            {
                Sink.Deposit(e);
                var workflow = ProcessInstructions.create(Wf, TargetDir);
                workflow.Process(e.Instructions);
                if(SemanticFormatEnabled)
                    workflow.Render(e.Instructions);
            }
            catch(Exception error)
            {

                Wf.Error(error,Ct);
            }


        }

        void DecodeParts(EncodedIndex src)
        {
            var dst = Root.list<PartInstructions>();
            var parts = src.Parts;
            
            for(var k=0; k<parts.Length; k++)
            {
                var part = parts[k];
                var pcs = src.CodeSet(part);
                dst.Add(DecodePart(pcs));
            }

            Broker.Raise(new DecodedMachine(src, dst.Array()));
        }

        PartInstructions DecodePart(PartCodeIndex pcs)
        {
            var dst = list<HostInstructions>();
            var hcSets = pcs.Data;
            for(var i=0; i<hcSets.Length; i++)
            {
                var hcs = hcSets[i];
                var decoded = Decode(hcs);
                dst.Add(decoded);
                Broker.Raise(new DecodedHost(decoded));
            }  

            var inxs = PartInstructions.Create(pcs.Part, dst.Array());
            Broker.Raise(new DecodedPart(inxs));
            return inxs;                        
        }

        HostInstructions Decode(MemberCodeIndex hcs)
        {
            var inxs = Root.list<MemberInstructions>();    
            
            var dst = Root.list<Instruction>();
            void OnDecoded(Instruction inxs)
                => dst.Add(inxs);
            
            var hostaddr = MemoryAddress.Empty;
            var decoder = Asm.Decoder;        

            for(var i=0; i<hcs.Length; i++)
            {
                dst.Clear();
                ref readonly var uriCode = ref hcs[i];
                decoder.Decode(uriCode, OnDecoded);
                
                if(i == 0)
                    hostaddr = dst[0].IP;

                var member = MemberInstructions.Create(hostaddr, uriCode, dst.ToArray());
                inxs.Add(member);
            }

            return HostInstructions.Create(hcs.Host, inxs.ToArray());
        }

        void Index(MemberParseReport report)
        {
            Root.iter(report.Records, Index);            
        }

        void Index(MemberParseRecord src)
        {
            if(src.Address.IsEmpty)
                Broker.Raise(new Unaddressed(src.Uri, src.Data));
            else
                IndexBuilder.Include(MemberCode.Define(src.Uri, src.Data));
        }

        void ParseReport(FilePath src)
        {
            var report = ParseReportParser.Service.Parse(src);
            report.OnFailure(fail => term.error(fail.Reason))
                  .OnSuccess(value => Broker.Raise(new LoadedParseReport(value, src)));
        }

        void ParseReports()
        {
            Root.iter(Files.ParseFiles, ParseReport);
            Broker.Raise(new IndexedEncoded(IndexBuilder.Freeze()));
        }

        public void Run()
        {
            try
            {            
                ParseReports();
            }
            catch(Exception e)
            {
                term.error(e);
            }
        }

        public void Dispose()
        {
            Wf.Finished(WorkerName, Ct);
        }

        public bool SemanticFormatEnabled {get;}
            = false;

        IMultiSink IWfBrokerClient.Sink 
            => Wf.Broker;

        IWfBroker IWfBrokerClient.Broker 
            => Wf.Broker;
    }
}