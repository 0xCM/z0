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

    partial class AsmSigs
    {
        public static string format(in AsmSig src)
        {
            var storage = CharBlock64.Null;
            var dst = storage.Data;
            var i=0u;
            text.copy(src.Mnemonic.Format(MnemonicCase.Uppercase), ref i, dst);
            seek(dst,i++) = Chars.LParen;
            var count = src.OperandCount;
            for(byte j=0; j<count; j++)
            {
                ref readonly var op = ref operand(src,j);
                if(op.IsEmpty)
                    break;

                if(j != 0)
                    seek(dst,i++) = Chars.Comma;

                text.copy(op.Text, ref i, dst);
            }
            seek(dst,i++) = Chars.RParen;
            return storage.Format();
        }
    }
}