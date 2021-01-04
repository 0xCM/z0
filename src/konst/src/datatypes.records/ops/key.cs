//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    partial struct Records
    {
        [MethodImpl(Inline)]
        public static RowKey<I,T> key<I,T>(T row, I value)
            where T : struct, IRecord<T>
            where I : unmanaged
                => new RowKey<I,T>(value);
    }
}