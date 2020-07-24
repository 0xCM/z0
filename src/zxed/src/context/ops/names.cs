//-----------------------------------------------------------------------------
// Copyright   : (c) 2019 Intel Corporation
// Copyright   : (c) Chris Moore, 2020
// License     : Apache
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    
    using static Konst;

    using Xed;

    partial struct XedContext
    {
        [MethodImpl(Inline), Op]
        public static EnumNames names(Type src)                   
            => new EnumNames(src, System.Enum.GetNames(src));
    }
}