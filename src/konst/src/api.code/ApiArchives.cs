//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    public readonly struct ApiArchives
    {
        [Op]
        public static IApiPathProvider paths(IWfShell wf)
            => ApiPathProvider.create(wf);

        [MethodImpl(Inline), Op]
        public static ApiHexArchive hex(IWfShell wf)
            => new ApiHexArchive(wf);

        [MethodImpl(Inline), Op]
        public static ApiHexArchive hex(IWfShell wf, FS.FolderPath root)
            => new ApiHexArchive(wf, root);

        /// <summary>
        /// Creates a <see cref='ICaptureArchive'/> rooted at a specified path
        /// </summary>
        /// <param name="root">The archive root</param>
        [MethodImpl(Inline), Op]
        public static ICaptureArchive capture(FS.FolderPath root)
            => new CaptureArchive(root);

        [MethodImpl(Inline), Op]
        public static IHostCaptureArchive host(FS.FolderPath root, ApiHostUri uri)
            => new HostCaptureArchive(root, uri);
    }
}