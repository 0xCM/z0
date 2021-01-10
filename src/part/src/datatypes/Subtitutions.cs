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

    [ApiHost]
    public readonly struct Substitutions
    {
        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static Substitution<T> define<T>(T replace, T replacement)
            => new Substitution<T>(replace, replacement);

        [Op, Closures(UnsignedInts)]
        public static Substitutions<T> define<T>(Substitution<T>[] src)
        {
            var count = (uint)src.Length;
            var sources = alloc<T>(count);
            var targets = alloc<T>(count);

            ref var input = ref first(src);
            ref var s = ref first(sources);
            ref var t = ref first(targets);

            for(var i=0; i<count; i++)
            {
                input = ref seek(input, i);
                s = ref seek(s,i);
                t = ref seek(t,i);
                s = input.Replace;
                t = input.Replacement;
            }

            return new Substitutions<T>(count, sources, targets);
        }
    }
}