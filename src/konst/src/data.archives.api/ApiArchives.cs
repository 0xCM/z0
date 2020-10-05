//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Collections.Generic;
    using System.Linq;

    using static Konst;
    using static z;

    public readonly struct ApiArchives
    {
        /// <summary>
        /// Creates an archive over the output of a build
        /// </summary>
        /// <param name="root">The archive root</param>
        [MethodImpl(Inline), Op]
        public static IBuildArchive build(ArchiveConfig root)
            => new BuildArchive(root);

        /// <summary>
        /// Creates an archive over both managed and unmanaged modules
        /// </summary>
        /// <param name="root">The archive root</param>
        [MethodImpl(Inline), Op]
        public static IModuleArchive modules(ArchiveConfig config)
            => new ModuleArchive(config);

        /// <summary>
        /// Creates an archive over a set of capture artifacts
        /// </summary>
        /// <param name="root">The archive root</param>
        [MethodImpl(Inline), Op]
        public static ICaptureArchive capture(FS.FolderPath root)
            => new CaptureArchive(root);

        /// <summary>
        /// Creates an archive over a set of capture artifacts
        /// </summary>
        /// <param name="root">The archive configuration</param>
        [MethodImpl(Inline), Op]
        public static ICaptureArchive capture(ArchiveConfig config)
            => capture(config.Root);

        [Op]
        public static PartFiles partfiles(FS.FolderPath root)
        {
            var src = ApiArchives.capture(FolderPath.Define(root.Name));
            var parsed = src.ParsePaths.Select(x => FS.path(x.Name));
            var hex = src.HexPaths.Select(x => FS.path(x.Name));
            var asm = src.AsmPaths.Select(x => FS.path(x.Name));
            return new PartFiles(root, parsed, hex, asm);
        }

        [MethodImpl(Inline), Op]
        public static ref PathSettings defaults(ref PathSettings dst)
        {
            dst.Logs = new PathSetting(nameof(PathSettings.Logs), "j:/dev/projects/z0-logs");
            dst.Dev =  new PathSetting(nameof(PathSettings.Dev), "j:/dev/projects/z0");
            dst.Archives =  new PathSetting(nameof(PathSettings.Archives), "k:/z0/archives");
            dst.Tools =  new PathSetting(nameof(PathSettings.Tools), "j:/tools");
            dst.BuildStage =  new PathSetting(nameof(PathSettings.BuildStage), "j:/dev/projects/z0-logs/builds");
            dst.ResStage =  new PathSetting(nameof(PathSettings.ResStage), "j:/dev/projects/z0-logs/res");
            dst.ResPub =  new PathSetting(nameof(PathSettings.ResPub), "k:/z0/archives/res");
            dst.BuildPub =  new PathSetting(nameof(PathSettings.BuildPub), "k:/builds");
            return ref dst;
        }

        [MethodImpl(Inline), Op]
        public static ICaptureArchive capture(FolderPath root)
            => new CaptureArchive(FS.dir(root.Name));

        [MethodImpl(Inline), Op]
        public static ICaptureArchive capture(FS.FolderPath root, PartId part)
            => new CaptureArchive(root + FS.folder(part.Format()));


        [MethodImpl(Inline), Op]
        public static ApiHostCodeIndex index(ApiHostUri host, ApiCodeBlock[] code)
            => new ApiHostCodeIndex(host,code);

        public static Dictionary<PartId,PartFile[]> index(PartFileClass kind, PartFiles src, params PartId[] parts)
        {
            switch(kind)
            {
                case PartFileClass.Parsed:
                    return select(PartFileClass.Parsed, src.Parsed, parts);
                default:
                    return dict<PartId,PartFile[]>();
            }
        }

        static Dictionary<PartId,PartFile[]> select(PartFileClass kind, FS.Files src, PartId[] parts)
        {
            var partSet = parts.ToHashSet();
            var files = (from f in src
                        let part = f.Owner
                        where part != PartId.None && partSet.Contains(part)
                        let pf = new PartFile(part, kind, f)
                        group pf by pf.Part).ToDictionary(x => x.Key, y => y.ToArray());
            return files;
        }
    }
}