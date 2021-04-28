//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System.Runtime.CompilerServices;
    using System.IO;

    using static Part;
    using static memory;

    public class HexPacks : AppService<HexPacks>
    {
        [Op]
        public Index<HexPacked> BuildRecords(Index<ApiCodeBlock> src, bool validate = false)
        {
            var blocks = src.Sort().View;
            var count = blocks.Length;
            var packs = alloc<HexPacked>(count);
            ref var dst = ref first(packs);
            var size = CodeBlocks.pack(blocks, packs);
            if(validate)
            {
                var buffer = span<HexDigit>(48400);
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
            var result = BuildRecords(blocks,validate);
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
        public ByteSize Emit(in HexPack src, StreamWriter dst)
        {
            var blocks = src.Blocks;
            var count = blocks.Length;
            var buffer = span<char>(src.MaxBlockSize*2);
            var total = 0u;
            for(var i=0u; i<count;i++)
            {
                buffer.Clear();
                ref readonly var block = ref skip(blocks,i);
                var charcount = CodeBlocks.pack(block.View, buffer);
                var formatted = text.format(slice(buffer,0, charcount));
                var size = (uint)block.Size;
                dst.WriteLine(string.Format(FormatPattern, block.BaseAddress, i, size, formatted));
                total += size;
            }
            return total;
        }

        [Op]
        public ByteSize Emit(in HexPack src, FS.FilePath dst)
        {
            var flow = Wf.EmittingFile(dst);
            using var writer = dst.Writer();
            var total = Emit(src, writer);
            Wf.EmittedFile(flow, (uint)total);
            return total;
        }

        const string FormatPattern = "x{0:x}[{1:D5}:{2:D5}]=<{3}>";
    }
}