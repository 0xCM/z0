//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    public struct PathSettings
    {
        [MethodImpl(Inline)]
        public static PathSettings create()
        {
            var settings = new PathSettings();
            settings.Logs = new PathSetting(nameof(Logs), "j:/dev/projects/z0-logs");
            settings.Dev =  new PathSetting(nameof(Dev), "j:/dev/projects/z0");
            settings.Archives =  new PathSetting(nameof(Archives), "k:/z0/archives");
            settings.Tools =  new PathSetting(nameof(Tools), "j:/tools");
            settings.BuildStage =  new PathSetting(nameof(BuildStage), "j:/dev/projects/z0-logs/builds");
            settings.ResStage =  new PathSetting(nameof(ResStage), "j:/dev/projects/z0-logs/res");
            settings.ResPub =  new PathSetting(nameof(ResPub), "k:/z0/archives/res");
            settings.BuildPub =  new PathSetting(nameof(BuildPub), "k:/builds");
            return settings;
        }

        public PathSetting Logs;

        public PathSetting Dev;

        public PathSetting Archives;

        public PathSetting Tools;

        public PathSetting BuildStage;

        public PathSetting ResStage;

        public PathSetting ResPub;

        public PathSetting BuildPub;
    }
}