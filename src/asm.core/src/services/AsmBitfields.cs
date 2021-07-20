//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;

    using static core;

    public class AsmBitfields
    {
        public static AsmBitfields service()
            => The;

        OpCodes _OpCodes;

        static AsmBitfields The;

        public IAsmBitfield OpCodeField()
            => _OpCodes;

        AsmBitfields()
        {
            _OpCodes = new OpCodes();
        }

        static AsmBitfields()
        {
            The = new AsmBitfields();
        }

        sealed class OpCodes : AsmBitfield<AsmTokens.OpCodes>
        {
            public OpCodes()
                : base("OpCodeBits")
            {

            }
        }
    }
}