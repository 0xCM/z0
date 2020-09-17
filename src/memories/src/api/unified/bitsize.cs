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
        public static int bitwidth<T>()
            => (int)z.bitwidth<T>();

        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public static BitSize bitwidth<T>(T rep)
            => z.bitwidth<T>();
    }
}