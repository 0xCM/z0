//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    [ApiHost]
    public readonly struct DataHandlers
    {
        [MethodImpl(Inline)]
        public static DataHandler<T> Create<T>(DataReceiver<T> receiver)
            => new DataHandler<T>(receiver);        
    }
}