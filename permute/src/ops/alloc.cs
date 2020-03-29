//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Core;

    partial class Permute
    {
        /// <summary>
        /// Allocates an empty permutation of specified length
        /// </summary>
        [MethodImpl(Inline)]
        public static Perm<T> alloc<T>(int n)
            where T : unmanaged
                => new Perm<T>(new T[n]);

        /// <summary>
        /// Allocates an empty permutation
        /// </summary>
        [MethodImpl(Inline)]
        public static Perm alloc(int n)
            => new Perm(new int[n]);
    }
}