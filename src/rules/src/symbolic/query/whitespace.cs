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

    using C = AsciCode;

    partial struct SymbolicQuery
    {
        /// <summary>
        /// Determines whether an asci code defines a whitespace character
        /// </summary>
        /// <param name="src">The value to test</param>
        [MethodImpl(Inline), Op]
        public static bit whitespace(C c)
            => space(c) || tab(c) || cr(c) || lf(c) || vtab(c);

        /// <summary>
        /// Determines whether an asci code defines a whitespace character
        /// </summary>
        /// <param name="src">The value to test</param>
        [MethodImpl(Inline), Op]
        public static bit whitespace(char c)
            => space(c) || tab(c) || cr(c) || lf(c) || vtab(c);

        /// <summary>
        /// Returns true if only whitspace chacters are present
        /// </summary>
        /// <param name="src"></param>
        [MethodImpl(Inline), Op]
        public static bit whitespace(ReadOnlySpan<C> src)
        {
            var count = src.Length;
            for(var i=0; i<count; i++)
            {
                if(!whitespace(skip(src,i)))
                    return false;
            }
            return true;
        }
    }
}