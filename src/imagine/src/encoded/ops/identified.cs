//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Linq;

    using static Konst;

    partial struct Encoded
    {
        /// <summary>
        /// Defines uri bits with a potentially bad uri (for diagnostic purposes)
        /// </summary>
        /// <param name="perhaps">The uri, perhaps</param>
        /// <param name="src">The source code</param>
        [MethodImpl(Inline), Op]
        public static IdentifiedCode identified(ParseResult<OpUri> perhaps, BinaryCode src)
            => perhaps.MapValueOrSource(
                    uri => new IdentifiedCode(uri,src), 
                    baduri => new IdentifiedCode(baduri, src)
                    );
    }
}