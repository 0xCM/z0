//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using Z0.Data;

    using static Konst;

    partial struct Flow    
    {
        [MethodImpl(Inline)]
        public static DataModel<K> model<K>(string name, K kind)
            where K : unmanaged, Enum
                => new DataModel<K>(name, kind);
    }
}