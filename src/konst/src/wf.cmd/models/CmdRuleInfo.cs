//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    public struct CmdRuleInfo : ITextual
    {
        public FS.FolderName CmdRootName;

        public ToolId CmdHost;

        public Name CmdArgName;

        public ArgPrefix ArgPrefix;

        public FS.FileExt ScriptType;

        public FS.FileName CmdName;

        public TextBlock ToolArgs;

        public FS.FolderPath CmdOutDir;

        public FS.FileName CmdOutName;

        public FS.FilePath CmdOutPath;

        public FS.FolderPath CmdRoot;

        public FS.FilePath CmdPath;

        public TextBlock CmdExecSpec;

        [MethodImpl(Inline)]
        public string Format()
            => CmdExecSpec;

        public override string ToString()
            => Format();
    }
}