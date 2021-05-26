//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using static core;

    public class ApiHexPacks : AppService<ApiHexPacks>
    {
        [Op]
        public Index<HexPacked> Pack(Index<ApiCodeBlock> src, bool validate = false)
        {
            const ushort BufferLength = 48400;

            var blocks = src.Sort().View;
            var count = blocks.Length;
            var packs = alloc<HexPacked>(count);
            var chars = alloc<char>(BufferLength);
            ref var dst = ref first(packs);
            var size = HexPacks.pack(blocks, packs, chars);
            if(validate)
            {
                var buffer = span<HexDigit>(BufferLength);
                var flow = Wf.Running("Validating pack");
                for(var i=0; i<count; i++)
                {
                    buffer.Clear();
                    ref readonly var pack = ref skip(dst,i);
                    var outcome = Hex.digits(pack.Data,buffer);
                    if(!outcome)
                    {
                        Wf.Error("Reconstitution failed");
                        break;
                    }
                }
                Wf.Ran(flow,$"Validated {count} packs");
            }

            return packs;
        }

        [Op]
        public Index<HexPacked> Emit(Index<ApiCodeBlock> blocks, FS.FilePath? dst = null, bool validate = false)
        {
            var _dst = dst ?? Db.TableRoot() + FS.file("apihex", FS.ext("xpack"));
            var result = Pack(blocks,validate);
            var packed = result.View;
            var emitting = Wf.EmittingFile(_dst);
            using var writer = _dst.Writer();
            var count = packed.Length;
            for(var i=0; i<count; i++)
                writer.WriteLine(skip(packed,i).Format());
            Wf.EmittedFile(emitting, count);
            return result;
        }

        [Op]
        public ByteSize Emit(in HexPack src, FS.FilePath dst)
        {
            var flow = Wf.EmittingFile(dst);
            using var writer = dst.Writer();
            var total = HexPacks.emit(src, writer);
            Wf.EmittedFile(flow, (uint)total);
            return total;
        }

        [Op]
        public ByteSize Emit(in MemoryBlock src, FS.FilePath dst)
        {
            var flow = Wf.EmittingFile(dst);
            using var writer = dst.Writer();
            var total = HexPacks.emit(HexPacks.pack(src), writer);
            Wf.EmittedFile(flow, (uint)total);
            return total;
        }
    }
}