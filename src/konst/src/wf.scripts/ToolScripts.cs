//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Reflection;

    using static z;
    using static Konst;
    using static CmdPatterns;

    [ApiHost]
    public readonly partial struct ToolScripts
    {
        [Op]
        public static ToolScript create(IFileDb db, ToolId tool, string root, string arg, string delimiter = null, string type = null)
        {
            var data = new ToolScript();
            data.CmdRootName = FS.folder(root);
            data.Tool = tool;
            data.CmdArgName = arg;
            data.ArgDelimiter = delimiter ?? DefaultArgDelimiter;
            data.ScriptType = FS.ext(type ?? DefaultCmdType);
            rules(db, ref data);
            return data;
        }

        [Op]
        public static ref ToolScript update(IFileDb db, ref ToolScript data, string root = null, string name = null, string arg = null, string delimiter = null, string type = null)
        {
            data.CmdRootName = root == null ? data.CmdRootName : FS.folder(root);
            data.CmdArgName = arg == null ? data.CmdArgName : arg;
            data.ArgDelimiter = delimiter == null ? data.ArgDelimiter : delimiter;
            data.ScriptType = type == null ? data.ScriptType : FS.ext(type);
            rules(db, ref data);
            return ref data;
        }

        [Op]
        public static ref ToolScript rules(IFileDb db, ref ToolScript data)
        {
            data.CmdRoot = db.ToolRoot() +  data.CmdRootName;
            data.CmdName = FS.file(data.Tool.Format(), data.ScriptType);
            data.CmdOutName = FS.file(string.Format("{0}.{1}", data.Tool, data.CmdArgName), db.Log);
            data.CmdOutDir = db.ToolOutput(data.Tool);
            data.CmdOutPath = data.CmdOutDir + FS.file(data.Tool);
            data.ToolArgs = string.Format("{0}{0}", data.ArgDelimiter, data.CmdArgName);
            data.CmdPath = data.CmdRoot + FS.file(data.Tool.Format(), data.ScriptType);
            data.CmdExecSpec = string.Format("{0} {1}", data.CmdPath, data.ToolArgs);
            return ref data;
        }
    }
}