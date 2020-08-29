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

    partial struct AB
    {
        [MethodImpl(Inline), Op]
        public static WfCaller caller(PartId part, [CallerMemberName] string caller = null, [CallerFilePath]string file = null, [CallerLineNumber] int? line = null)
            => new WfCaller(part, caller, FS.path(file), line ?? 0);

        [MethodImpl(Inline), Op]
        public static PartId[] parts(string[] args, PartId[] fallback)
            => PartIdParser.parse(args,fallback);
    }
}