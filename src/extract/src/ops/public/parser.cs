//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    partial struct ApiExtracts
    {
        [Op]
        public static PatternExtractParser parser()
            => new PatternExtractParser(buffer());


        [MethodImpl(Inline), Op]
        public static PatternExtractParser parser(byte[] buffer)
            => new PatternExtractParser(buffer);
    }
}