//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    partial class FileTypes
    {
        public static string describe<T>(T src)
            where T : struct, IFileType
        {
            var symbols = Symbols.index<FileKind>();
            ref readonly var symbol = ref symbols[src.FileKind];
            return string.Format("{0}: {1}", wildcard(src), symbol.Description);
        }

        public static string wildcard<T>(T src)
            where T : struct, IFileType
                => string.Format("*.{0}", src.FileExt);
    }
}