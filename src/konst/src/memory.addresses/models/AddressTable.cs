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

    public class AddressTable<K,V> : Dictionary<K,V>
        where K : unmanaged, IAddress
    {

    }

    public class AddressTable8<V> : AddressTable<Address8,V>
    {

    }

    public class AddressTable16<V> : AddressTable<Address16,V>
    {

    }

    public class AddressTable32<V> : AddressTable<Address32,V>
    {

    }

    public class AddressTable64<V> : AddressTable<Address64,V>
    {

    }

    public class AddressTable<V> : AddressTable<MemoryAddress,V>
    {

    }

}