//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    partial struct Parsers
    {
        [Op]
        public static ParseFunctions index(params IParseFunction[] src)
            => new ParseFunctions(src);
    }
}