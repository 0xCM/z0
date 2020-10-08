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
        public static IPart[] parts(FS.FilePath[] paths,
            [CallerMemberName] string caller = null,
            [CallerFilePath] string file = null,
            [CallerLineNumber] int?  line = null)
                => paths.Select(p => part(p, caller, file, line)).Where(x => x.IsSome()).Select(x => x.Value).OrderBy(x => x.Id);
    }
}