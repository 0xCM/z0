//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;

    using static Konst;
    using static z;    

    readonly partial struct CellBlocks
    {
        [MethodImpl(Inline), Op]
        public static CellBlock32 init(Vector256<ushort> lo, Vector256<ushort> hi)
        {
            var src = new Seg512(lo,hi);
            var dst = alloc(w32);
            copy(z.bytes(src), ref dst);
            return dst;
        }

        readonly struct Seg512
        {
            readonly Vector256<ushort> Lo;

            readonly Vector256<ushort> Hi;

            [MethodImpl(Inline), Op]
            public Seg512(Vector256<ushort> lo, Vector256<ushort> hi)
            {
                Lo = lo;
                Hi = hi;
            }
        }
    }
}