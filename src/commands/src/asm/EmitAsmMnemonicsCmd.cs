//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    [Cmd]
    public struct EmitAsmMnemonicsCmd : ICmdSpec<EmitAsmMnemonicsCmd>
    {

    }

    partial class XCmd
    {
        [MethodImpl(Inline), Op]
        public static EmitAsmMnemonicsCmd EmitAsmMnemonics(this CmdBuilder builder)
            => new EmitAsmMnemonicsCmd();
    }
}