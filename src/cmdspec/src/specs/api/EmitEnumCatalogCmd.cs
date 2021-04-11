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
    public struct EmitEnumCatalogCmd : ICmd<EmitEnumCatalogCmd>
    {
        public const string CmdName = "emit-enum-catalog";

        public FS.FilePath Target;
    }

    partial class XCmd
    {
    }
}