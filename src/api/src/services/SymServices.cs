//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;
    using static core;
    using static Typed;

    using api = Symbols;

    public class SymServices : AppService<SymServices>
    {
        public Index<SymbolDetail> EmitSymDetails<E>()
            where E : unmanaged, Enum
        {
            var dst = Db.Table<SymbolDetail>(typeof(E).Name);
            var flow = Wf.EmittingTable<SymbolDetail>(dst);
            var symbols  = Symbols<E>().View;
            var count = symbols.Length;
            var buffer = alloc<SymbolDetail>(count);
            ref var target = ref first(buffer);
            var formatter = Tables.formatter<SymbolDetail>(SymbolDetail.RenderWidths);
            using var writer = dst.Writer();
            writer.WriteLine(formatter.FormatHeader());
            for(var i=0; i<count; i++)
            {
                ref readonly var symbol = ref skip(symbols,i);
                api.detail(symbol, (ushort)count, out seek(target,i));
                writer.WriteLine(formatter.Format(skip(target,i)));
            }
            Wf.EmittedTable(flow, count);
            return buffer;
        }

        public void GenBits()
        {
            var blocks = BitBlocks().View;
            var count = blocks.Length;
            var buffer = alloc<ByteSpanSpec>(count);
            ref var dst = ref first(buffer);
            for(var i=0; i<count; i++)
            {
                ref readonly var block = ref skip(blocks,i);
                var b = @bytes(block.Data);
                seek(dst,i) = ByteSpans.specify(string.Format("Block{0:X2}", i), b.ToArray());
            }
            var merge = ByteSpans.merge("CharBytes", buffer);
            var s0 = recover<char>(merge.Segment(16,16));
            Wf.Row(s0.ToString());
        }

        public Index<CharBlock8> BitBlocks(ushort start = 0, ushort end = 255)
        {
            var count = end - start + 1;
            var buffer = alloc<CharBlock8>(count);
            ref var dst = ref first(buffer);
            var k = 0;
            for(var i=start; i<=end; i++, k++)
            {
                var block = CharBlocks.alloc(n8);
                var data = block.Data;
                for(var j=0; j<8; j++)
                    seek(data,j) = bit.test(i,(byte)j).ToChar();
                block.Data.Invert();
                seek(dst,k) = block;
            }

            return buffer;
        }

        public Symbols<K> Symbols<K>()
            where K : unmanaged, Enum
                => Z0.Symbols.index<K>();

        public Index<ByteSpanSpec> NameProps<K>(Symbols<K> src)
            where K : unmanaged
        {
            var view = src.View;
            var count = view.Length;
            var buffer = alloc<ByteSpanSpec>(count);
            ref var dst = ref first(buffer);
            for(var i=0; i<count; i++)
            {
                ref readonly var sym = ref skip(view,i);
                seek(dst,i) = NameProp(sym);
            }
            return buffer;
        }

        public ByteSpanSpec NameProp<K>(Sym<K> src)
            where K : unmanaged
                => ByteSpans.specify(src.Name, text.utf16(src.Name).ToArray());
    }
}