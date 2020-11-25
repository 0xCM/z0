//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    partial struct Projects
    {
        public enum BuildTargetKind : byte
        {
            None,

            Exe,

            Library
        }

        public enum ProjectKind
        {
            None,

            Cs
        }

        public readonly struct RuntimeIdentifier
        {
            public string Moniker {get;}
            public RuntimeIdentifier(string moniker)
            {
                Moniker = moniker;
            }
        }

        public struct ProjectEnvSettings
        {
            public string SlnId;

            public string ProjectArea;

            public string ProjectKeyword;

            public BuildTargetKind TargetType;

            public string ProjectType;

            public string ProjectRuntimeId;

            public string ProjectConfigName;

            public string ProjectFramework;

            public FS.FolderPath SlnRoot;

            public FS.FolderPath SlnBuildRoot;

            public string ProjectId;

            public FS.FileName ProjectFile;

            public FS.FilePath ProjectPath;

            public FS.FileName ProjectTargetName;

            public FS.FolderPath ProjectBinDir;

            public FS.FolderPath ProjectObjDir;

            public FS.FilePath ProjectTargetPath;
        }
    }
}