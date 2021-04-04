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

    public readonly struct StringPack
    {
        public string Content {get;}

        readonly Index<uint> Indices;

        readonly Index<uint> Lengths;

        public StringPack(string[] src)
        {
            var view = @readonly(src);
            Content = src.Concat();
            var count = src.Length;
            Indices = alloc<uint>(count);
            Lengths = alloc<uint>(count);
            var indices = Indices.Edit;
            var lengths = Lengths.Edit;
            for(var i=0u; i<count; i++)
            {
                seek(indices,i) = i;
                seek(lengths,i) = (uint)skip(view,i).Length;
            }
        }

        public ReadOnlySpan<char> Data
        {
            [MethodImpl(Inline)]
            get => Content;
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
        public void EmitSymbolData()
        {
            var symbols  = Symbols<Gp32>().View;
            var count = symbols.Length;
            for(var i=0; i<count; i++)
            {
                ref readonly var symbol = ref skip(symbols,i);
                var eName = EncodeName(symbol);
                var dName = DecodeName(eName);
                BinaryCode name = eName.ToArray();
                var rendered = string.Format("{0,-8} | {1,-8} | {2}", symbol.Index, dName.ToString(), name.Format());
                Wf.Row(rendered);
            }
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
            var merge = ByteSpans.merge(buffer, "CharBytes");
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
        public ReadOnlySpan<byte> EncodeName<K>(Sym<K> src)
            where K : unmanaged
                => bytes(span(src.Name.Content));

        [MethodImpl(Inline), Op]
        public ReadOnlySpan<char> DecodeName(ReadOnlySpan<byte> src)
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
                => ByteSpans.property(src.Name, EncodeName(src).ToArray());
    }
}