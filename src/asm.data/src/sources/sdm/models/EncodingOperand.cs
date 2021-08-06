//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System.Runtime.CompilerServices;

    using static Root;

    partial struct SdmModels
    {
        public readonly struct EncodingOperand
        {
            public byte OpNumber {get;}

            public CharBlock32 OpExpr {get;}

            [MethodImpl(Inline)]
            public EncodingOperand(byte number, CharBlock32 expr)
            {
                OpNumber = number;
                OpExpr = expr;
            }
        }
    }
}