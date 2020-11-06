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
    using static CmdPatterns;

    partial struct Cmd
    {
        /// <summary>
        /// Creates a <see cref='CmdArgs'/> collection from an array
        /// </summary>
        /// <param name="src">The source array</param>
        [MethodImpl(Inline), Op]
        public static CmdPattern pattern(string id, string spec)
            => new CmdPattern(id, spec);

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static CmdPattern<K> pattern<K>(K id, string content)
            where K : unmanaged
                => new CmdPattern<K>(id,content);

        [Op]
        public static CmdScript<CmdScriptPattern> pattern(IFileDb db, string root, string name, string arg, string delimiter = null, string type = null)
        {
            CmdScript<CmdScriptPattern> cmd = new CmdScriptPattern();
            ref var data = ref cmd.Content;
            data.CmdRootName = FS.folder(root);
            data.Tool = name;
            data.CmdArgName = arg;
            data.ArgDelimiter = delimiter ?? DefaultArgDelimiter;
            data.CmdType = FS.ext(type ?? DefaultCmdType);
            rules(db, ref cmd);
            return cmd;
        }

        [Op]
        public static ref CmdScript<CmdScriptPattern> update(IFileDb db, ref CmdScript<CmdScriptPattern> cmd, string root = null, string name = null, string arg = null, string delimiter = null, string type = null)
        {
            ref var data = ref cmd.Content;
            data.CmdRootName = root == null ? data.CmdRootName : FS.folder(root);
            data.Tool = cmd.CmdId;
            data.CmdArgName = arg == null ? data.CmdArgName : arg;
            data.ArgDelimiter = delimiter == null ? data.ArgDelimiter : delimiter;
            data.CmdType = type == null ? data.CmdType : FS.ext(type);
            rules(db, ref cmd);
            return ref cmd;
        }

        [Op]
        public static ref CmdScript<CmdScriptPattern> rules(IFileDb db, ref CmdScript<CmdScriptPattern> cmd)
        {
            ref var data = ref cmd.Content;
            ref readonly var id = ref data.Tool;
            data.CmdRoot = db.ToolRoot() +  data.CmdRootName;
            data.CmdName = FS.file(id.Id, data.CmdType);
            data.CmdOutName = FS.file(string.Format("{0}.{1}", id, data.CmdArgName), db.Log);
            data.CmdOutDir = db.ToolOutput(id);
            data.CmdOutPath = data.CmdOutDir + FS.file(id.Id);
            data.CmdArgs = string.Format("{0}{0}", data.ArgDelimiter, data.CmdArgName);
            data.CmdPath = data.CmdRoot + FS.file(id.Id, data.CmdType);
            data.CmdExecSpec = string.Format("{0} {1}", data.CmdPath, data.CmdArgs);
            return ref cmd;
        }
    }
}