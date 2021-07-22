//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using System.IO;

    using static Root;
    using static core;

    [ApiHost]
    public readonly struct ApiPartIdParser
    {
        [Op]
        public static PartId fromFile(string src)
            => single(Path.GetFileName(src).Replace("z0.", EmptyString).Replace(".dll", EmptyString).Replace(".exe", EmptyString));

        [Op]
        public static PartId single(string src)
        {
            ApiParsers.part(src, out var dst);
            return dst;
        }
    }
}