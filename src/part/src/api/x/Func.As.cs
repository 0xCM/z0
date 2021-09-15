//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    partial class XApi
    {
        [MethodImpl(Inline)]
        public static BinaryOperatorClass<T> As<T>(this BinaryOperatorClass src)
             where T : unmanaged => default;

        public static string Format<K>(this K src)
            where K : IApiClass
                => ApiClasses.format(src);
    }
}