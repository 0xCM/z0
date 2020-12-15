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
        public static ref CmdScriptPattern update(IWfDb db, ref CmdScriptPattern data,
            string root = null, string name = null, string arg = null, CmdArgPrefix? prefix = null, string type = null)
        {
            data.CmdRootName = root == null ? data.CmdRootName : FS.folder(root);
            data.CmdArgName = arg == null ? data.CmdArgName : arg;
            data.ArgPrefix = prefix != null ? prefix.Value: data.ArgPrefix;
            data.ScriptType = type == null ? data.ScriptType : FS.ext(type);
            rules(db, ref data);
            return ref data;
        }
    }
}