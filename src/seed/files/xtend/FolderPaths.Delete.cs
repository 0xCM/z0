//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections.Generic;

    using static Konst;

    partial class XTend
    {
        public static void Delete(this IEnumerable<FolderPath> paths)
            => Control.iter(paths, path => path.Delete(true));            
    }
}