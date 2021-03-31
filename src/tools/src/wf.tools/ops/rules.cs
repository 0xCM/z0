//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    partial struct ToolCmd
    {
        [Op]
        public static ref CmdRuleInfo rule(IEnvPaths paths, ref CmdRuleInfo data)
        {
            data.CmdRoot = paths.ToolExeRoot() +  data.CmdRootName;
            data.CmdName = FS.file(data.CmdHost.Format(), data.ScriptType);
            data.CmdOutName = FS.file(string.Format("{0}.{1}", data.CmdHost, data.CmdArgName), FS.Extensions.Log);
            data.CmdOutDir = paths.ToolOutDir(data.CmdHost);
            data.CmdOutPath = data.CmdOutDir + FS.file(data.CmdHost);
            data.ToolArgs = string.Format("{0}{0}", data.ArgPrefix, data.CmdArgName);
            data.CmdPath = data.CmdRoot + FS.file(data.CmdHost.Format(), data.ScriptType);
            data.CmdExecSpec = string.Format("{0} {1}", data.CmdPath, data.ToolArgs);
            return ref data;
        }

        [Op]
        public static ref CmdRuleInfo rule(IEnvPaths paths, ref CmdRuleInfo data,
            string root = null, string name = null, string arg = null, ArgPrefix? prefix = null, string type = null)
        {
            data.CmdRootName = root == null ? data.CmdRootName : FS.folder(root);
            data.CmdArgName = arg == null ? data.CmdArgName : arg;
            data.ArgPrefix = prefix != null ? prefix.Value: data.ArgPrefix;
            data.ScriptType = type == null ? data.ScriptType : FS.ext(type);
            rule(paths, ref data);
            return ref data;
        }
    }
}