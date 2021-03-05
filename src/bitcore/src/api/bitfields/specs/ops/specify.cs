//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;

    using static Part;
    using static memory;

    partial struct BitFieldModels
    {
        [Op]
        public static BitFieldModel model(Name name, ReadOnlySpan<string> names, ReadOnlySpan<byte> widths)
        {
            Demands.insist(names.Length, widths.Length);
            var count = (uint)names.Length;
            var fieldWidths = span(widths);
            var posbuffer = alloc<uint>(count);
            var positions = span(posbuffer);
            var sBuffer = alloc<BitFieldSegment>(count);
            var segments = span(sBuffer);
            uint totalWidth = 0;
            for(var i=0u; i<count; i++)
            {
                ref readonly var w = ref skip(widths,i);
                ref readonly var segname = ref skip(names,i);
                seek(positions,i) = totalWidth;
                seek(segments,i) = new BitFieldSegment(segname, section<uint>(segname, totalWidth, totalWidth + w));
                totalWidth += skip(fieldWidths, i);
            }
            return new BitFieldModel(name, count, totalWidth, sBuffer);
        }

        /// <summary>
        /// Defines a bitfield predicated on an indexing enumeration I, the underlying numeric type of I, T, and a width-defining enumeration W
        /// </summary>
        /// <typeparam name="E">The indexing enum type</typeparam>
        /// <typeparam name="T">The underlying type of the indexing enum</typeparam>
        /// <typeparam name="W">The width enum type</typeparam>
        [MethodImpl(Inline)]
        public static BitFieldSpec specify<I,U,W>()
            where I : unmanaged, Enum
            where U : unmanaged
            where W : unmanaged, Enum
                => new BitFieldSpec(segments(index<I,U,W>()));

        /// <summary>
        /// Defines a bitfield predicated on explicitly-specified segments
        /// </summary>
        /// <param name="segments">The defining segments</param>
        [MethodImpl(Inline), Op]
        public static BitFieldSpec specify(params BitFieldSegment[] segments)
            => new BitFieldSpec(segments);

        /// <summary>
        /// Defines a bitfield predicated on an indexing enumeration I, with an assumed underlying
        /// numeric type of byte, and a width-defining enumeration W
        /// </summary>
        /// <typeparam name="I">The indexing enum type</typeparam>
        /// <typeparam name="U">The underlying type of the indexing enum</typeparam>
        /// <typeparam name="W">The width enum type</typeparam>
        [MethodImpl(Inline)]
        public static BitFieldSpec specify<I,W>()
            where I : unmanaged, Enum
            where W : unmanaged, Enum
                => specify<I,byte,W>();

        [MethodImpl(Inline)]
        public static BitFieldSpec256<F> specify<F>(W256 w)
            where F : unmanaged, Enum
        {
            Span<F> values = Enums.literals<F>();
            var widths = values.Bytes();
            var count = root.min(widths.Length, 32);
            var data = default(Vector256<byte>);
            for(var i=0; i<count; i++)
                data = data.WithElement(i,skip(widths,i));
            return new BitFieldSpec256<F>(data);
        }
    }
}