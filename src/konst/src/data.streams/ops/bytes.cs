//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Collections.Generic;

    using static Konst;
    using static z;

    partial struct Sourced
    {
        /// <summary>
        /// Produces stream of bytes
        /// </summary>
        /// <param name="source">The random source</param>
        [Op]
        public static Source<byte> bytes(IValueSource source)
            => z.seq(stream(w8, source));

        [Op]
        static IEnumerable<byte> stream(W8 w, IValueSource source)
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