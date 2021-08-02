//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Reflection;

    partial struct Root
    {
        [Op]
        public static string name(Assembly src)
            => src.GetName().Name;

        [Op]
        public static string format(PartId src)
            => src.ToString();
    }
}