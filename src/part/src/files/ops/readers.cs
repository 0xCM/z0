//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.IO;

    using static Root;
    using static core;

    partial struct FS
    {
        public static AsciLineReader AsciLineReader(FS.FilePath src)
            => new AsciLineReader(src.AsciReader());

        public static UnicodeLineReader UnicodeLineReader(FS.FilePath src)
            => new UnicodeLineReader(src.UnicodeReader());

        public static LineReader Utf8LineReader(FS.FilePath src)
            => new LineReader(src.Utf8Reader());
    }
}