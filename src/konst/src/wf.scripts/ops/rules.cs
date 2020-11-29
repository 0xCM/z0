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

    partial struct CmdScripts
    {
        [Op]
        public static ref CmdScriptPattern rules(IFileDb db, ref CmdScriptPattern data)
        {
            data.CmdRoot = db.ToolRoot() +  data.CmdRootName;
            data.CmdName = FS.file(data.CmdHost.Format(), data.ScriptType);
            data.CmdOutName = FS.file(string.Format("{0}.{1}", data.CmdHost, data.CmdArgName), db.Log);
            data.CmdOutDir = db.ToolOutput(data.CmdHost);
            data.CmdOutPath = data.CmdOutDir + FS.file(data.CmdHost);
            data.ToolArgs = string.Format("{0}{0}", data.ArgDelimiter, data.CmdArgName);
            data.CmdPath = data.CmdRoot + FS.file(data.CmdHost.Format(), data.ScriptType);
            data.CmdExecSpec = string.Format("{0} {1}", data.CmdPath, data.ToolArgs);
            return ref data;
        }
    }
}