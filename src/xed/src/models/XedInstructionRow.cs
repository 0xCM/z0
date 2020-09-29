//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    using F = XedInstructionField;

    public struct XedInstructionRow
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

        public string DelimitedText(char delimiter)
        {
            var formatter = Formatters.dataset<F>(delimiter);
            formatter.Delimit(F.Sequence, Sequence);
            formatter.Delimit(F.Mnemonic, Mnemonic);
            formatter.Delimit(F.Extension, Extension);
            formatter.Delimit(F.BaseCode, BaseCode);
            formatter.Delimit(F.Mod, Mod);
            formatter.Delimit(F.Reg, Reg);
            return string.Empty;
        }
    }
}