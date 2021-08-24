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
        Index<SdmOpCodeDetail> _SdmOpCodes;

        Index<ProcessAsmRecord> _ProcessAsm;

        Index<ProcessAsmRecord> _ProcessAsmSelection;

        public AsmShellState()
        {
            _SdmOpCodes = array<SdmOpCodeDetail>();
            _ProcessAsm = array<ProcessAsmRecord>();
            _ProcessAsmSelection = array<ProcessAsmRecord>();
        }

        [MethodImpl(Inline)]
        public void SdmOpCodeDetail(SdmOpCodeDetail[] src)
        {
            _SdmOpCodes = src;
        }

        [MethodImpl(Inline)]
        public ReadOnlySpan<SdmOpCodeDetail> SdmOpCodeDetail()
            => _SdmOpCodes.View;

        [MethodImpl(Inline)]
        public Span<ProcessAsmRecord> ProcessAsmSelection()
            => _ProcessAsmSelection.Edit;

        public uint ProcessAsmCount
        {
            [MethodImpl(Inline)]
            get => _ProcessAsm.Count;
        }

        [MethodImpl(Inline)]
        public ReadOnlySpan<ProcessAsmRecord> ProcessAsm()
            => _ProcessAsm.View;

        [MethodImpl(Inline)]
        public ReadOnlySpan<ProcessAsmRecord> ProcessAsm(Index<ProcessAsmRecord> src)
        {
            _ProcessAsm = src;
            _ProcessAsmSelection = alloc<ProcessAsmRecord>(_ProcessAsm.Count);
            return ProcessAsm();
        }
    }
}