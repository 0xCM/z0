//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    using api = Addresses;

    public interface IAddressBox<T>
        where T : unmanaged, IAddress<T>
    {
        T Base {get;}

        ByteSize Size {get;}

    }

    public readonly struct AddressBox<T> : IAddressBox<T>
        where T : unmanaged, IAddress<T>
    {
        public T Base {get;}

        public ByteSize Size {get;}

        [MethodImpl(Inline)]
        public AddressBox(T @base, ByteSize size)
        {
            Base = @base;
            Size = size;
        }

        [MethodImpl(Inline)]
        public bool Contains(T src)
            => api.contains(this, src);
    }
}