//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.InteropServices;
    using System.Runtime.CompilerServices;
        
    using static Konst;

    public readonly struct Casts
    {

        [MethodImpl(Inline)]
        public static ref T cast<S,T>(ref S src)
            => ref Unsafe.As<S,T>(ref src);

        /// <summary>
        /// Reinterprents a source value through the perpective of another type
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="dst">The target value</param>
        /// <typeparam name="S">The source type</typeparam>
        /// <typeparam name="T">The target type</typeparam>
        [MethodImpl(Inline)]
        public static ref T cast<S,T>(ref S src, out T dst)
        {
            dst = Unsafe.As<S,T>(ref src);
            return ref dst;
        }
    }
}