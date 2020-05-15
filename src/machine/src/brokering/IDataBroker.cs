//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Seed;

    public interface IDataBroker
    {
        void Relay<E,T>(E kind, T data)
            where E : unmanaged, Enum;
    }

    public interface IDataBroker<E,T>
        where E : unmanaged, Enum
    {
        DataHandler<T> Get(E kind);

        void Set(E kind, DataHandler<T> handler);

        void Relay(E kind, T data);

        DataHandler<T> this[E kind]
        {
            [MethodImpl(Inline)]
            get => Get(kind);

            [MethodImpl(Inline)]
            set => Set(kind,value);
        }        
    }
}