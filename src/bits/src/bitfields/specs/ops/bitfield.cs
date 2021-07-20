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

    partial struct BitfieldSpecs
    {
        [MethodImpl(Inline), Op]
        public static BitfieldModel bitfield(Identifier name, Index<BitfieldSeg> segs)
            => new BitfieldModel(name, segs, width(segs));

        public static BitfieldModel bitfield(string fieldname, Type[] src)
        {
            var tagged = src.Attributions<FieldSegAttribute>().OrderBy(x => x.Tag.Order).ToReadOnlySpan();
            var count = tagged.Length;
            var offset = 0u;
            var segs = alloc<BitfieldSeg>(count);
            for(var i=0; i<count; i++)
            {
                ref readonly var field = ref skip(tagged,i);
                var name = field.Type.Name;
                var width = field.Tag.Width;
                var left = offset;
                var right = offset + width - 1;
                seek(segs,i) = BitfieldSpecs.segment(name, left, right);

                offset += width;
            }

            return BitfieldSpecs.bitfield(fieldname, segs);
        }
    }
}