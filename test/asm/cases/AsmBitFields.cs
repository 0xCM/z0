//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{        
    using System;
    using System.Runtime.CompilerServices;

    using static Seed;         

    public static class AsmBitfields
    {
        [MethodImpl(Inline)]
        public static NumericBits<RexPrefix,RexFieldIndex, byte> Rex()
            => BitField.numeric<RexPrefix,RexFieldIndex, byte, RexFieldWidth>();
    }    
}