//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static z;
    using static Rules.Sequence;

    [ApiHost]
    public readonly partial struct Rules
    {
        public readonly partial struct Sequence
        {


        }

        [MethodImpl(Inline)]
        public static Replacement<T> replace<T>(T src, T dst)
            => new Replacement<T>(src,dst);

        public static Replacements<T> replace<T>(T[] src, T dst)
        {
            var count = src.Length;
            var buffer = sys.alloc<Replacement<T>>(count);
            ref var target = ref first(buffer);
            ref readonly var input = ref first(src);
            for(var i=0; i<count; i++)
                seek(target,i) = replace(skip(input,i), dst);
            return buffer;
        }

        [MethodImpl(Inline), Op]
        public static unsafe void apply<T>(Replacement<T> rule, ReadOnlySpan<T> src, Span<T> dst, int offset = 0)
            where T : unmanaged
        {
            var count = src.Length;
            var input = span(src);
            fixed(T* c = src)
                for(var i=offset; i<count; i++)
                    seek(dst,i) = (*c).Equals(rule.Match) ? rule.Replace : skip(input,i);
        }

        public static Replacements<T> replace<T>(Bijection<T> spec)
        {
            var src = spec.Source;
            var dst = spec.Target;
            Demands.insist(src.Length == dst.Length);
            var count = src.Length;
            var buffer = sys.alloc<Replacement<T>>(count);
            ref var target = ref first(buffer);
            ref readonly var input = ref first(src);
            ref readonly var output = ref first(dst);
            for(var i=0; i<count; i++)
                seek(target,i) = replace(skip(input,i), skip(output,i));
            return buffer;
        }

        public static Replacements<T> replace<T>(T[] src, T[] dst)
            => replace(Relations.bijection<T>(src,dst));
    }
}