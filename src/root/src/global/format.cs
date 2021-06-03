//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Reflection;

    partial struct Root
    {
        [Op]
        public static string name(Assembly src)
            => src.GetName().Name;

        [Op]
        public static string format(PartId src)
        {
            var baseId = @base(src);
            var dst = baseId.ToString().ToLower();
            if(isTest(src))
                return dst + TestSuffix;
            else if(isSvc(src))
                return dst + SvcSuffix;
            else
                return dst + BaseSuffix;
        }

        [Op]
        public static string format(PartId src, byte pad)
            => string.Format("{0,-" + pad.ToString() + "}", format(src));
    }
}