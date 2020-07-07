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
        [MethodImpl(Inline)]
        public static T cast<T>(object src)
            => (T)src;

        [MethodImpl(Inline)]
        public static ref T cast<S,T>(in S src)
            => ref core.cast<S,T>(src);            
    }
}