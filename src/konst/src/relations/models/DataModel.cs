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

    public readonly struct DataModel<K> : IDataModel<DataModel<K>, K>
        where K : unmanaged
    {
        public utf8 Name {get;}

        public K Kind {get;}

        [MethodImpl(Inline)]
        public DataModel(string name, K kind)
        {
            Name = name;
            Kind = kind;
        }

        [MethodImpl(Inline)]
        public DataModel(utf8 name, K kind)
        {
            Name = name;
            Kind = kind;
        }
    }
}