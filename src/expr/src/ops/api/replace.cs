//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Ops
{
    using System;
    using System.Runtime.CompilerServices;

    using Z0.Rules;

    using static Root;
    using static core;    

    partial struct scalars
    {
        /// <summary>
        /// Transforms a bijection into a sequence of replacement rules
        /// </summary>
        /// <param name="spec"></param>
        /// <typeparam name="T"></typeparam>
        [Op, Closures(Closure)]
        public static Span<Replace<T>> replace<T>(in BijectivePoints<T> spec)
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
                seek(target,i) = Rules.rules.replace(skip(input,i), skip(output,i));
            return buffer;
        }

        [Op, Closures(Closure)]
        public static Span<Replace<T>> replace<T>(Index<T> src, Index<T> dst)
            where T : IEquatable<T>
                => replace(bijection<T>(src,dst));
    }
}