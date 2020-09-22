//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    [ApiHost]
    public readonly struct ApiArchives
    {
        [MethodImpl(Inline), Op]
        public static X86UriHexArchive x86(IWfShell wf)
            => new X86UriHexArchive(wf);

        [MethodImpl(Inline), Op]
        public static X86UriHexArchive x86(FS.FolderPath root)
            => new X86UriHexArchive(root);

        [MethodImpl(Inline), Op]
        public static ApiHex[] x86_data(IWfShell wf, ApiHostUri host)
            => x86(wf).Read(host);
    }
}