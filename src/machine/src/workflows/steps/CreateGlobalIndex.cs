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

    public ref struct CreateGlobalIndex
    {
        readonly IWfShell Wf;

        readonly CorrelationToken Ct;

        readonly PartFiles SourceFiles;

        public X86CodeIndex EncodedIndex;

        readonly List<Instruction> Buffer;

        readonly IWfCaptureState State;

        readonly CreateGlobalIndexHost Host;

        public CreateGlobalIndex(IWfShell wf, CreateGlobalIndexHost host, IWfCaptureState state, PartFiles src)
        {
            Wf = wf;
            Host = host;
            Ct = Wf.Ct;
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

        public void Run()
        {
            Wf.Running(Host);

            try
            {
                var files = SourceFiles.Parsed.View;
                var count = files.Length;
                var builder = new EmitCaptureIndex(Wf, new EmitCaptureIndexHost());

                Wf.Status(Host.Id, text.format("Indexing {0} datasets",count));

                for(var i=0; i<count; i++)
                {
                    ref readonly var path = ref skip(files,i);

                    var result = MemberParseReport.load(path);
                    if(result)
                    {
                        Index(result.Value, builder);
                        Wf.Status(Host.Id, text.format("Indexed {0}", path));
                    }
                    else
                        Wf.Error(Host.Id, $"Could not parse {path}");
                }

                var status = builder.Status();
                Wf.Status(Host.Id, text.format("Freeze: {0}", status.Format()));

                builder.Run();
                EncodedIndex = builder.Index;
                Wf.Raise(new CreatedPartIndex(Host.Id, EncodedIndex, Ct));


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

        void Index(ReadOnlySpan<MemberParseRow> src, EmitCaptureIndex dst)
        {
            var count = src.Length;
            for(var i=0; i<count; i++)
                Index(skip(src,i), dst);
        }

        void Index(in MemberParseRow src, EmitCaptureIndex dst)
        {
            if(src.Address.IsEmpty)
                return;

            var code = new X86ApiCode(src.Uri, src.Data);
            var inclusion = dst.Include(code);
            if(inclusion.Any(x => x == false))
                Wf.Warn(Host.Id, $"Duplicate | {src.Uri.Format()}");
        }

        Span<ApiPartRoutines> DecodeParts(X86CodeIndex src)
        {
            Wf.Status(Host.Id, text.format("Decoding {0} entries from {1} parts", src.EntryCount, src.Parts.Length));

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
                var hosts = src.Hosts.Where(h => h.Owner == part);

                Wf.Status(Host.Id, text.format("Decoding {0}", part.Format()));

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

                Wf.Status(Host.Id, text.format(RenderPatterns.PSx4, kParts, kHosts, kMembers, kFx));
            }

            Wf.Status(Host.Id, text.format("Decoded {0} entries from {1} parts", src.EntryCount, src.Parts.Length));
            return dst;
        }

        ApiHostRoutines Decode(X86HostIndex hcs)
        {
            var instructions = Root.list<ApiRoutine>();
            var ip = MemoryAddress.Empty;
            var decoder = State.RoutineDecoder;
            var target = Buffer;

            for(var i=0; i<hcs.Length; i++)
            {
                Buffer.Clear();
                ref readonly var uriCode = ref hcs[i];
                decoder.Decode(uriCode, x => target.Add(x));

                if(i == 0)
                    ip = Buffer[0].IP;

                instructions.Add(asm.routine(ip, uriCode, Buffer.ToArray()));
            }

            return new ApiHostRoutines(hcs.Host, instructions.ToArray());
        }

        void Process(X86CodeIndex encoded)
        {
            try
            {
                var id = new CreateGlobalIndexStep().Id;
                Wf.Running(id);

                var processor = new ProcessAsm(State, encoded);
                var parts = Wf.Api.PartIdentities;
                Wf.Raise(new ProcessingParts(id, parts, Ct));
                var result = processor.Process();
                Wf.Ran(id, result.Count);

                var sets = result.View;
                var count = result.Count;
                for(var i=0; i<count; i++)
                {
                    ref readonly var set = ref skip(sets,i);
                    Process(set);
                }

                Wf.Ran(Host.Id);

            }
            catch(Exception e)
            {
                Wf.Error(e);
            }
        }

        void Process(in AsmRecordSet<Mnemonic> src)
        {
            var count = src.Count;
            var records = span(src.Sequenced);
            var dir = Wf.Paths.ResourceRoot + FolderName.Define("tables") + FolderName.Define("asm");
            var dst = dir + FileName.define(src.Key.ToString(), FileExtensions.Csv);
            var formatter = Formatters.dataset<AsmRecordField>();
            using var writer = dst.Writer();
            writer.WriteLine(Table.header53<AsmRecordField>());
            for(var i=0; i<count; i++)
                writer.WriteLine(asm.format(skip(records,i), formatter).Render());
        }

        void Process(ReadOnlySpan<ApiPartRoutines> src)
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
            catch(Exception e)
            {
                Wf.Error(Host,e);
            }
        }

        void Process(ApiPartRoutines fx)
        {
            try
            {
                var step = new ProcessInstructions(Wf,fx);
                step.Run();
            }
            catch(Exception e)
            {
                Wf.Error(Host,e);
            }
        }
    }
}