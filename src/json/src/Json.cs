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
    public readonly struct JsonFx
    {
        [MethodImpl(Inline), Op]
        public static JsonText json(string src)
            => new JsonText(src);
    }
}