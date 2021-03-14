//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Hex8Seq;
    using static memory;
    using static Part;

    public readonly struct AsmHexPatterns
    {
        [MethodImpl(Inline), Op]
        public static Cell128 terminal(N1 n)
            => Cells.cell(w128,bytes(P01));

        [MethodImpl(Inline), Op]
        public static bool matches(Cell128 pattern, Cell128 candidate)
        {
            var w  = w128;
            var a = gcpu.vload(w, pattern.Bytes);
            var b = gcpu.vload(w, candidate.Bytes);
            var c = cpu.vand(a,b);
            return default;
        }

        static ReadOnlySpan<Hex8Seq> P01 => new Hex8Seq[16]{
                xe8,x00,x00,x00,x00, // call 7ffc600f3bb0h => e8 _ _ _ _
                xcc,                 // int 3 | cc
                x00,x00,             // add [rax], al => 00 00
                x00,x00,             // add [rcx], bl => 00 19
                x00,x00,x00,x00,x00,x00
            };

        static ReadOnlySpan<Hex8Seq> P02 => new Hex8Seq[16]{
                x00,x00,x00,x00,x00,x00,x00,x00,x00,x00,x00,x00,x00,x00,x00,x00
            };

        static ReadOnlySpan<Hex8Seq> P03 => new Hex8Seq[16]{
                x00,x00,x00,x00,x00,x00,x00,x00,x00,x00,x00,x00,x00,x00,x00,x00
            };

        static ReadOnlySpan<Hex8Seq> P04 => new Hex8Seq[16]{
                x00,x00,x00,x00,x00,x00,x00,x00,x00,x00,x00,x00,x00,x00,x00,x00
            };

    }

}