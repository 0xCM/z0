//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static z;

    partial struct StorageBlocks
    {
        [MethodImpl(Inline)]
        public static string format<T>(in T src)
            where T : unmanaged, ICharBlock<T>
                => cover(@as<T,char>(src), size<T>()/2).ToString();
    }
}