//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Collections.Generic;
    using System.Reflection;

    using static Konst;
    using static z;

    partial struct Archives
    {
        [MethodImpl(Inline), Op]
        public static FileKindList kinds(params Assembly[] src)
            => new FileKindList(src.SelectMany(x => x.Types().Tagged<FileKindAttribute>()));
    }
}