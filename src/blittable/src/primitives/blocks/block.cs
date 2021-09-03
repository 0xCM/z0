//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;
    using static core;

    partial struct Blit
    {
        public struct block<T> : IBlock<T>
            where T : unmanaged, IDataBlock<T>
        {
            public T Storage;
            T IBlock<T>.Storage
                => Storage;
        }
    }
}