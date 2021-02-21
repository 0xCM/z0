//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    partial struct TextRules
    {
        partial struct Format
        {
            [MethodImpl(Inline), Op, Closures(Closure)]
            public static PropFormat<T> prop<T>(string name, T value)
                => new PropFormat<T>(name, value, RP.PropertyPad);

            [MethodImpl(Inline), Op, Closures(Closure)]
            public static PropFormat<T> prop<T>(string name, T value, sbyte pad)
                => new PropFormat<T>(name, value, pad);
        }
    }
}