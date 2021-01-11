//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    partial struct ProjectModel
    {
        [Op]
        public static string format(Property src)
            => string.Format("<{0}>{1}</{0}>", src.Name, src.Value);


        [Op, Closures(UnsignedInts)]
        public static string format<T>(Property<T> src)
            => string.Format("<{0}>{1}</{0}>", src.Name, src.Value);
    }
}