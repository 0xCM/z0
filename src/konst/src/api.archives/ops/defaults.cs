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

    partial struct ApiArchives
    {
        [MethodImpl(Inline), Op]
        public static PathSettings defaults()
        {
            var dst = new PathSettings();
            defaults(ref dst);
            return dst;
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
    }
}