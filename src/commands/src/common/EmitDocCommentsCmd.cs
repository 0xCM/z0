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
    public struct EmitDocCommentsCmd : ICmdSpec<EmitDocCommentsCmd>
    {
        public const string CmdName = "emit-doc-comments";
    }

    public static partial class XCmd
    {
        [MethodImpl(Inline), Op]
        public static EmitDocCommentsCmd EmitDocComments(this CmdBuilder builder)
            => new EmitDocCommentsCmd();
    }
}