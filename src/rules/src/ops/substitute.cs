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
        /// <summary>
        /// Defines a <see cref='Substitution{T}'/>
        /// </summary>
        /// <param name="replace">The value to replace</param>
        /// <param name="replacement">The replacement value</param>
        /// <typeparam name="T">The data type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static Substitution<T> substitute<T>(T replace, T replacement)
            => new Substitution<T>(replace, replacement);

        /// <summary>
        /// Defines a <see cref='Substitution{T}' set
        /// </summary>
        /// <param name="src"></param>
        /// <typeparam name="T">The data type</typeparam>
        [Op, Closures(Closure)]
        public static Substitutions<T> substitutions<T>(Index<Substitution<T>> src)
        {
            var count = (uint)src.Length;
            var sources = alloc<T>(count);
            var targets = alloc<T>(count);

            ref var input = ref src.First;
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