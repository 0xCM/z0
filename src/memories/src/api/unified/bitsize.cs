//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Seed;

    partial class Memories
    {
        [MethodImpl(Inline)]
        public static int bitsize<T>()            
            => Control.bitsize<T>();

        [MethodImpl(Inline)]
        public static int bitsize<T>(T rep)            
            => Control.bitsize<T>(rep);

    }
}