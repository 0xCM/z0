//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System.Reflection;
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    [Cmd]
    public struct EmitResDataCmd : ICmdSpec<EmitResDataCmd>
    {
        public Assembly Source;

        public FS.FolderPath Target;

        public utf8 Match;

        public bool ClearTarget;
    }

    partial class XCmd
    {
        [MethodImpl(Inline), Op]
        public static EmitResDataCmd EmitResData(this CmdBuilder builder, Assembly src, string id, string match = null)
        {
            var dst = new EmitResDataCmd();
            dst.Source = src;
            dst.Target = builder.Db.RefDataRoot() + FS.folder(id);
            dst.Match = match ?? EmptyString;
            return dst;
        }
    }
}