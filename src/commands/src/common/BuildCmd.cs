//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    /// <summary>
    /// https://docs.microsoft.com/en-us/visualstudio/msbuild/msbuild-command-line-reference?view=vs-2019
    /// </summary>
    public enum BuildLogVerbosity
    {
        normal,

        quiet,

        minimial,

        detailed,

        diagnostic
    }

    public struct BuildCmdVars
    {
        public string ProjectId;

        public string SlnId;
    }

    [Cmd(CmdName)]
    public struct BuildCmd : ICmdSpec<BuildCmd>
    {
        public const string CmdName = "build";

        public FS.FilePath SolutionPath;

        public FS.FilePath ProjectPath;

        public FS.FilePath LogFile;

        public string Configuration;

        public string Platform;

        public BuildLogVerbosity Verbosity;

        public byte MaxCpuCount;

        public bool Graph;
    }
}