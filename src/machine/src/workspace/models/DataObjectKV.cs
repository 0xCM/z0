//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.MetaCore
{
    using System;
    using System.Linq;
    using System.Runtime.Serialization;
    using System.Runtime.CompilerServices;
    using System.Reflection;

    using static Konst;
    
    public abstract class DataObject<T,K> : DataObject<T>
        where T : DataObject<T>
    {
        public K Key { get;}

        public DataObject(K key)
            => Key = key;

        public override sealed Option<X> GetKey<X>()
            => (X)(object)Key;
    }
}