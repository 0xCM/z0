//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    partial struct Cmd
    {

        [MethodImpl(Inline), Op]
        public static CmdScriptExpr expr(CmdPattern pattern)
            => new CmdScriptExpr(pattern);

        [MethodImpl(Inline), Op]
        public static CmdScriptExpr expr(in Paired<CmdPattern,CmdVarIndex> src)
            => new CmdScriptExpr(src.Left, src.Right);

        [MethodImpl(Inline), Op]
        public static CmdScriptExpr expr(CmdPattern pattern, CmdVarIndex vars)
            => new CmdScriptExpr(pattern, vars);

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static CmdScriptExpr<K> expr<K>(CmdPattern pattern, CmdVarIndex<K> content)
            where K : unmanaged
                => new CmdScriptExpr<K>(pattern, content);

        [MethodImpl(Inline)]
        public static CmdScriptExpr<K,T> expr<K,T>(K id, T content)
            where K : unmanaged
                => new CmdScriptExpr<K,T>(id,content);
        [Op]
        public static ref CmdScriptPattern rules(IWfDb db, ref CmdScriptPattern data)
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

        [Op]
        public static ref CmdScriptPattern update(IWfDb db, ref CmdScriptPattern data,
            string root = null, string name = null, string arg = null, ArgPrefix? prefix = null, string type = null)
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