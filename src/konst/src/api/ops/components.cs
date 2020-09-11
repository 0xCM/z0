//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Reflection;

    using static Konst;
    using static z;

    partial struct ApiQuery
    {
        [Op]
        public static Assembly[] components(FS.FilePath[] src,
            [CallerMemberName] string caller = null,
            [CallerFilePath] string file = null,
            [CallerLineNumber] int?  line = null)
                => src.Map(f => component(f, caller, file, line))
                      .Where(x => x.IsSome()).Select(x => x.Value).Where(nonempty);
    }
}