//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.IO;
    using System.Runtime.CompilerServices;

    using PEReader = System.Reflection.PortableExecutable.PEReader;

    using static Konst;
    using static z;

    public sealed class EmitImageHeaders : CmdHost<EmitImageHeaders, EmitImageHeadersCmd>
    {
        [MethodImpl(Inline)]
        public static EmitImageHeadersCmd specify(IWfShell wf, FS.FilePath[] src, FS.FilePath dst)
        {
            var cmd = new EmitImageHeadersCmd();
            cmd.Sources = src;
            cmd.Target = dst;
            return cmd;
        }

        [CmdWorker]
        public static CmdResult run(IWfShell wf, EmitImageHeadersCmd spec)
        {
            var total = Count.Zero;
            var formatter = TableRows.formatter<ImageSectionHeader>(ImageSectionHeader.RenderWidths);
            using var writer = spec.Target.Writer();
            writer.WriteLine(formatter.FormatHeader());
            foreach(var file in spec.Sources)
            {
                var result = read(file, out Span<ImageSectionHeader> dst);
                if(result)
                {
                    var count = result.Data;

                    for(var i=0u; i<count; i++)
                    {
                        ref readonly var row = ref skip(dst,i);
                        writer.WriteLine(formatter.FormatRow(skip(dst,i)));
                    }

                    total += count;

                    wf.EmittedFile(total, spec.Target);
                }
            }
            return Win();
        }

        protected override CmdResult Execute(IWfShell wf, in EmitImageHeadersCmd spec)
            => run(wf,spec);

        public static Outcome<uint> read(FS.FilePath path, out Span<ImageSectionHeader> target)
        {
            using var stream = File.OpenRead(path.Name);
            using var reader = new PEReader(stream);
            var peHeaders = reader.PEHeaders;
            var sections = @readonly(peHeaders.SectionHeaders.Array());
            var count = (uint)sections.Length;
            var filename = path.FileName;

            target = span<ImageSectionHeader>(count);

            for(var i=0u; i<count; i++)
            {
                ref var dst = ref seek(target,i);
                ref readonly var src = ref skip(sections,i);
                dst.File = filename;
                dst.EntryPoint = (Address32)peHeaders.PEHeader.AddressOfEntryPoint;
                dst.CodeBase = (Address32)peHeaders.PEHeader.BaseOfCode;
                dst.GptRva = (Address32)peHeaders.PEHeader.GlobalPointerTableDirectory.RelativeVirtualAddress;
                dst.GptSize = (ByteSize)peHeaders.PEHeader.GlobalPointerTableDirectory.Size;
                dst.SectionAspects = src.SectionCharacteristics;
                dst.SectionName = src.Name;
                dst.RawData = (Address32)src.PointerToRawData;
                dst.RawDataSize = src.SizeOfRawData;
            }

            return count;
        }
    }
}