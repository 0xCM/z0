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
    public struct EmitAsmOpCodesCmd : ICmd<EmitAsmOpCodesCmd>
    {
        public FS.FilePath Target;
    }

    partial class XCmd
    {
        [MethodImpl(Inline), Op]
        public static EmitAsmOpCodesCmd EmitAsmOpCodes(this CmdBuilder builder, FS.FilePath? dst = null)
        {
            var cmd = new EmitAsmOpCodesCmd();
            cmd.Target = dst ?? builder.Db.RefDataPath("asm.opcodes");
            return cmd;
        }
    }
}