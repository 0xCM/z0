//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    [ApiHost]
    readonly partial struct Datasets
    {
        [MethodImpl(Inline)]
        public static int width<E>(E field)
            where E : unmanaged, Enum
        {
            var w = core.@as<E,uint>(field) >> 16;
            return (int)w;
        }

        [Op]
        internal static string render(object content)
        {
            var rendered = string.Empty;
            if(content is null)
                return Null.Value.Format();
            else if(content is ITextual t)
                return t.Format();
            else
                return content.ToString();
        }
    }
}