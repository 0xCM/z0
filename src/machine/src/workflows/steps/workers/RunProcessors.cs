//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;
    using System.Collections.Generic;

    using Z0.Asm;

    using static Konst;
    using static RunProcessorsStep;
    using static z;    
    
    public class RunProcessors : IMachine
    {
        public static RunProcessors create(WfCaptureState wf, CorrelationToken ct)
        {
            wf.Initializing(StepName, ct);
            var step = default(RunProcessors);
            try
            {
                step = new RunProcessors(wf, ct);
                var client = step as IMachine;
                client.Connect();
            }
            catch(Exception e)
            {
                wf.Error(StepName, e, ct);
                throw;
            }
            
            wf.Initialized(StepName, ct);
            return step;        
        }

        readonly WfCaptureState State;

        readonly CorrelationToken Ct;

        PartFiles Files {get;}

        readonly FolderPath TargetDir;

        public EncodedParts Index;
        
        RunProcessors(WfCaptureState wf, CorrelationToken ct)
        {
            State = wf;
            Ct = ct;
            TargetDir = Wf.AppDataRoot + FolderName.Define(StepName);
            Files = PartFiles.create(Asm);            
            Buffer = list<Instruction>(2000);
        }

        readonly List<Instruction> Buffer;        

        IWfContext Wf
            => State.Wf;
        
        IAsmContext Asm
            => State.Asm;

        public IWfBroker Broker 
            => State.Wf.Broker;

        public IWfEventSink Sink 
            => Wf.Broker.Sink;

        public void Run()
        {
            Wf.Running(StepName, Ct);
            try
            {            
                using var step = new IndexEncodedParts(Wf, Files, Ct);
                step.Run();
                Index = step.EncodedIndex;
                Process(Index);
            }
            catch(Exception e)
            {
                term.error(e);
            }
            Wf.Ran(StepName, Ct);
        }

        public void Dispose()
        {
            Wf.Finished(StepName, Ct);
        }

        
        public void OnEvent(IndexedEncoded e)
        {
            Sink.Deposit(e);

            DecodeParts(e.Index);
        }

        public void OnEvent(DecodedMachine e)
        {
            Sink.Deposit(e);

            try
            {
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
            Sink.Deposit(e);
            try
            {
                Wf.Status(StepName, "Processing instructions", Ct);
                var workflow = ProcessInstructions.create(Wf, TargetDir);
                workflow.Process(e.Instructions);
                workflow.Render(e.Instructions);
            }
            catch(Exception error)
            {
                Wf.Error(error,Ct);
            }
        }

        void DecodeParts(EncodedParts src)
        {            
            var dst = z.dict<ApiHostUri,HostInstructions>();

            var parts = src.Parts;
            var count = parts.Length;
            
            for(var i=0; i<count; i++)
            {
                var part = parts[i];
                var hosts = src.Hosts.Where(h => h.Owner == part);
                for(var j=0; j<hosts.Length; j++)
                {
                    var host = hosts[j];
                    var members = src[host];
                    var instructions = Decode(members);
                    dst[host] = instructions;
                }                
            }


            //Wf.Raise(new DecodedMachine(src, dst.Array(), Ct));

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
                Wf.Raise(new DecodedHost(StepName, decoded, Ct));
            }  

            var inxs = new PartInstructions(pcs.Part, dst.Array());
            Wf.Raise(new DecodedPart(StepName, inxs, Ct));
            return inxs;                        
        }

        void OnDecoded(Instruction src)
        {
            Buffer.Add(src);
        }
        
        HostInstructions Decode(EncodedMembers hcs)
        {        
            var instructions = Root.list<MemberInstructions>();                            
            var ip = MemoryAddress.Empty;
            var decoder = Asm.FunctionDecoder;        

            for(var i=0; i<hcs.Length; i++)
            {
                Buffer.Clear();
                ref readonly var uriCode = ref hcs[i];
                decoder.Decode(uriCode, OnDecoded);
                
                if(i == 0)
                    ip = Buffer[0].IP;

                var member = MemberInstructions.Create(ip, uriCode, Buffer.ToArray());
                instructions.Add(member);
            }

            return new HostInstructions(hcs.Host, instructions.ToArray());
        }

        void Process(EncodedParts encoded)
        {
            try
            {
                Wf.Running(StepName,Ct);

                var name = "ProcessEncodedIndex";
                Wf.Raise(new RunningProcessor(StepName, name, Ct));
                
                var processor = new ProcessAsm(State, encoded);
                var parts = Wf.ContextRoot.Composition.Resolved.Select(p => p.Id);
                Wf.Raise(new ProcessingParts(StepName, name, parts, Ct));
                var result = processor.Process();

                Wf.Raise(new RanProcessor(StepName, name, $"Process result contains {result.Count} recordsets", Ct));


                var sets = result.View;
                var count = result.Count;
                for(var i=0; i<count; i++)
                {
                    ref readonly var set = ref skip(sets,i);
                    Process(set);                        
                }

                Wf.Ran(StepName,Ct);

            }
            catch(Exception e)
            {
                Wf.Error(StepName, e, Ct);
            }
        }

        void Process(in AsmRecordSet<Mnemonic> src)
        {
            var count = src.Count;
            var records = span(src.Sequenced);
            var dir = Wf.AppPaths.ResourceRoot + FolderName.Define("tables") + FolderName.Define("asm");
            var dst = dir + FileName.Define(src.Key.ToString(), FileExtensions.Csv);
            using var writer = dst.Writer();
            writer.WriteLine(AsmRecord.FormatHeader());
            for(var i=0; i<count; i++)
            {
                ref readonly var record = ref skip(records,i);
                writer.WriteLine(record.Format());
            }            
        }

        IMultiSink IWfBrokerClient.Sink 
            => Wf.Broker;

        IWfBroker IWfBrokerClient.Broker 
            => Wf.Broker;
    }
}