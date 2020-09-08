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
    using static CreateGlobalIndexStep;

    public ref struct CreateGlobalIndex
    {
        readonly IWfShell Wf;

        readonly CorrelationToken Ct;

        readonly PartFiles SourceFiles;

        public GlobalCodeIndex EncodedIndex;

        readonly List<Instruction> Buffer;

        readonly IWfCaptureState State;

        public CreateGlobalIndex(IWfShell wf, IWfCaptureState state, PartFiles src)
        {
            Wf = wf;
            Ct = Wf.Ct;
            State = state;
            SourceFiles = src;
            EncodedIndex = default;
            Buffer = list<Instruction>(2000);
            Wf.Created(StepId, src.Root);
        }

        public void Dispose()
        {
            Wf.Finished(StepId, Ct);
        }

        public void Run()
        {
            Wf.Running(StepId);

            try
            {
                var files = SourceFiles.ParseFiles.View;
                var count = files.Length;
                var builder = new BuildGlobalCodeIndex(Wf);

                Wf.Status(StepId, text.format("Indexing {0} datasets",count));

                for(var i=0; i<count; i++)
                {
                    ref readonly var path = ref skip(files,i);

                    var result = MemberParseRecord.load(path);
                    if(result)
                    {
                        Index(result.Value, builder);
                        Wf.Status(StepId, text.format("Indexed {0}", path));
                    }
                    else
                        Wf.Error(StepId, $"Could not parse {path}");
                }

                var status = builder.Status();
                Wf.Status(StepId, text.format("Freeze: {0}", status.Format()));

                EncodedIndex = builder.Freeze();
                Wf.Raise(new CreatedPartIndex(StepName, EncodedIndex, Ct));


                var index = EncodedIndex;
                Process(index);
                var decoded = DecodeParts(index);
                Process(decoded);

            }
            catch(Exception e)
            {
                Wf.Error(e, Ct);
            }

            Wf.Ran(StepId);
        }

        void Index(ReadOnlySpan<MemberParseRecord> src, BuildGlobalCodeIndex dst)
        {
            var count = src.Length;
            for(var i=0; i<count; i++)
                Index(skip(src,i), dst);
        }

        void Index(in MemberParseRecord src, BuildGlobalCodeIndex dst)
        {
            if(src.Address.IsEmpty)
                return;

            var code = new X86ApiCode(src.Uri, src.Data);
            var inclusion = dst.Include(code);
            if(inclusion.Any(x => x == false))
                Wf.Warn(StepId, $"Duplicate | {src.Uri.Format()}");
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

        HostAsmFx Decode(EncodedMemberIndex hcs)
        {
            var instructions = Root.list<MemberAsmFx>();
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

                var member = MemberAsmFx.Create(ip, uriCode, Buffer.ToArray());
                instructions.Add(member);
            }

            return new HostAsmFx(hcs.Host, instructions.ToArray());
        }

        void Process(GlobalCodeIndex encoded)
        {
            try
            {
                var id = new ProcessGlobalIndexStep().Id;
                Wf.Running(id);

                var processor = new ProcessAsm(State, encoded);
                var parts = Wf.Api.Composition.Resolved.Select(p => p.Id);
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

                Wf.Ran(StepId);

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
            var dir = Wf.Paths.ResourceRoot + FolderName.Define("tables") + FolderName.Define("asm");
            var dst = dir + FileName.define(src.Key.ToString(), FileExtensions.Csv);
            using var writer = dst.Writer();
            writer.WriteLine(AsmRecord.FormatHeader());
            for(var i=0; i<count; i++)
            {
                ref readonly var record = ref skip(records,i);
                writer.WriteLine(record.Format());
            }
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
    }
}