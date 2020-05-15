//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Seed;

    public delegate void DataReceiver<T>(T data);

    public class DataHandlers 
    {
        [MethodImpl(Inline)]
        public static DataHandler<T> Create<T>(DataReceiver<T> receiver)
            => DataHandler<T>.Create(receiver);
    }
}