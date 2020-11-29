//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    using static z;
    using static Konst;
    using static CmdPatterns;

    partial struct CmdScripts
    {
        [Op]
        public static CmdScriptPattern tool(IFileDb db, ToolId tool, string root, string arg, string delimiter = null, string type = null)
        {
            var data = new CmdScriptPattern();
            data.CmdRootName = FS.folder(root);
            data.CmdHost = tool;
            data.CmdArgName = arg;
            data.ArgDelimiter = delimiter ?? DefaultArgDelimiter;
            data.ScriptType = FS.ext(type ?? DefaultCmdType);
            rules(db, ref data);
            return data;
        }
    }
}