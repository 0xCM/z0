//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Data
{        
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    public readonly struct DataModel<D> : IDataModel<DataModel<D>, D>
        where D : unmanaged, Enum
    {
        public string Name {get;}
        
        public D Kind {get;}

        [MethodImpl(Inline)]
        public DataModel(string name, D kind)
        {
            Name = name;
            Kind = kind;
        }    
    }
}