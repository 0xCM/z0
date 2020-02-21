//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm.Encoding
{        
    using System;
    using System.Runtime.CompilerServices;
    using Z0.Asm.Encoding;

    using static zfunc;         

    public static class AsmBitfields
    {
        [MethodImpl(Inline)]
        public static NumericBits<RexPrefix,RexFieldIndex, byte> Rex()
            => BitField.numeric<RexPrefix,RexFieldIndex, byte, RexFieldWidth>();
    }    
}