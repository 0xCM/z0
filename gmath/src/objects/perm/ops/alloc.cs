//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.InteropServices;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;

    using static zfunc;    

    partial class Perm
    {

        /// <summary>
        /// Allocates an empty permutation of specified length
        /// </summary>
        [MethodImpl(Inline)]
        public static PermSpec<T> alloc<T>(int n)
            where T : unmanaged
                => new PermSpec<T>(new T[n]);

        /// <summary>
        /// Allocates an empty permutation
        /// </summary>
        [MethodImpl(Inline)]
        public static PermSpec alloc(int n)
            => new PermSpec(new int[n]);
    }
}