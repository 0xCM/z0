//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.InteropServices;

    using api = SdmModels;

    [StructLayout(LayoutKind.Sequential, Pack=1)]
    public struct SdmOpCode
    {
        public uint OpCodeId;

        public CharBlock16 Mnemonic;

        public CharBlock64 Operands;

        public CharBlock48 Expr;

        public string Format()
            => api.format(this);

        public override string ToString()
            => Format();
    }
}