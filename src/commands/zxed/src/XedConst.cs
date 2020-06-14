//-----------------------------------------------------------------------------
// Copyright   : (c) 2019 Intel Corporation
// Copyright   : (c) Chris Moore, 2020
// License     : Apache
//-----------------------------------------------------------------------------
namespace Z0.Xed
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Collections.Generic;

    public class XedConst
    {
        public static string Name(xed_extension_enum_t src)
            => src.ToString().Remove("XED_EXTENSION_");
        
        public static string Name(xed_category_enum_t src)
            => src.ToString().Remove("XED_CATEGORY_");

        public static string Name(xed_flag_enum_t src)
            => src.ToString().Remove("XED_FLAG_");

        public static string Name(xed_iclass_enum_t src)
            => src.ToString().Remove("XED_ICLASS_");

    }
}