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

    /// <summary>
    /// Defines a pattern for creating a <see cref='ToolExecSpec'/>
    /// </summary>
    public struct CmdScriptPattern : ICmdScriptPattern<CmdScriptPattern>
    {
        public FS.FolderName CmdRootName;

        public CmdHostId CmdHost;

        public string CmdArgName;

        public string ArgDelimiter;

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

        CmdHostId ICmdScriptPattern.CmdHost
            => CmdHost;
    }
}