//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System.Reflection;
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    [Cmd(CmdName)]
    public struct EmitResDataCmd : ICmd<EmitResDataCmd>
    {
        public const string CmdName = "emit-res-data";
        public Assembly Source;

        public FS.FolderPath Target;

        public utf8 Match;

        public bool ClearTarget;
    }

    partial class XCmd
    {
        [MethodImpl(Inline), Op]
        public static EmitResDataCmd EmitResData(this CmdBuilder builder, Assembly src = null, string id = null, string match = null)
        {
            var dst = new EmitResDataCmd();
            dst.Source = src ?? Parts.Res.Assembly;
            dst.Target = builder.Db.RefDataRoot() + FS.folder(id ?? "z0.res");
            dst.Match = match ?? EmptyString;
            return dst;
        }
    }
}