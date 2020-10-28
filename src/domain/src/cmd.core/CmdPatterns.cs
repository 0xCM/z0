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

    [ApiHost(ApiNames.CmdPatterns, true)]
    public readonly struct CmdPatterns
    {
        const string DefaultArgDelimiter = "--";

        const string DefaultCmdType = "exe";

        [Op]
        public static CmdScript<PatternDataCore> init(IFileDb db, string root, string name, string arg, string delimiter = null, string type = null)
        {
            CmdScript<PatternDataCore> cmd = new PatternDataCore();
            ref var data = ref cmd.Content;
            data.CmdRootName = FS.folder(root);
            data.CmdId = name;
            data.CmdArgName = arg;
            data.ArgDelimiter = delimiter ?? DefaultArgDelimiter;
            data.CmdType = FS.ext(type ?? DefaultCmdType);
            rules(db, ref cmd);
            return cmd;
        }

        [Op]
        public static ref CmdScript<PatternDataCore> update(IFileDb db, ref CmdScript<PatternDataCore> cmd, string root = null, string name = null, string arg = null, string delimiter = null, string type = null)
        {
            ref var data = ref cmd.Content;
            data.CmdRootName = root == null ? data.CmdRootName : FS.folder(root);
            data.CmdId = name == null ? data.CmdId : name;
            data.CmdArgName = arg == null ? data.CmdArgName : arg;
            data.ArgDelimiter = delimiter == null ? data.ArgDelimiter : delimiter;
            data.CmdType = type == null ? data.CmdType : FS.ext(type);
            rules(db, ref cmd);
            return ref cmd;
        }

        [Op]
        public static ref CmdScript<PatternDataCore> rules(IFileDb db, ref CmdScript<PatternDataCore> cmd)
        {
            ref var data = ref cmd.Content;
            ref readonly var id = ref data.CmdId;
            data.CmdRoot = db.ToolRoot() +  data.CmdRootName;
            data.CmdName = FS.file(id.Id, data.CmdType);
            data.CmdOutName = FS.file(string.Format("{0}.{1}", id, data.CmdArgName), db.Log);
            data.CmdOutDir = db.ToolOutput(id);
            data.CmdOutPath = data.CmdOutDir + FS.file(id.Id);
            data.CmdArgs = string.Format("{0}{0}", data.ArgDelimiter, data.CmdArgName);
            data.CmdPath = data.CmdRoot + FS.file(id.Id, data.CmdType);
            data.CmdExecSpec = string.Format("{0} {1}", data.CmdPath, data.CmdArgs);
            return ref cmd;
        }

        public struct PatternDataCore : ICmdScript<PatternDataCore>
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
}