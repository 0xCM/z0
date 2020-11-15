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

    partial struct Tooling
    {
        [Op]
        public static ref ToolCmd<ToolCmdPattern> update(IFileDb db, ref ToolCmd<ToolCmdPattern> cmd, string root = null, string name = null, string arg = null, string delimiter = null, string type = null)
        {
            ref var data = ref cmd.Content;
            data.CmdRootName = root == null ? data.CmdRootName : FS.folder(root);
            data.Tool = cmd.ToolId;
            data.CmdArgName = arg == null ? data.CmdArgName : arg;
            data.ArgDelimiter = delimiter == null ? data.ArgDelimiter : delimiter;
            data.CmdType = type == null ? data.CmdType : FS.ext(type);
            rules(db, ref cmd);
            return ref cmd;
        }

        [Op]
        public static ref ToolCmd<ToolCmdPattern> rules(IFileDb db, ref ToolCmd<ToolCmdPattern> cmd)
        {
            ref var data = ref cmd.Content;
            ref readonly var id = ref data.Tool;
            data.CmdRoot = db.ToolRoot() +  data.CmdRootName;
            data.CmdName = FS.file(id.Format(), data.CmdType);
            data.CmdOutName = FS.file(string.Format("{0}.{1}", id, data.CmdArgName), db.Log);
            data.CmdOutDir = db.ToolOutput(id);
            data.CmdOutPath = data.CmdOutDir + FS.file(id.Id);
            data.CmdArgs = string.Format("{0}{0}", data.ArgDelimiter, data.CmdArgName);
            data.CmdPath = data.CmdRoot + FS.file(id.Format(), data.CmdType);
            data.CmdExecSpec = string.Format("{0} {1}", data.CmdPath, data.CmdArgs);
            return ref cmd;
        }
    }
}