//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    [Record]
    public struct XedInstructionRow : IRecord<XedInstructionRow>
    {
        public int Sequence;

        public asci16 Mnemonic;

        public asci16 Extension;

        public asci8 BaseCode;

        public asci4 Mod;

        public asci8 Reg;

        [MethodImpl(Inline)]
        public XedInstructionRow(int seq, string mnemonic, string ext, string @base, string mod, string reg)
        {
            Sequence = seq;
            Mnemonic = mnemonic;
            Extension = ext;
            BaseCode = @base;
            Mod = mod;
            Reg = reg;
        }
    }
}