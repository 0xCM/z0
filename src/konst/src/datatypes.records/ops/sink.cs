//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    partial struct Records
    {
        [MethodImpl(Inline)]
        public static RecordSink<T> sink<T>(Receiver<T> dst)
            where T : struct
                => new RecordSink<T>(dst);
    }
}