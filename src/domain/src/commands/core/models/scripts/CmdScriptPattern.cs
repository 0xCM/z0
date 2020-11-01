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

    public struct CmdScriptPattern : ICmdScript<CmdScriptPattern>
    {
        public FS.FolderName CmdRootName;

        public CmdToolId CmdId;

        public string CmdArgName;

        public string ArgDelimiter;

        public FS.FileExt CmdType;

        public FS.FileName CmdName;

        public string CmdArgs;

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

        CmdToolId ICmdScript.CmdId
            => CmdId;
    }
}