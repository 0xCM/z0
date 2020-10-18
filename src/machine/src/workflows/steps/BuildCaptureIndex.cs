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
            using var step = new BuildCaptureIndexStep(wf, host, state);
            step.Run();
            dst = step.Target;
            return ref dst;
        }
    }

    ref struct BuildCaptureIndexStep
    {
        readonly IWfShell Wf;

        public ApiCodeBlockIndex Target;

        readonly IWfCaptureState State;

        readonly WfHost Host;

        public BuildCaptureIndexStep(IWfShell wf, WfHost host, IWfCaptureState state)
        {
            Host = host;
            Wf = wf.WithHost(Host);
            State = state;
            Target = default;
            Wf.Created();
        }

        public void Dispose()
        {
            Wf.Disposed();
        }

        void BuildIndex()
        {
            using var builder = new ApiIndexBuilder(Wf, Host);
            builder.Run();
            Target = builder.Product;
            Wf.Raise(new PartIndexCreated(Host, Target, Wf.Ct));
        }

        public void Run()
        {
            Wf.Running();

            try
            {
                BuildIndex();
                Process(Target);
                Process(DecodeParts(Target));

            }
            catch(Exception e)
            {
                Wf.Error(e);
            }

            Wf.Ran();
        }

        Span<ApiPartRoutines> DecodeParts(in ApiCodeBlockIndex src)
        {
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

                    Wf.Status(text.format("Decoding {0}", part.Format()));

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
                    Wf.Status(text.format(RP.PSx4, kParts, kHosts, kMembers, kFx));
                }
            }

            Wf.Status(text.format("Decoded {0} entries from {1} parts", src.EntryCount, src.Parts.Length));
            return dst;
        }

        void Process(in ApiCodeBlockIndex encoded)
        {
            try
            {
                var processor = new ProcessAsm(State, encoded);
                var result = processor.Process();

                Wf.Processed(delimit(nameof(AsmRow), encoded.Hosts.Length, result.Count));

                var sets = result.View;
                var count = result.Count;
                for(var i=0; i<count; i++)
                    Process(skip(sets,i));
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

            Wf.EmittedTable<AsmRow>(count, dst);
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
                Wf.Error(e);
            }
        }

        void Process(in ApiPartRoutines src)
        {
            ProcessInstructions.create().Run(Wf, src);
            InstructionProcessors.ProcessCalls(Wf, src);
        }
    }
}