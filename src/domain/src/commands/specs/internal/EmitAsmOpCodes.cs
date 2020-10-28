//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using Z0.Asm;

    using static Konst;
    using static z;

    partial class XCmdFactory
    {
        [MethodImpl(Inline), Op]
        public static EmitAsmOpCodesCmd EmitAsmOpCodes(this CmdBuilder builder)
            => new EmitAsmOpCodesCmd(builder.Db.RefDataPath("asm.opcodes"));
    }

    /// <summary>
    /// When executed, emits an x86 opcode set from embedded resources
    /// </summary>
    [Cmd(Code)]
    public struct EmitAsmOpCodesCmd : ICmdSpec<EmitAsmOpCodesCmd>
    {
        public const string Code = CmdCodes.EmitAsmOpCodes;

        public FS.FilePath Target;

        [MethodImpl(Inline)]
        public EmitAsmOpCodesCmd(FS.FilePath dst)
            => Target = dst;
    }

    public sealed class EmitAsmOpCodes : CmdHost<EmitAsmOpCodes, EmitAsmOpCodesCmd>
    {
        public static CmdResult run(IWfShell wf)
            => run(wf, wf.CmdBuilder().EmitAsmOpCodes());

        public static CmdResult run(IWfShell wf, in EmitAsmOpCodesCmd spec)
        {
            var data = AsmOpCodes.dataset().Entries;
            var count = data.Count;
            var view = data.View;

            var formatter = AsmOpCodes.formatter<AsmOpCodeField>();
            using var dst = spec.Target.Writer();
            formatter.EmitHeader(false);
            dst.WriteLine(formatter.Render());
            for(var i=0; i<count; i++)
            {
                ref readonly var record = ref skip(view,i);
                AsmOpCodes.format(record, formatter);
                dst.WriteLine(formatter.Render());
            }
            return Win();
        }

        protected override CmdResult Execute(IWfShell wf, in EmitAsmOpCodesCmd spec)
            => run(wf, spec);
    }
}