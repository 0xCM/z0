//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;
    using static memory;

    public static partial class XTend
    {
        public static SymServices SymServices(this IWfRuntime wf)
            => Asm.SymServices.create(wf);
    }

    public class SymServices : AppService<SymServices>
    {
        public static ref SymRecord record<T>(Sym<T> src, ushort count, out SymRecord dst)
            where T : unmanaged
        {
            dst.TypeName = src.Type.Name;
            dst.SymCount = count;
            dst.Index = src.Index;
            dst.Name = src.Name;
            dst.Expr = src.Expr;
            dst.NameData = EncodeText(src.Name);
            dst.NameSize = (ushort)dst.NameData.Count;
            dst.ExprData = EncodeText(src.Expr.Format());
            dst.ExprSize = (ushort)dst.ExprData.Count;
            return ref dst;
        }

        public static ref SymTypeInfo symtype<T>(out SymTypeInfo dst)
            where T : unmanaged, Enum
        {
            var t = typeof(T);
            dst.TypeName = t.Name;
            dst.DataType = (PrimalCode)ClrEnums.ecode(t);
            dst.SymCount = (ushort)t.GetFields().Length;
            dst.TypeNameData = EncodeText(dst.TypeName);
            dst.TypeNameSize = (ushort)dst.TypeNameData.Length;
            return ref dst;
        }

        public Index<SymRecord> EmitSymRecords<E>()
            where E : unmanaged, Enum
        {
            var dst = Db.Table<SymRecord>(typeof(E).Name);
            var flow = Wf.EmittingTable<SymRecord>(dst);
            var symbols  = Symbols<E>().View;
            var count = symbols.Length;
            var buffer = alloc<SymRecord>(count);
            ref var target = ref first(buffer);
            var formatter = Tables.formatter<SymRecord>(SymRecord.RenderWidths);
            using var writer = dst.Writer();
            writer.WriteLine(formatter.FormatHeader());
            for(var i=0; i<count; i++)
            {
                ref readonly var symbol = ref skip(symbols,i);
                record(symbol, (ushort)count, out seek(target,i));
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
                seek(dst,i) = ByteSpans.spec(string.Format("Block{0:X2}", i), b.ToArray());
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
                => SymCache<K>.get().Index;

        [MethodImpl(Inline), Closures(UnsignedInts)]
        public static BinaryCode EncodeText(string src)
            => bytes(span(src)).ToArray();

        [MethodImpl(Inline), Op]
        public static ReadOnlySpan<char> DecodText(ReadOnlySpan<byte> src)
            => recover<char>(src);

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
                => ByteSpans.spec(src.Name, EncodeText(src.Name));
    }
}