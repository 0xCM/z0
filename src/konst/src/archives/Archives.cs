//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Reflection;
    using System.Text;
    using System.IO;

    using static Konst;
    using static z;

    [ApiHost]
    public readonly partial struct Archives
    {
        [MethodImpl(Inline)]
        static SearchOption option(bool recurse)
            => recurse ? SearchOption.AllDirectories : SearchOption.TopDirectoryOnly;

        [MethodImpl(Inline), Op]
        public static FileKinds filekinds(params Assembly[] src)
            => new FileKinds(src.SelectMany(x => x.Types().Tagged<FileKindAttribute>()));

        [MethodImpl(Inline), Op]
        public static ISemanticPaths semantic()
            => new SemanticPaths();
    }
}