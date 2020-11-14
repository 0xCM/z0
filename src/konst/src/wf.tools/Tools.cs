//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static z;

    [ApiHost("tooling", true)]
    public partial struct Tooling
    {
        const NumericKind Closure = UnsignedInts;

        [MethodImpl(Inline), Op]
        public static IToolDb db(FS.FolderPath storage)
            => new ToolDb(storage);

        [MethodImpl(Inline)]
        public static ToolTarget<T,F> target<T,F>(F kind, FS.FilePath path)
            where T : struct, ITool<T>
            where F : unmanaged
                => new ToolTarget<T,F>(kind, path);

        [MethodImpl(Inline)]
        public static ToolTarget<T> target<T>(FS.FilePath path)
            where T : struct, ITool<T>
                => new ToolTarget<T>(path);
    }
}