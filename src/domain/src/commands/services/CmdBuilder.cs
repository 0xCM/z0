//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static z;

    [ApiDataType]
    public readonly struct CmdBuilder
    {
        [MethodImpl(Inline)]
        public static CmdBuilder create(IWfShell wf)
            => new CmdBuilder(wf);

        readonly IWfShell Wf;

        readonly IFileDb Db;

        [MethodImpl(Inline)]
        public CmdBuilder(IWfShell wf)
        {
            Wf = wf;
            Db = wf.Db();
        }

        [MethodImpl(Inline)]
        public EmitAsmOpCodesCmd EmitAsmOpCodes()
            => new EmitAsmOpCodesCmd(Db.RefDataPath("asm.opcodes"));

        [MethodImpl(Inline)]
        public EmitAsmSymbolsCmd EmitAsmSymbols()
            => new EmitAsmSymbolsCmd();

        [MethodImpl(Inline)]
        public EmitRenderPatternsCmd EmitRenderPatterns(Type src)
        {
            var dst = Db.Doc("render.patterns", src.Name, ArchiveFileKinds.Csv);
            return new EmitRenderPatternsCmd(src,dst);
        }
    }

    partial class XTend
    {
        [MethodImpl(Inline)]
        public static CmdBuilder CmdBuilder(this IWfShell wf)
            => new CmdBuilder(wf);
    }
}