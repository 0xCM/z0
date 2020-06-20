//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    partial class Memories
    {
        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public static int bitsize<T>()            
            => Root.bitsize<T>();

        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public static int bitsize<T>(T rep)            
            => Root.bitsize<T>(rep);

    }
}