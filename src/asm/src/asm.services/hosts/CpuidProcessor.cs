//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;

    using static Part;
    using static z;

    [ApiHost]
    public readonly struct DataProcessor
    {
        public delegate void SegmentProcessed(Vector128<byte> src);

        [MethodImpl(Inline), Op]
        public static Vector128<byte> process(ReadOnlySpan<IceCpuidFeature> src, SegmentProcessed step)
        {
            var srcCount = src.Length;
            var storage = default(Vector128<byte>);
            ref var dst = ref vfirst(storage);

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

            return storage;
        }

        [MethodImpl(Inline), Op]
        static int Capture(in IceCpuidFeature src, int remaining, int consumed, ref byte dst)
        {
            var name = src.ToString();
            ReadOnlySpan<char> rendered = name;

            var take = math.min(rendered.Length, remaining);
            var source = slice(rendered,0,take);
            ref var target = ref Unsafe.Add(ref dst, consumed);
            Asci.encode(source, ref target);
            return take;
        }
    }
}