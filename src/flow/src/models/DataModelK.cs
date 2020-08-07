//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Data
{        
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    public readonly struct DataModel<K> : IDataModel<DataModel<K>, K>
        where K : unmanaged, Enum
    {
        public readonly StringRef Name;
        
        public readonly K Kind;

        [MethodImpl(Inline)]
        public DataModel(string name, K kind)
        {
            Name = name;
            Kind = kind;
        }

        K IDataModel<DataModel<K>, K>.Kind 
            => Kind;
    }
}