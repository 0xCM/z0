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
    using static Shell;
    using static Engines;
    using static z;

    public class Engine  : IDisposable
    {
        public static void run(IAppContext context, params string[] args)
        {
            try
            {
                var ct = correlate(ShellId);
                var config = WfBuilder.configure(context, args);
                using var log = AB.log(config);
                using var wf = WfBuilder.context(context, config, log, ct);

                var state = new WfCaptureState(wf, AsmWfBuilder.asm(context), wf.Config, wf.Ct);

                wf.Running(StepId, delimit(config.Parts));

                using var machine = new Engine(state,ct);
                machine.Run();

                wf.Ran(StepId, ct);
            }
            catch(Exception e)
            {
                term.error(e);
            }
        }

        readonly WfCaptureState State;

        readonly CorrelationToken Ct;

        readonly List<Instruction> Buffer;

        internal Engine(WfCaptureState wf, CorrelationToken ct)
        {
            State = wf;
            Ct = ct;
            Buffer = list<Instruction>(2000);
        }

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
                Run(default(ManageCaptureStep));
                Run(default(EmitDatasetsStep));
                Run(default(ProcessPartFilesStep));

                var files = new PartFiles(Asm);
                using var step = new CreateGlobalIndex(Wf, files, Ct);
                step.Run();
                var index = step.EncodedIndex;

                Process(index);
                Process(DecodeParts(index));
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

        Span<PartAsmFx> DecodeParts(GlobalCodeIndex src)
        {
            Wf.Status(StepId, text.format("Decoding {0} entries from {1} parts", src.EntryCount, src.Parts.Length));

            var parts = src.Parts;
            var dst = z.alloc<PartAsmFx>(parts.Length);
            var hostFx = z.list<HostAsmFx>();
            var kMembers = 0u;
            var kHosts = 0u;
            var kParts = 0u;
            var kFx = 0u;
            for(var i=0; i<parts.Length; i++)
            {
                hostFx.Clear();

                var part = parts[i];
                var hosts = src.Hosts.Where(h => h.Owner == part);

                Wf.Status(StepId, text.format("Decoding {0}", part.Format()));

                for(var j=0; j<hosts.Length; j++)
                {
                    var host = hosts[j];
                    var members = src[host];
                    var fx = Decode(members);
                    hostFx.Add(fx);

                    kHosts++;
                    kMembers += (uint)fx.MemberCount;
                    kFx += (uint)fx.TotalCount;
                }
                dst[i] = new PartAsmFx(part, hostFx.ToArray());

                kParts++;

                Wf.Status(StepId, text.format(RenderPatterns.PSx4, kParts, kHosts, kMembers, kFx));

            }

            Wf.Status(StepId, text.format("Completed decoding process for {1} parts", src.EntryCount, src.Parts.Length));
            return dst;
        }

        void Process(ReadOnlySpan<PartAsmFx> src)
        {
            try
            {
                foreach(var part in src)
                {
                    Process(part);

                    using var step = new EmitCallIndex(Wf, part, Ct);
                    step.Run();
                }
            }
            catch(Exception error)
            {
                Wf.Error(error, Ct);
            }
        }

        void Process(PartAsmFx fx)
        {
            try
            {
                var step = new ProcessInstructions(Wf,fx);
                step.Run();
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

        HostAsmFx Decode(EncodedMemberIndex hcs)
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

        void Process(GlobalCodeIndex encoded)
        {
            try
            {
                Wf.Running(StepName,Ct);

                var name = "ProcessEncodedIndex";
                Wf.Raise(new RunningProcessor(StepName, name, Ct));

                var processor = new ProcessAsm(State, encoded);
                var parts = Wf.ContextRoot.Api.Composition.Resolved.Select(p => p.Id);
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
            var dst = dir + FileName.define(src.Key.ToString(), FileExtensions.Csv);
            using var writer = dst.Writer();
            writer.WriteLine(AsmRecord.FormatHeader());
            for(var i=0; i<count; i++)
            {
                ref readonly var record = ref skip(records,i);
                writer.WriteLine(record.Format());
            }
        }

        void Run(ManageCaptureStep kind, params string[] args)
        {
            using var control = WfCaptureControl.create(State);
            control.Run();
        }

        void Run(EmitDatasetsStep kind)
        {
            Wf.Running(StepId, kind);
            try
            {
                using var emission = new EmitDatasets(Wf, Ct);
                emission.Run();
            }
            catch(Exception e)
            {
                Wf.Error(e, Ct);
            }

            Wf.Ran(StepId, kind);
        }

        void Run(ProcessPartFilesStep kind)
        {
            Wf.Running(StepId, kind);

            try
            {
                using var step = new ProcessPartFiles(Wf, Asm, Ct);
                step.Run();
            }
            catch(Exception e)
            {
                Wf.Error(e, Ct);
            }

            Wf.Ran(StepId, kind);
        }
    }
}