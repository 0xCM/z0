//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    public readonly struct ApiFiles
    {
        public static FS.FileName filename(ApiHostUri host, FS.FileExt ext)
            => FS.file(text.concat(host.Owner.Format(), Chars.Dot, host.Name), ext);

        public static FS.FileName filename(ApiHostUri host, FS.FileExt a, FS.FileExt b)
            => FS.file(text.concat(host.Owner.Format(), Chars.Dot, host.Name, a), b);
    }
}