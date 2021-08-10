//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;

    using static Root;
    using static core;

    partial struct AsmParser
    {
        [Op]
        public static Outcome code(in AsmMnemonic src, out AsmMnemonicCode dst)
        {
            if(Enum.TryParse(typeof(AsmMnemonicCode), src.Format(), true, out var _code))
            {
                dst = (AsmMnemonicCode)_code;
                return true;
            }

            dst = 0;
            return false;
        }

        [Op]
        public static Outcome parse(in AsmMnemonic src, out AsmMnemonicCode dst)
        {
            if(Enums.parse(src.Format(), out dst))
                return true;
            else
            {
                dst = 0;
                return false;
            }
        }

        [Op]
        public static Outcome mnemonic(string sig, out AsmMnemonic dst)
        {
            dst = AsmMnemonic.Empty;
            if(text.empty(sig))
                return false;

            var trimmed = sig.Trim();
            var i = text.index(trimmed, Chars.Space);
            if(i == NotFound)
                return false;
            else
            {
                dst = text.substring(trimmed,0,i);
                return true;
            }
        }
    }
}
