//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Seed;

    public readonly struct DataHandler<C,T> : IDataHandler<C,T>
    {
        public static DataHandler<C,T> Empty => new DataHandler<C,T>((c,t) => {});

        readonly DataReceiver<C,T> Receiver;

        [MethodImpl(Inline)]
        public DataHandler(DataReceiver<C,T> receiver)
        {
            Receiver = receiver;
        }

        [MethodImpl(Inline)]
        public void Handle(C context, T data)
            => Receiver(context, data);
    }
}