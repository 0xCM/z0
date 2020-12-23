//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Collections.Generic;

    using static z;

    partial struct Sources
    {
        /// <summary>
        /// Creates a deferral over a specified value source
        /// </summary>
        /// <param name="source">The value source</param>
        [Op]
        public static Deferred<byte> bytes(IDataSource source)
            => Seq.defer(stream(w8, source));

        [Op]
        static IEnumerable<byte> stream(W8 w, IDataSource source)
        {
            while(true)
            {
                var u64 = source.Next<ulong>();
                for(byte i=0; i<8; i++)
                    yield return @byte(u64,i);
            }
        }
    }
}