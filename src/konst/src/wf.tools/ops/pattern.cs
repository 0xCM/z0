//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static CmdPatterns;
    using static z;

    partial struct Tooling
    {
        [Op]
        public static ToolCmd<ToolCmdPattern> pattern(IFileDb db, string root, string name, string arg, string delimiter = null, string type = null)
        {
            ToolCmd<ToolCmdPattern> cmd = new ToolCmdPattern();
            ref var data = ref cmd.Content;
            data.CmdRootName = FS.folder(root);
            data.Tool = name;
            data.CmdArgName = arg;
            data.ArgDelimiter = delimiter ?? DefaultArgDelimiter;
            data.CmdType = FS.ext(type ?? DefaultCmdType);
            rules(db, ref cmd);
            return cmd;
        }
    }
}