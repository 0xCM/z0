//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    /// <summary>
    /// When executed, emits an x86 opcode set from embedded resources
    /// </summary>
    [Cmd]
    public struct EmitAsmOpCodesCmd : ICmdSpec<EmitAsmOpCodesCmd>
    {
        public FS.FilePath Target;

        [MethodImpl(Inline)]
        public EmitAsmOpCodesCmd(FS.FilePath dst)
            => Target = dst;
    }
}