//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    public struct ProjectEnvConfig
    {
        public string ProjectKeyword;

        public string ProjectTargetType;

        public string ProjectArea;

        public string ProjectSlnId;

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