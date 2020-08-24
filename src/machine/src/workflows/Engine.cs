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

    public class Engine : IMachine
    {
        public static Engine create(WfCaptureState wf, CorrelationToken ct)
        {
            wf.Initializing(StepName, ct);
            var step = default(Engine);
            try
            {
                step = new Engine(wf, ct);
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

        Engine(WfCaptureState wf, CorrelationToken ct)
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
                Process(DecodeParts(Index));
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

        Span<PartAsmFx> DecodeParts(EncodedParts src)
        {
            var parts = src.Parts;
            var dst = z.alloc<PartAsmFx>(parts.Length);
            var hostFx = z.list<HostAsmFx>();
            for(var i=0; i<parts.Length; i++)
            {
                hostFx.Clear();
                var part = parts[i];
                var hosts = src.Hosts.Where(h => h.Owner == part);

                for(var j=0; j<hosts.Length; j++)
                {
                    var host = hosts[j];
                    var members = src[host];
                    hostFx.Add(Decode(members));
                }
                dst[i] = new PartAsmFx(part, hostFx.ToArray());
            }
            return dst;
        }

        public void Process(ReadOnlySpan<PartAsmFx> src)
        {
            try
            {
                foreach(var part in src)
                {
                    var index = LocatedAsmFxList.create(part.Located.ToArray());
                    var path = TargetDir + FileName.Define($"{part.Part.Format()}.calls", FileExtensions.Csv);
                    Process(part);
                    using var step = new AnalyzeCalls(Wf, index, path, Ct);
                    step.Run();
                }
            }
            catch(Exception error)
            {
                Wf.Error(error, Ct);
            }
        }

        public void Process(PartAsmFx fx)
        {
            try
            {
                Wf.Status(StepName, "Processing instructions", Ct);
                var workflow = ProcessInstructions.create(Wf, TargetDir);
                workflow.Process(fx);
                workflow.Render(fx);
            }
            catch(Exception error)
            {
                Wf.Error(error,Ct);
            }
        }

        void OnDecoded(Instruction src)
        {
            Buffer.Add(src);
        }

        HostAsmFx Decode(EncodedMembers hcs)
        {
            var instructions = Root.list<MemberAsmFx>();
            var ip = MemoryAddress.Empty;
            var decoder = Asm.RoutineDecoder;

            for(var i=0; i<hcs.Length; i++)
            {
                Buffer.Clear();
                ref readonly var uriCode = ref hcs[i];
                decoder.Decode(uriCode, OnDecoded);

                if(i == 0)
                    ip = Buffer[0].IP;

                var member = MemberAsmFx.Create(ip, uriCode, Buffer.ToArray());
                instructions.Add(member);
            }

            return new HostAsmFx(hcs.Host, instructions.ToArray());
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