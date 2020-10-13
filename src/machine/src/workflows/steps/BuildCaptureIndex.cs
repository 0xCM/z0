//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Collections.Generic;

    using Z0.Asm;

    using static Konst;
    using static z;

    [WfHost]
    public class CreateGlobalIndexHost : WfHost<CreateGlobalIndexHost>
    {
        public override void Run(IWfShell shell)
            => throw missing();
    }

    [WfHost]
    public sealed class BuildCaptureIndex : WfHost<BuildCaptureIndex>
    {
        public static ref ApiCodeBlockIndex run(IWfShell wf, IWfCaptureState state, out ApiCodeBlockIndex dst)
        {
            var host = new BuildCaptureIndex();
            var files = Archives.partfiles(wf.CaptureRoot);
            using var step = new BuildCaptureIndexStep(wf, host, state, files);
            step.Run();
            dst = step.Target;
            return ref dst;
        }
    }

    ref struct BuildCaptureIndexStep
    {
        readonly IWfShell Wf;

        readonly PartFiles SourceFiles;

        public ApiCodeBlockIndex Target;

        readonly List<Instruction> Buffer;

        readonly IWfCaptureState State;

        readonly WfHost Host;

        public BuildCaptureIndexStep(IWfShell wf, WfHost host, IWfCaptureState state, PartFiles src)
        {
            Wf = wf;
            Host = host;
            State = state;
            SourceFiles = src;
            Target = default;
            Buffer = list<Instruction>(2000);
            Wf.Created(Host);
        }

        public void Dispose()
        {
            Wf.Disposed(Host.Id);
        }

        void BuildIndex()
        {
            Target = CodeBlockIndexer.index(Wf, Host, SourceFiles);
            Wf.Raise(new PartIndexCreated(Host, Target, Wf.Ct));
        }


        public void Run()
        {
            Wf.Running(Host);

            try
            {
                BuildIndex();
                Process(Target);
                Process(DecodeParts(Target));

            }
            catch(Exception e)
            {
                Wf.Error(Host,e);
            }

            Wf.Ran(Host);
        }

        Span<ApiPartRoutines> DecodeParts(in ApiCodeBlockIndex src)
        {
            Wf.Status(Host, text.format("Decoding {0} entries from {1} parts", src.EntryCount, src.Parts.Length));

            var parts = src.Parts;
            var partCount = parts.Length;
            var dst = alloc<ApiPartRoutines>(partCount);
            var hostFx = list<ApiHostRoutines>();
            var kMembers = 0u;
            var kHosts = 0u;
            var kParts = 0u;
            var kFx = 0u;

            for(var i=0; i<partCount; i++)
            {
                hostFx.Clear();
                var part = parts[i];
                if(part == 0)
                    dst[i] = new ApiPartRoutines(part, sys.empty<ApiHostRoutines>());
                else
                {
                    var hosts = src.Hosts.Where(h => h.Owner == part);
                    var hostCount = hosts.Length;

                    Wf.Status(Host, text.format("Decoding {0}", part.Format()));

                    for(var j=0; j<hostCount; j++)
                    {
                        var host = hosts[j];
                        var members = src[host];
                        var fx = CaptureIndexBuilder.DecodeBlocks(State.RoutineDecoder, members);
                        hostFx.Add(fx);
                        kHosts++;
                        kMembers += fx.RoutineCount;
                        kFx += fx.InstructionCount;
                    }

                    dst[i] = new ApiPartRoutines(part, hostFx.ToArray());

                    kParts++;
                    Wf.Status(Host, text.format(RP.PSx4, kParts, kHosts, kMembers, kFx));
                }
            }

            Wf.Status(Host, text.format("Decoded {0} entries from {1} parts", src.EntryCount, src.Parts.Length));
            return dst;
        }

        void Process(in ApiCodeBlockIndex encoded)
        {
            try
            {
                var id = new CreateGlobalIndexHost().Id;
                Wf.Running(id);

                var processor = new ProcessAsm(State, encoded);
                var parts = Wf.Api.PartIdentities;
                var result = processor.Process();
                Wf.Raise(new ProcessedParts(id, parts, result, Wf.Ct));

                var sets = result.View;
                var count = result.Count;
                for(var i=0; i<count; i++)
                {
                    ref readonly var set = ref skip(sets,i);
                    Process(set);
                }

            }
            catch(Exception e)
            {
                Wf.Error(e);
            }
        }

        void Process(in AsmRowSet<Mnemonic> src)
        {
            var count = src.Count;
            var records = span(src.Sequenced);
            var dst = Wf.Db().Table(AsmRow.TableId, src.Key.ToString());
            var formatter = Formatters.dataset<AsmTableField>();
            using var writer = dst.Writer();
            writer.WriteLine(Table.header53<AsmTableField>());
            for(var i=0; i<count; i++)
                writer.WriteLine(AsmTables.format(skip(records,i), formatter).Render());

            Wf.Emitted(Host, dst);
        }

        void Process(in ApiPartRoutines src)
        {
            ProcessInstructions.create().Run(Wf, src);
            InstructionProcessors.ProcessCalls(Wf, src);
        }

        void Process(ReadOnlySpan<ApiPartRoutines> src)
        {
            try
            {
                var count = src.Length;
                for(var i=0; i<count; i++)
                    Process(skip(src,i));

            }
            catch(Exception e)
            {
                Wf.Error(Host,e);
            }
        }
    }
}