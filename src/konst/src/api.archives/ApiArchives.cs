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
        [MethodImpl(Inline), Op]
        public static PathSettings defaults()
        {
            var dst = new PathSettings();
            defaults(ref dst);
            return dst;
        }

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
        public static IPartCaptureArchive capture(FolderPath root)
            => new PartCaptureArchive(root ?? EnvVars.Common.LogRoot, FolderName.Empty, FolderName.Empty);

        [MethodImpl(Inline), Op]
        public static IPartCaptureArchive capture(FS.FolderPath root)
            => new PartCaptureArchive(root);

        [MethodImpl(Inline), Op]
        public static IPartCaptureArchive capture(PartId part)
            => new PartCaptureArchive(EnvVars.Common.LogRoot, FolderName.Define("capture"), FolderName.Define(part.Format()));

        [MethodImpl(Inline), Op]
        public static IPartCaptureArchive capture(ArchiveConfig config)
            => capture(FS.dir(config.Root.Name));

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