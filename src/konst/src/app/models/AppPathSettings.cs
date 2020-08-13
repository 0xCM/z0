//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    public struct AppPathSettings
    {        
        [MethodImpl(Inline)]
        public static AppPathSettings create()
        {
            var settings = new AppPathSettings();
            settings.Logs = new AppPathSetting(nameof(Logs), "j:/dev/projects/z0-logs");
            settings.Dev =  new AppPathSetting(nameof(Dev), "j:/dev/projects/z0");
            settings.Archives =  new AppPathSetting(nameof(Archives), "k:/z0/archives");
            settings.Tools =  new AppPathSetting(nameof(Tools), "j:/tools");
            settings.BuildStage =  new AppPathSetting(nameof(BuildStage), "j:/dev/projects/z0-logs/builds");
            settings.ResStage =  new AppPathSetting(nameof(ResStage), "j:/dev/projects/z0-logs/res");
            settings.ResPub =  new AppPathSetting(nameof(ResPub), "k:/z0/archives/res");
            settings.BuildPub =  new AppPathSetting(nameof(BuildPub), "k:/builds");
            return settings;
        }
        
        public AppPathSetting Logs;

        public AppPathSetting Dev;

        public AppPathSetting Archives;

        public AppPathSetting Tools;

        public AppPathSetting BuildStage;

        public AppPathSetting ResStage;

        public AppPathSetting ResPub;

        public AppPathSetting BuildPub;
    }
}