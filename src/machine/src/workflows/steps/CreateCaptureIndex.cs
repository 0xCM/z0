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
    public sealed class CreateCaptureIndex : WfHost<CreateCaptureIndex>
    {
        public static void run(IWfShell wf, IWfCaptureState state)
        {
            var host = new CreateCaptureIndex();
            var files = ApiArchives.partfiles(wf.CaptureRoot);
            using var step = new CreateCaptureIndexStep(wf, host, state, files);
            step.Run();
        }
    }

    ref struct CreateCaptureIndexStep
    {
        readonly IWfShell Wf;

        readonly PartFiles SourceFiles;

        public ApiCaptureIndex EncodedIndex;

        readonly List<Instruction> Buffer;

        readonly IWfCaptureState State;

        readonly WfHost Host;

        public CreateCaptureIndexStep(IWfShell wf, WfHost host, IWfCaptureState state, PartFiles src)
        {
            Wf = wf;
            Host = host;
            State = state;
            SourceFiles = src;
            EncodedIndex = default;
            Buffer = list<Instruction>(2000);
            Wf.Created(Host);
        }

        public void Dispose()
        {
            Wf.Disposed(Host.Id);
        }

        void BuildIndex()
        {
            EncodedIndex = CaptureIndexBuilder.create(Wf, Host, SourceFiles);
        }

        public void Run()
        {
            Wf.Running(Host);

            try
            {
                BuildIndex();

                Wf.Raise(new PartIndexCreated(Host, EncodedIndex, Wf.Ct));

                var index = EncodedIndex;
                Process(index);
                var decoded = DecodeParts(index);
                Process(decoded);

            }
            catch(Exception e)
            {
                Wf.Error(Host,e);
            }

            Wf.Ran(Host);
        }

        Span<ApiPartRoutines> DecodeParts(in ApiCaptureIndex src)
        {
            Wf.Status(Host, text.format("Decoding {0} entries from {1} parts", src.EntryCount, src.Parts.Length));

            var parts = src.Parts;
            var dst = alloc<ApiPartRoutines>(parts.Length);
            var hostFx = list<ApiHostRoutines>();
            var kMembers = 0u;
            var kHosts = 0u;
            var kParts = 0u;
            var kFx = 0u;

            for(var i=0; i<parts.Length; i++)
            {
                hostFx.Clear();
                var part = parts[i];
                if(part == 0)
                {
                    dst[i] = new ApiPartRoutines(part, sys.empty<ApiHostRoutines>());
                }
                else
                {
                    var hosts = src.Hosts.Where(h => h.Owner == part);
                    Wf.Status(Host, text.format("Decoding {0}", part.Format()));

                    for(var j=0; j<hosts.Length; j++)
                    {
                        var host = hosts[j];
                        var members = src[host];
                        var fx = Decode(members);
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

        ApiHostRoutines Decode(in ApiHostCodeBlocks hcs)
        {
            var instructions = list<ApiRoutineObsolete>();
            var ip = MemoryAddress.Empty;
            var decoder = State.RoutineDecoder;
            var target = Buffer;
            var count = hcs.Length;

            for(var i=0; i<count; i++)
            {
                Buffer.Clear();
                ref readonly var block = ref hcs[i];
                decoder.Decode(block, x => target.Add(x));

                if(i == 0)
                    ip = Buffer[0].IP;

                instructions.Add(AsmProjections.project(ip, block, Buffer.ToArray()));
            }

            return new ApiHostRoutines(hcs.Host, instructions.ToArray());
        }

        void Process(in ApiCaptureIndex encoded)
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
            var dir = Wf.Paths.DatabaseRoot + FS.folder("tables") + FS.folder("asm");
            var dst = dir + FS.file(src.Key.ToString(), FileExtensions.Csv);
            var formatter = Formatters.dataset<AsmTableField>();
            using var writer = dst.Writer();
            writer.WriteLine(Table.header53<AsmTableField>());
            for(var i=0; i<count; i++)
                writer.WriteLine(AsmTables.format(skip(records,i), formatter).Render());

            Wf.Emitted(Host, dst);

        }

        void Process(ReadOnlySpan<ApiPartRoutines> src)
        {
            try
            {
                foreach(var part in src)
                {
                    ProcessInstructions.create().Run(Wf,part);
                    EmitCallIndex.create().Run(Wf, part);
                }
            }
            catch(Exception e)
            {
                Wf.Error(Host,e);
            }
        }
    }
}