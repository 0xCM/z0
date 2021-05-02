//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;
    using static memory;

    readonly partial struct CharBlocks
    {
        public static string format<T>(in T src)
            where T : unmanaged, ICharBlock<T>
                => cover(@as<T,char>(src), size<T>()/2).ToString().Trim();
    }
}