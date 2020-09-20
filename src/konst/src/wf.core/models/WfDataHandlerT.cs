//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    public readonly struct WfDataHandler<T> : IDataHandler<T>
    {
        readonly DataReceiver<T> Receiver;

        [MethodImpl(Inline)]
        public WfDataHandler(DataReceiver<T> receiver)
        {
            Receiver = receiver;
        }

        [MethodImpl(Inline)]
        public void Handle(T data)
            => Receiver(data);

        public static WfDataHandler<T> Empty
            => new WfDataHandler<T>(t => {});
    }
}