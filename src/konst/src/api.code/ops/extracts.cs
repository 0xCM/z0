//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    partial struct ApiCode
    {
        [Op]
        public static Index<ApiCodeBlock> extracts(FS.FilePath src)
            => from line in src.ReadLines().Select(ApiHexParser.extracts)
                where line.Succeeded
                select line.Value;
    }
}