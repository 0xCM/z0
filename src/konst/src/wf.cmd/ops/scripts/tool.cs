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
        public static CmdScriptPattern tool(IWfDb db, ToolId tool, string root, string arg, CmdArgPrefix? prefix = null, string type = null)
        {
            var data = new CmdScriptPattern();
            data.CmdRootName = FS.folder(root);
            data.CmdHost = tool;
            data.CmdArgName = arg;
            data.ArgPrefix = prefix ?? CmdArgPrefix.Default;
            data.ScriptType = FS.ext(type ?? "exe");

            rules(db, ref data);
            return data;
        }
    }
}