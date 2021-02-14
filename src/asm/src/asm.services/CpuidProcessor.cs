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
    using static memory;

    [ApiHost]
    public readonly struct DataProcessor
    {
        [MethodImpl(Inline), Op]
        public static Vector128<byte> process(ReadOnlySpan<IceCpuidFeature> src, Action<Vector128<byte>> step)
        {
            var srcCount = src.Length;
            var storage = default(Vector128<byte>);
            ref var dst = ref gcpu.vfirst(storage);
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
        static int Capture(IceCpuidFeature src, int remaining, int consumed, ref byte dst)
        {
            var name = @span(src.ToString());
            var take = root.min(name.Length, remaining);
            var source = slice(name, 0, take);
            Asci.encode(source, ref @add(dst, consumed));
            return take;
        }
    }
}