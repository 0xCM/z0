//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    /// <summary>
    /// Defines a pattern for creating a <see cref='Z0.CmdExecSpec'/>
    /// </summary>
    public struct CmdScriptPattern : ICmdScriptPattern<CmdScriptPattern>
    {
        public FS.FolderName CmdRootName;

        public ToolId CmdHost;

        public string CmdArgName;

        public CmdArgPrefix ArgPrefix;

        public FS.FileExt ScriptType;

        public FS.FileName CmdName;

        public string ToolArgs;

        public FS.FolderPath CmdOutDir;

        public FS.FileName CmdOutName;

        public FS.FilePath CmdOutPath;

        public FS.FolderPath CmdRoot;

        public FS.FilePath CmdPath;

        public string CmdExecSpec;

        [MethodImpl(Inline)]
        public string Format()
            => CmdExecSpec;

        public override string ToString()
            => Format();

        ToolId ICmdScriptPattern.CmdHost
            => CmdHost;
    }
}