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
        public static CmdScriptPattern pattern(IWfDb db, ToolId tool, string root, string arg, CmdArgPrefix? prefix = null, string type = null)
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