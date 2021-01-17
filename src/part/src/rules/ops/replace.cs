//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;
    using static memory;

    partial struct Rules
    {
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static Replacement<T> replace<T>(T src, T dst)
            where T : IEquatable<T>
                => new Replacement<T>(src,dst);

        public static Replacements<T> replace<T>(T[] src, T dst)
            where T : IEquatable<T>
        {
            var count = src.Length;
            var buffer = sys.alloc<Replacement<T>>(count);
            ref var target = ref first(buffer);
            ref readonly var input = ref first(src);
            for(var i=0; i<count; i++)
                seek(target,i) = replace(skip(input,i), dst);
            return buffer;
        }

        [Op, Closures(Closure)]
        public static Replacements<T> replace<T>(Bijection<T> spec)
            where T : IEquatable<T>
        {
            var src = spec.Source.View;
            var dst = spec.Target.View;
            root.require(src.Length == dst.Length, () => "Same lengths there must me");
            var count = src.Length;
            var buffer = sys.alloc<Replacement<T>>(count);
            ref var target = ref first(buffer);
            ref readonly var input = ref first(src);
            ref readonly var output = ref first(dst);
            for(var i=0; i<count; i++)
                seek(target,i) = replace(skip(input,i), skip(output,i));
            return buffer;
        }

        [Op, Closures(Closure)]
        public static Replacements<T> replace<T>(Index<T> src, Index<T> dst)
            where T : IEquatable<T>
                => replace(bijection<T>(src,dst));
    }
}