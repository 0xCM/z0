//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    public readonly partial struct DataBlocks
    {
        public struct Block01<T>
            where T : unmanaged
        {
            public T Cell0;

            [MethodImpl(Inline)]
            public Block01(T c0)
            {
                Cell0 = c0;
            }
        }
    }
}