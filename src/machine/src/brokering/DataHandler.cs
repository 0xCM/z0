//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Seed;

    public readonly struct DataHandler<T> : IDataHandler<T>
    {
        public static DataHandler<T> Empty => new DataHandler<T>(t => {});

        readonly DataReceiver<T> Receiver;

        [MethodImpl(Inline)]
        public static DataHandler<T> Create(DataReceiver<T> receiver)
            => new DataHandler<T>(receiver);        

        [MethodImpl(Inline)]
        DataHandler(DataReceiver<T> receiver)
        {
            Receiver = receiver;
        }

        [MethodImpl(Inline)]
        public void Handle(T data)
            => Receiver(data);
    }
}