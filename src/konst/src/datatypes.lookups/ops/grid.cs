//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Collections.Generic;
    using System.Linq;

    using static Part;
    using static memory;

    partial struct Lookups
    {
        [Op, Closures(UInt8k)]
        public static LookupGrid<byte,byte,byte,T> grid<T>(W8 ixj)
            => new LookupGrid<byte,byte,byte,T>(new byte[256,256], new T[256*256]);
    }
}