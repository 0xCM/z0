//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;
    using static core;

    public class AsmShellState : ShellState
    {
        Index<SdmOpCodeRecord> _OpCodes;

        public AsmShellState()
        {
            _OpCodes = array<SdmOpCodeRecord>();
        }

        [MethodImpl(Inline)]
        public void OpCodes(SdmOpCodeRecord[] src)
        {
            _OpCodes = src;
        }

        [MethodImpl(Inline)]
        public ReadOnlySpan<SdmOpCodeRecord> OpCodes()
            => _OpCodes.View;
    }
}