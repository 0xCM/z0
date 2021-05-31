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

    [ApiHost]
    public readonly struct BitfieldRender
    {
        // [MethodImpl(Inline), Op]
        // public static BitfieldRender service(in BitfieldSpec bitfield)
        //     => new BitfieldRender(bitfield);

        // readonly BitfieldSpec Bitfield;

        // [MethodImpl(Inline)]
        // BitfieldRender(in BitfieldSpec bitfield)
        // {
        //     Bitfield = bitfield;
        // }

        // ReadOnlySpan<BitfieldSpecEntry> Entries
        // {
        //     [MethodImpl(Inline)]
        //     get => Bitfield.Entries;
        // }


        // [Op]
        // public uint Render(ulong src, Span<char> dst)
        // {
        //     var counter = 0u;
        //     var segments = Entries;
        //     var count = Bitfield.SegCount;
        //     for(var i=0; i<count; i++)
        //     {
        //         ref var target = ref seek(dst, counter);
        //         render(src, skip(segments, i), ref counter, ref target);
        //         if(i != count - 1)
        //             seek(target, counter++) = Chars.Space;
        //     }

        //     return counter;
        // }

        // [MethodImpl(Inline), Op]
        // static void render(ulong src, in BitfieldSpecEntry spec, ref uint counter, ref char dst)
        // {
        //     var seg = Bits.bitslice(src, spec.Offset, spec.Width);
        //     render(seg, spec.Width, ref counter, ref dst);
        // }

        // [MethodImpl(Inline), Op]
        // static void render(ulong seg, byte width, ref uint counter, ref char dst)
        // {
        //     for(byte j=0; j<width; j++)
        //         seek(dst, counter++) = bit.bitchar(seg, j);
        // }
    }
}