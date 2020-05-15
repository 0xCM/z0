//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Seed;
    using static Memories;

    public class DataBrokers
    {
        public static DataBroker<E,T> Create<E,T>(int capacity, IndexFunction<E> @if = null)
            where E : unmanaged, Enum
                => new DataBroker<E,T>(capacity, @if ?? Enums.i32);

        [MethodImpl(Inline)]
        public static DataBroker64<E,T> Create64<E,T>()
            where E : unmanaged, Enum
                => DataBroker64<E,T>.Alloc();

    }
}