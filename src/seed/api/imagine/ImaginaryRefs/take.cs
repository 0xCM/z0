//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    readonly partial struct Imagine
    {
        /// <summary>
        /// Takes a T-cell from an S-cell source
        /// </summary>
        /// <param name="src">The source cell</param>
        /// <param name="dst">The target</param>
        /// <typeparam name="S">The source type</typeparam>
        /// <typeparam name="T">The target type</typeparam>
        [MethodImpl(Inline)]
        public static ref T take<S,T>(in S src, out T dst)   
        {
            dst = edit<S,T>(src);
            return ref dst;
        }
    }
}