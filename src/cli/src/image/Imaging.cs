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

    using Z0.Images;

    using static Konst;
    using static z;


    public sealed class Imaging : WfService<Imaging,Imaging>
    {
        static ReadOnlySpan<byte> RenderWidths
            => new byte[9]{60,16,16,12,12,60,16,16,16};

        public void EmitHeaders(IBuildArchive src)
        {
            var svc = Imaging.init(Wf);
            var db = Wf.Db();
            var dir = db.TableDir<ImageSectionHeader>();
            var cmd = CmdBuilder.EmitImageHeaders(src.DllFiles().Array(), db.Table(ImageSectionHeader.TableId, "dll"));
            svc.EmitHeaders(cmd.Source, cmd.Target);
            cmd = CmdBuilder.EmitImageHeaders(src.ExeFiles().Array(), db.Table(ImageSectionHeader.TableId, "exe"));
            svc.EmitHeaders(cmd.Source, cmd.Target);
        }

        public Outcome<Count> EmitHeaders(FS.Files src, FS.FilePath dst)
        {
            var total = Count.Zero;
            var formatter = TableFormatter.row<ImageSectionHeader>(RenderWidths);
            using var writer = dst.Writer();
            writer.WriteLine(formatter.FormatHeader());
            foreach(var file in src)
            {
                var result = read(file, out Span<ImageSectionHeader> headers);
                if(result)
                {
                    var count = result.Data;

                    for(var i=0u; i<count; i++)
                        writer.WriteLine(formatter.FormatRow(skip(headers,i)));

                    total += count;
                }
            }

            return total;
        }

        static Outcome<uint> read(FS.FilePath path, out Span<ImageSectionHeader> target)
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
                dst.RawDataAddress = (Address32)src.PointerToRawData;
                dst.RawDataSize = src.SizeOfRawData;
            }

            return count;
        }
    }
}