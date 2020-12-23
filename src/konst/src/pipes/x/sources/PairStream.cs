//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{

    partial class XSource
    {
        public static Deferred<Pair<T>> PairStream<T>(this IDataSource src)
            where T : struct
                => Seq.defer(Sources.pairstream<T>(src));
    }
}