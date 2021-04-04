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
        public static SymServices SymServices(this IWfShell wf)
            => Asm.SymServices.create(wf);
    }


    public readonly struct SymbolDataProviders
    {
        public readonly struct XData
        {
            public const string XNameText = "";

            public static ReadOnlySpan<char> XNameChars => XNameText;

            public static ReadOnlySpan<byte> XNameIndicies => new byte[]{0};

            public static ReadOnlySpan<byte> XNameLengths => new byte[]{0};

        }
    }

    [ApiComplete]
    public readonly struct AsmSymbolData
    {
        const string Reg32NameText = "eaxecxedxebxespebpesiedi";

        static ReadOnlySpan<char> RegGp32Names => Reg32NameText;

        static ReadOnlySpan<byte> RegGp32Indices => new byte[8]{0,3,6,9,12,15,18,19};

        static ReadOnlySpan<byte> RegGp32Sizes => new byte[8]{3,3,3,3,3,3,3,3};

        [MethodImpl(Inline)]
        public static ReadOnlySpan<char> name(RegIndex index)
        {
            ref readonly var i = ref skip(RegGp32Indices,(byte)(index));
            ref readonly var l = ref skip(RegGp32Sizes,(byte)(index));
            return slice(RegGp32Names,i,l);
        }
    }


    public class SymServices : WfService<SymServices>
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

        public void EmitSymData<E>()
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
        }

        public void GenBits()
        {
            var blocks = BitBlocks().View;
            var count = blocks.Length;
            var buffer = alloc<ByteSpanProp>(count);
            ref var dst = ref first(buffer);
            for(var i=0; i<count; i++)
            {
                ref readonly var block = ref skip(blocks,i);
                var b = @bytes(block.Data);
                seek(dst,i) = ByteSpans.property(string.Format("Block{0:X2}", i), b.ToArray());
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

        public Index<ByteSpanProp> NameProps<K>(Symbols<K> src)
            where K : unmanaged
        {
            var view = src.View;
            var count = view.Length;
            var buffer = alloc<ByteSpanProp>(count);
            ref var dst = ref first(buffer);
            for(var i=0; i<count; i++)
            {
                ref readonly var sym = ref skip(view,i);
                seek(dst,i) = NameProp(sym);
            }
            return buffer;
        }

        public ByteSpanProp NameProp<K>(Sym<K> src)
            where K : unmanaged
                => ByteSpans.property(src.Name, EncodeText(src.Name));
    }
}