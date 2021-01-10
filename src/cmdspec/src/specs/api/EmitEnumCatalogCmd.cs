//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    [Cmd(CmdName)]
    public struct EmitEnumCatalogCmd : ICmdSpec<EmitEnumCatalogCmd>
    {
        public const string CmdName = "emit-enum-catalog";

        public FS.FilePath Target;
    }

    partial class XCmd
    {
        [MethodImpl(Inline), Op]
        public static EmitEnumCatalogCmd EmitEnumCatalog(this CmdBuilder builder, FS.FilePath dst)
        {
            var cmd = new EmitEnumCatalogCmd();
            cmd.Target = dst;
            return cmd;
        }

        [Op]
        public static EmitEnumCatalogCmd EmitEnumCatalog(this CmdBuilder builder)
        {
            var cmd = new EmitEnumCatalogCmd();
            cmd.Target = builder.Db.IndexFile("enum-catalog");
            return cmd;
        }

    }
}