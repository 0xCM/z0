//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    [ApiHost(ApiNames.WfArchives, true)]
    public readonly struct WfArchives
    {
        [MethodImpl(Inline)]
        public static IApiHexReader hexreader<H>(H rep = default)
            where H : struct, IArchiveReader
        {
            if(typeof(H) == typeof(ApiHexReader))
                return new ApiHexReader();
            else
                throw no<H>();
        }

        [MethodImpl(Inline)]
        public static ApiHexWriter hexwriter<H>(FS.FilePath dst, H rep = default)
            where H : struct, IArchiveWriter<H>
        {
            if(typeof(H) == typeof(ApiHexWriter))
                return new ApiHexWriter(dst);
            else
                throw no<H>();
        }

        [MethodImpl(Inline), Op]
        public static ApiHexArchive hex(IWfShell wf)
            => new ApiHexArchive(wf);

        [MethodImpl(Inline), Op]
        public static ApiHexArchive hex(FS.FolderPath root)
            => new ApiHexArchive(root);

        /// <summary>
        /// Creates a <see cref='ICaptureArchive'/> rooted at a specified path
        /// </summary>
        /// <param name="root">The archive root</param>
        [MethodImpl(Inline), Op]
        public static ICaptureArchive capture(FS.FolderPath root)
            => new CaptureArchive(root);

        /// <summary>
        /// Creates a <see cref='ICaptureArchive'/> rooted at a specified path and specialized for an identified <see cref='PartId'/>
        /// </summary>
        /// <param name="root">The archive root</param>
        [MethodImpl(Inline), Op]
        public static ICaptureArchive capture(FS.FolderPath root, PartId part)
            => new CaptureArchive(root + FS.folder(part.Format()));

        [MethodImpl(Inline), Op]
        public static IHostCaptureArchive capture(FS.FolderPath root, ApiHostUri host)
            => new HostCaptureArchive(root, host);
    }
}