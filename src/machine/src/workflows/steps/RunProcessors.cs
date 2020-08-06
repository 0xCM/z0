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
    using static RunProcessorsStep;
    using static z;    
    
    [Step(WfStepId.RunProcessors)]
    public class RunProcessors : IMachine
    {
        public static RunProcessors create(WfContext wf, CorrelationToken ct)
        {
            wf.Initializing(ActorName, ct);
            var step = default(RunProcessors);
            try
            {
                step = new RunProcessors(wf, ct);
                var client = step as IMachine;
                client.Connect();
            }
            catch(Exception e)
            {
                wf.Error(ActorName, e, ct);
                throw;
            }
            
            wf.Initialized(ActorName, ct);
            return step;        
        }

        readonly WfContext Wf;

        readonly CorrelationToken Ct;
        
        readonly IAsmContext Asm;

        public IWfBroker Broker {get;}

        public IWfEventSink Sink {get;}

        PartFiles Files {get;}

        EncodedPartBuilder IndexBuilder {get;}            

        readonly FolderPath TargetDir;
        
        RunProcessors(WfContext wf, CorrelationToken ct)
        {
            Wf = wf;
            Ct = ct;
            Sink = wf.Broker.Sink;
            TargetDir = Wf.AppPaths.AppDataRoot + FolderName.Define(ActorName);
            Asm = WfBuilder.asm(wf.ContextRoot);
            Broker = new WfBroker(Ct);
            Files = PartFiles.create(Asm);            
            IndexBuilder = Encoded.builder();                  
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

        void DecodeParts(EncodedParts src)
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

        PartInstructions DecodePart(PartCode pcs)
        {
            var dst = list<HostInstructions>();
            var hcSets = pcs.Data;
            for(var i=0; i<hcSets.Length; i++)
            {
                var hcs = hcSets[i];
                var decoded = Decode(hcs);
                dst.Add(decoded);
                Wf.Raise(new DecodedHost(ActorName, decoded, Ct));
            }  

            var inxs = new PartInstructions(pcs.Part, dst.Array());
            Wf.Raise(new DecodedPart(ActorName, inxs, Ct));
            return inxs;                        
        }

        HostInstructions Decode(EncodedMembers hcs)
        {
            var inxs = Root.list<MemberInstructions>();    
            
            var dst = Root.list<Instruction>();
            void OnDecoded(Instruction inxs)
                => dst.Add(inxs);
            
            var hostaddr = MemoryAddress.Empty;
            var decoder = Asm.FunctionDecoder;        

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
                Wf.Raise(new Unaddressed(src.Uri, src.Data));
            else
                IndexBuilder.Include(MemberCode.define(src.Uri, src.Data));
        }

        void ParseReport(FilePath src)
        {
            var report = ParseReportParser.Service.Parse(src);
            report.OnFailure(fail => term.error(fail.Reason))
                  .OnSuccess(value => Wf.Raise(new LoadedParseReport(value, src)));
        }

        void RandomProcessor()
        {
            // try
            // {
            //     var name = nameof(RandomProcessor);
            //     Wf.Raise(new RunningProcessor(ActorName, name, Ct));
                
            //     var processor = ProcessAsm.create(State);
            //     var parts = Wf.ContextRoot.Composition.Resolved.Select(p => p.Id);
            //     Wf.Raise(new ProcessingParts(ActorName, name, parts, Ct));

            //     var result = processor.Process(parts);
            //     var sets = span(result.Content);
            //     var count = result.Count;
            //     for(var i=0; i<count; i++)
            //     {
            //         ref readonly var set = ref skip(sets,i);
            //         Process(set);                        
            //     }

            //     Wf.Raise(new RanProcessor(ActorName, nameof(RandomProcessor), Ct));

            // }
            // catch(Exception e)
            // {
            //     Wf.Error(ActorName, e, Ct);
            // }
        }

        void Process(in AsmRecordSet<Mnemonic> src)
        {
            var count = src.Count;
            var records = span(src.Sequenced);

            var path = ((Wf.AppPaths.AppDataRoot +  FolderName.Define("processed")) + FileName.Define(src.Key.ToString(), FileExtensions.Csv)).CreateParentIfMissing();
            using var writer = path.Writer();
            writer.WriteLine(AsmRecord.FormatHeader());
            for(var i=0; i<count; i++)
            {
                ref readonly var record = ref skip(records,i);
                writer.WriteLine(record.Format());
            }            
        }

        void ParseReports()
        {
            var files = span(Files.ParseFiles);
            var count = files.Length;
            Wf.Status(ActorName, $"Processing {count} parse files", Ct);

            for(var i=0; i<count; i++)
            {
                ref readonly var file = ref skip(files,i);
                ParseReport(file);
            }

            var encoded = IndexBuilder.Freeze();
            Wf.Raise(new IndexedEncoded(ActorName, encoded, Ct));
        }

        public void Run()
        {
            Wf.Running(ActorName, Ct);
            try
            {            
                RandomProcessor();
                ParseReports();
            }
            catch(Exception e)
            {
                term.error(e);
            }
        }

        public void Dispose()
        {
            Wf.Finished(ActorName, Ct);
        }

        public bool SemanticFormatEnabled {get;}
            = true;

        IMultiSink IWfBrokerClient.Sink 
            => Wf.Broker;

        IWfBroker IWfBrokerClient.Broker 
            => Wf.Broker;
    }
}