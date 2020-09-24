//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;

    using static Konst;

    [StructLayout(LayoutKind.Sequential)]
    public struct PathSettings
    {
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