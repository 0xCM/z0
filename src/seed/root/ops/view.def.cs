//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    partial class Root
    {
        /// <summary>
        /// Presents a readonly S-reference as a readonly T-reference
        /// </summary>
        /// <param name="src">The data soruce</param>
        /// <typeparam name="S">The source type</typeparam>
        /// <typeparam name="T">The target type</typeparam>
        [MethodImpl(Inline)]
        public static ref readonly T view<S,T>(in S src)
            => ref Unsafe.As<S,T>(ref edit(src));        


    }
}