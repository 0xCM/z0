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

    partial struct DataModels
    {
        [MethodImpl(Inline), Op]
        public static DataModel<K> define<K>(string name, K kind)
            where K : unmanaged
                => new DataModel<K>(name,kind);
    }
}