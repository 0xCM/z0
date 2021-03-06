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

    partial struct Rules
    {
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static Replace<T> replace<T>(T src, T dst)
            => new Replace<T>(src,dst);

        [Op, Closures(Closure)]
        public static Span<Replace<T>> replace<T>(Span<T> src, T dst)
        {
            var count = src.Length;
            var buffer = sys.alloc<Replace<T>>(count);
            ref var target = ref first(buffer);
            ref readonly var input = ref first(src);
            for(var i=0; i<count; i++)
                seek(target,i) = replace(skip(input,i), dst);
            return buffer;
        }

        [Op, Closures(Closure)]
        public static Span<Replace<T>> replace<T>(in Bijection<T> spec)
        {
            var src = spec.Source;
            var dst = spec.Target;
            var count = src.Length;
            var buffer = alloc<Replace<T>>(count);
            ref var target = ref first(buffer);
            ref readonly var input = ref first(src);
            ref readonly var output = ref first(dst);
            for(var i=0; i<count; i++)
                seek(target,i) = replace(skip(input,i), skip(output,i));
            return buffer;
        }

        [Op, Closures(Closure)]
        public static Span<Replace<T>> replace<T>(ReadOnlySpan<T> src, ReadOnlySpan<T> dst)
            => replace(bijection<T>(src,dst));
    }
}