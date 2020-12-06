//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    partial class XText
    {
        /// <summary>
        /// Applies a function to a value
        /// </summary>
        /// <param name="x">The source value</param>
        /// <param name="f">The function to apply</param>
        /// <typeparam name="X">The source value type</typeparam>
        /// <typeparam name="Y">The output value type</typeparam>
         [MethodImpl(Inline)]
         static Y apply<X,Y>(X x, Func<X,Y> f)
            => f(x);

        /// <summary>
        /// Extracts content demarcated by left/right character boundaries
        /// </summary>
        /// <param name="src">The source text</param>
        /// <param name="left">The left marker</param>
        /// <param name="right">THe right marker</param>
        [TextUtility]
        public static string Unfence(this string src, char left, char right)
            => src.RightOfFirst(left).LeftOfLast(right);
    }
}