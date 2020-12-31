//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Reflection;

    public struct WfConfig
    {
        public Name Controller;

        public FS.FilePath ConfigPath;

        public FS.FolderPath DbRoot;

        public FS.FolderPath RuntimeRoot;

        public Index<ClrAssemblyName> Components;

        public CmdArgs Args;
    }
}