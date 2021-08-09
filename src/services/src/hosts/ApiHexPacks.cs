//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    using static Root;
    using static core;

    public class ApiHexPacks : AppService<ApiHexPacks>
    {
        public Lookup<FS.FilePath,HexPack> LoadParsed(FS.FolderPath src)
            => Load(src.Files(".parsed", FS.XPack, true));

        public Lookup<FS.FilePath,HexPack> Load(FS.Files src)
        {
            var flow = Running(string.Format("Loading {0} packs", src.Length));
            var lookup = new Lookup<FS.FilePath,HexPack>();
            var errors = new Lookup<FS.FilePath,Outcome>();
            iter(src, path => load(path, lookup, errors), true);
            var result = lookup.Seal();
            var count = result.EntryCount;
            var entries = result.Entries;
            var counter = 0u;
            for(var i=0; i<count; i++)
            {
                ref readonly var entry = ref skip(entries,i);
                var path = entry.Key;
                var blocks = entry.Value.Blocks;
                var blockCount = (uint)blocks.Length;
                var host = path.FileName.Format().Remove(".extracts.parsed.xpack").Replace(".","/");
                Write(string.Format("Loaded {0} blocks from {1}", blockCount, path.ToUri()));
                counter += blockCount;
            }

            Ran(flow, string.Format("Loaded {0} total blocks", counter));

            return result;
        }

        [Op]
        public Index<HexPacked> Pack(SortedReadOnlySpan<ApiCodeBlock> src, bool validate = false)
        {
            const ushort BufferLength = 48400;

            var blocks = src.View;
            var count = blocks.Length;
            var packs = alloc<HexPacked>(count);
            var chars = alloc<char>(BufferLength);
            ref var dst = ref first(packs);
            var size = HexPacks.pack(blocks, packs, chars);
            if(validate)
            {
                var buffer = span<HexDigit>(BufferLength);
                var flow = Running("Validating pack");
                for(var i=0; i<count; i++)
                {
                    buffer.Clear();
                    ref readonly var pack = ref skip(dst,i);
                    var outcome = Hex.digits(pack.Data,buffer);
                    if(!outcome)
                    {
                        Error("Reconstitution failed");
                        break;
                    }
                }
                Ran(flow,$"Validated {count} packs");
            }

            return packs;
        }

        [Op]
        public Index<HexPacked> Emit(SortedReadOnlySpan<ApiCodeBlock> blocks, FS.FilePath? dst = null, bool validate = false)
        {
            var _dst = dst ?? Db.TableRoot() + FS.file("apihex", FS.ext("xpack"));
            var result = Pack(blocks, validate);
            var packed = result.View;
            var emitting = EmittingFile(_dst);
            using var writer = _dst.Writer();
            var count = packed.Length;
            for(var i=0; i<count; i++)
                writer.WriteLine(skip(packed,i).Format());
            EmittedFile(emitting, count);
            return result;
        }

        [Op]
        public ByteSize Emit(in HexPack src, FS.FilePath dst)
        {
            var flow = EmittingFile(dst);
            using var writer = dst.Writer();
            var total = HexPacks.emit(src, writer);
            EmittedFile(flow, (uint)total);
            return total;
        }

        [Op]
        public ByteSize Emit(in MemoryBlock src, FS.FilePath dst)
        {
            var flow = EmittingFile(dst);
            using var writer = dst.Writer();
            var total = HexPacks.emit(HexPacks.pack(src), writer);
            EmittedFile(flow, (uint)total);
            return total;
        }

        static void load(FS.FilePath src, Lookup<FS.FilePath,HexPack> success, Lookup<FS.FilePath,Outcome> fail)
        {
            var result = HexPacks.load(src, out var pack);
            if(result.Fail)
                fail.Add(src, result);
            else
                success.Add(src, pack);
        }
    }
}