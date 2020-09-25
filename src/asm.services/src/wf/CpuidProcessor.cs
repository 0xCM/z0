//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;

    using static Konst;
    using static Root;
    using static As;

    [ApiHost]
    public readonly struct CpuidProcessor
    {
        public static CpuidProcessor Service => default;

        [MethodImpl(Inline), Op]
        public asci16 Process(ReadOnlySpan<CpuidFeature> src, CpuidProcessStep step)
        {
            var srcCount = src.Length;
            var storage = default(Vector128<byte>);
            ref var dst = ref z.vfirst(storage);

            var consumed = 0;
            var remaining = asci16.Size;

            for(var i=0; i<srcCount; i++)
            {
                if(remaining <= 0)
                    break;

                var take = Capture(skip(src,i), remaining, consumed, ref dst);

                step(storage);

                consumed += take;
                remaining -= take;
            }

            return new asci16(storage);
        }

        [MethodImpl(Inline), Op]
        public int Capture(in CpuidFeature src, int remaining, int consumed, ref byte dst)
        {
            var name = src.ToString();
            ReadOnlySpan<char> rendered = name;

            var take = math.min(rendered.Length, remaining);
            var source = slice(rendered,0,take);
            ref var target = ref Unsafe.Add(ref dst, consumed);
            asci.encode(source, ref target);
            return take;
        }
    }
}