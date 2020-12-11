//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    partial struct CmdScripts
    {
        [Op]
        public static ref CmdScriptPattern rules(IFileDb db, ref CmdScriptPattern data)
        {
            data.CmdRoot = db.ToolExeRoot() +  data.CmdRootName;
            data.CmdName = FS.file(data.CmdHost.Format(), data.ScriptType);
            data.CmdOutName = FS.file(string.Format("{0}.{1}", data.CmdHost, data.CmdArgName), db.Log);
            data.CmdOutDir = db.Output(data.CmdHost);
            data.CmdOutPath = data.CmdOutDir + FS.file(data.CmdHost);
            data.ToolArgs = string.Format("{0}{0}", data.ArgPrefix, data.CmdArgName);
            data.CmdPath = data.CmdRoot + FS.file(data.CmdHost.Format(), data.ScriptType);
            data.CmdExecSpec = string.Format("{0} {1}", data.CmdPath, data.ToolArgs);
            return ref data;
        }
    }
}