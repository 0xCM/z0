//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Collections.Generic;

    using static Part;

    partial struct root
    {
        [Op, Closures(Closure)]
        public static DataList<T> datalist<T>(uint? capacity = null)
            => DataList.create<T>(capacity);
    }
}