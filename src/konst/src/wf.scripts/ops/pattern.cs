//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.IO;

    using static z;
    using static Konst;
    using static CmdPatterns;

    partial struct CmdScripts
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
    }
}