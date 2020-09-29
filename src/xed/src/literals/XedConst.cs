//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Xed
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Collections.Generic;

    public class XedConst
    {
        [Op]
        public static string Name(xed_extension_enum_t src)
            => src.ToString().Remove("XED_EXTENSION_");

        [Op]
        public static string Name(xed_category_enum_t src)
            => src.ToString().Remove("XED_CATEGORY_");
    }
}