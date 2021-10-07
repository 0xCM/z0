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
    using static FunctionModels;

    partial struct Rules
    {
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static Replace<T> replace<T>(T src, T dst)
            where T : IEquatable<T>
                => new Replace<T>(src,dst);

        [Op, Closures(Closure)]
        public static Span<Replace<T>> replacements<T>(Span<T> src, T dst)
            where T : IEquatable<T>
        {
            var count = src.Length;
            var buffer = sys.alloc<Replace<T>>(count);
            ref var target = ref first(buffer);
            ref readonly var input = ref first(src);
            for(var i=0; i<count; i++)
                seek(target,i) = replace(skip(input,i), dst);
            return buffer;
        }

        /// <summary>
        /// Transforms a bijection into a sequence of replacement rules
        /// </summary>
        /// <param name="spec"></param>
        /// <typeparam name="T"></typeparam>
        [Op, Closures(Closure)]
        public static Span<Replace<T>> replacements<T>(in BijectivePoints<T> spec)
            where T : IEquatable<T>
        {
            var src = spec.Source;
            var dst = spec.Target;
            var count = src.Length;
            var buffer = alloc<Replace<T>>(count);
            ref var target = ref first(buffer);
            ref readonly var input = ref src.First;
            ref readonly var output = ref dst.First;
            for(var i=0; i<count; i++)
                seek(target,i) = replace(skip(input,i), skip(output,i));
            return buffer;
        }

        [Op, Closures(Closure)]
        public static Span<Replace<T>> replacements<T>(Index<T> src, Index<T> dst)
            where T : IEquatable<T>
                => replacements(bijection<T>(src,dst));
    }
}