//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    using static Root;
    using static core;

    [ApiHost]
    public readonly partial struct BitfieldSpecs
    {
        const NumericKind Closure = UnsignedInts;

        public static BitfieldSpec specify(utf8 name, params Pair<byte>[] parts)
        {
            var count = parts.Length;
            var view = @readonly(parts);
            var buffer = alloc<BitfieldSpecEntry>(count);
            ref var dst = ref first(buffer);
            for(byte i=0; i<count; i++)
            {
                ref readonly var part = ref skip(view,i);
                ref var entry = ref seek(dst,i);
                entry.Bitfield = name;
                entry.Index = i;
                entry.Name = string.Format("Seg{0}", i);
                entry.Offset = part.Left;
                entry.Width = part.Right;
            }
            return new BitfieldSpec(buffer);
        }

        [Op]
        public static ReadOnlySpan<ulong> chop(in BitfieldSpec spec, ulong src)
        {
            var dst = span<ulong>(spec.SegCount);
            for(var i=0; i<spec.SegCount; i++)
            {
                ref readonly var seg = ref skip(spec.Entries, i);
                seek(dst,i) = Bits.bitslice(src, seg.Offset, seg.Width);
            }
            return dst;
        }
    }
}