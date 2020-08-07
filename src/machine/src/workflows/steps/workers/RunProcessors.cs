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
    
    [Step(Kind)]
    public class RunProcessors : IMachine
    {
        public static RunProcessors create(WfState wf, CorrelationToken ct)
        {
            wf.Initializing(Name, ct);
            var step = default(RunProcessors);
            try
            {
                step = new RunProcessors(wf, ct);
                var client = step as IMachine;
                client.Connect();
            }
            catch(Exception e)
            {
                wf.Error(Name, e, ct);
                throw;
            }
            
            wf.Initialized(Name, ct);
            return step;        
        }

        readonly WfState State;

        readonly CorrelationToken Ct;

        PartFiles Files {get;}


        readonly FolderPath TargetDir;
        
        RunProcessors(WfState wf, CorrelationToken ct)
        {
            State = wf;
            Ct = ct;
            TargetDir = Wf.AppPaths.AppDataRoot + FolderName.Define(Name);
            Files = PartFiles.create(Asm);            
        }

        WfContext Wf
            => State.Wf;
        
        IAsmContext Asm
            => State.Asm;

        public IWfBroker Broker 
            => State.Wf.Broker;

        public IWfEventSink Sink 
            => Wf.Broker.Sink;

        public void Run()
        {
            Wf.Running(Name, Ct);
            try
            {            
                Ingest();
            }
            catch(Exception e)
            {
                term.error(e);
            }
            Wf.Ran(Name, Ct);
        }

        public void Dispose()
        {
            Wf.Finished(Name, Ct);
        }

        
        public void OnEvent(IndexedEncoded e)
        {
            Sink.Deposit(e);

            DecodeParts(e.Index);
        }

        public void OnEvent(DecodedMachine e)
        {
            Sink.Deposit(e);

            Wf.Status(Name, $"Handling {e.EventId}", Ct);
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
            Wf.Status(Name, $"Handling {e.EventId}", Ct);
        }

        public void OnEvent(DecodedPart e)
        {
            Sink.Deposit(e);

            Wf.Status(Name, $"Handling {e.EventId}", Ct);
            try
            {
                Wf.Status(Name, "Processing instructions", Ct);
                var workflow = ProcessInstructions.create(Wf, TargetDir);
                workflow.Process(e.Instructions);
                workflow.Render(e.Instructions);
            }
            catch(Exception error)
            {
                Wf.Error(error,Ct);
            }

            Wf.Status(Name, $"Handling {e.EventId}", Ct);
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
                Wf.Raise(new DecodedHost(Name, decoded, Ct));
            }  

            var inxs = new PartInstructions(pcs.Part, dst.Array());
            Wf.Raise(new DecodedPart(Name, inxs, Ct));
            return inxs;                        
        }

        HostInstructions Decode(EncodedMembers hcs)
        {
            Wf.Running(Name, "Decode", Ct);

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

            Wf.Ran(Name, "Decode", Ct);

            return HostInstructions.Create(hcs.Host, inxs.ToArray());
        }

        void RandomProcessor()
        {
            try
            {
                var name = nameof(RandomProcessor);
                Wf.Raise(new RunningProcessor(Name, name, Ct));
                
                var processor = ProcessAsm.create(State);
                var parts = Wf.ContextRoot.Composition.Resolved.Select(p => p.Id);
                Wf.Raise(new ProcessingParts(Name, name, parts, Ct));

                var result = processor.Process(parts);
                var sets = span(result.Content);
                var count = result.Count;
                for(var i=0; i<count; i++)
                {
                    ref readonly var set = ref skip(sets,i);
                    Process(set);                        
                }

                Wf.Raise(new RanProcessor(Name, nameof(RandomProcessor), Ct));

            }
            catch(Exception e)
            {
                Wf.Error(Name, e, Ct);
            }
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

        void Index(MemberParseReport report, EncodedPartBuilder dst)
        {
            z.iter(report.Records,record => Index(record,dst));                        
        }
        
        void Index(MemberParseRecord src, EncodedPartBuilder dst)
        {
            if(src.Address.IsEmpty)
                Wf.Raise(new Unaddressed(src.Uri, src.Data));
            else
            {
                var code = MemberCode.define(src.Uri, src.Data);
                if(!dst.Include(code))
                    Wf.Warn(Name, $"Duplicate | {src.Uri.Format()}", Ct);
            }
        }

        void Ingest()
        {
            var parser = ParseReportParser.Service;
            var files = span(Files.ParseFiles);
            var count = files.Length;
            
            var builder = Encoded.builder();            
            for(var i=0; i<count; i++)
            {
                ref readonly var path = ref skip(files,i);
                var parsed = parser.Parse(path);
                if(parsed)
                {
                    Index(parsed.Value,builder);
                }
                else
                {
                    Wf.Error(Name, $"Parse failed for {path}", Ct);
                }
            }

            var encoded = builder.Freeze();
            Wf.Raise(new IndexedEncoded(Name, encoded, Ct));            
        }

        IMultiSink IWfBrokerClient.Sink 
            => Wf.Broker;

        IWfBroker IWfBrokerClient.Broker 
            => Wf.Broker;
    }
}