//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    partial struct DataBlocks
    {
        public struct Block01<T>
            where T : unmanaged
        {
            T Data;
        }
    }
}