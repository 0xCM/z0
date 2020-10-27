//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Text.Json;
    using System.Text.Json.Serialization;

    using static z;
    using static Konst;

    [ApiHost]
    public readonly struct JsonData
    {
        [Op, Closures(AllNumeric)]
        public static Json<string> serialize<T>(T src)
            => JsonSerializer.Serialize(src);
    }
}