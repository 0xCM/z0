//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Reflection;

    using static Part;
    using static memory;


    public struct SymbolHeapEntry
    {
        public ushort Index;

        public Identifier Name;

    }

    [ApiHost]
    public class SymbolHeap
    {
        [MethodImpl(Inline), Op]
        public static uint charcount(ReadOnlySpan<SymLiteral> src)
        {
            var width = 0u;
            var kSrc = src.Length;
            for(var i=0; i<kSrc; i++)
            {
                ref readonly var symbol = ref skip(src,i).Symbol;
                width += (uint)symbol.CharCount;
            }
            return width;
        }

        [MethodImpl(Inline), Op]
        public static ReadOnlySpan<char> symchars(SymbolHeap src, ushort index)
            => slice(src.Expressions.View, offset(src, index), width(src,index));

        [Op]
        public static SymExpr symexpr(SymbolHeap src, ushort index)
            => text.format(symchars(src,index));

        [MethodImpl(Inline), Op]
        public static uint offset(SymbolHeap src, ushort index)
            => src.Offsets[index];

        [MethodImpl(Inline), Op]
        public static ushort width(SymbolHeap src, ushort index)
            => src.Widths[index];

        [MethodImpl(Inline), Op]
        public static ref readonly Identifier identifier(SymbolHeap src, ushort index)
            => ref src.Identifiers[index];

        [Op]
        public static SymbolHeap create(ReadOnlySpan<SymLiteral> src)
        {
            var dst = new SymbolHeap();

            var kSym = (uint)src.Length;
            var kEntry = (uint)Bits.next((Pow2x16)Bits.xmsb(kSym));
            dst.SymbolCount = kSym;
            dst.EntryCount = kEntry;
            dst.Widths = alloc<ushort>(kEntry);
            dst.Values = alloc<ulong>(kEntry);
            dst.Identifiers = alloc<Identifier>(kEntry);
            dst.Expressions = alloc<char>(charcount(src));
            dst.Offsets = alloc<uint>(kEntry);

            ref var widths = ref dst.Widths.First;
            ref var values = ref dst.Values.First;
            ref var symdst = ref dst.Expressions.First;
            ref var offsets = ref dst.Offsets.First;
            ref var id = ref dst.Identifiers.First;
            var offset=0u;
            for(var i=0; i<kSym; i++)
            {
                ref readonly var literal = ref skip(src,i);
                var symsrc = literal.Symbol.Data;
                var width = (ushort)symsrc.Length;

                seek(widths, i) = width;
                seek(values, i) = literal.EncodedValue;
                seek(id, i) = literal.Name;
                seek(offsets,i) = offset;
                symsrc.CopyTo(cover(seek(symdst, offset), width));

                offset+=width;
            }

            return dst;
        }

        Index<char> Expressions;

        Index<ushort> Widths;

        Index<uint> Offsets;

        Index<ulong> Values;

        Index<Identifier> Identifiers;

        public uint SymbolCount {get; private set;}

        uint EntryCount;

        [MethodImpl(Inline), Op]
        public ReadOnlySpan<char> SymChars(ushort index)
            => symchars(this, index);

        [Op]
        public SymExpr Expression(ushort index)
            => symexpr(this, index);

        [Op]
        public ref readonly Identifier Identifier(ushort index)
            => ref identifier(this,index);
    }
}