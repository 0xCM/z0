//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm.Dsl
{        
    using System;
    using System.Runtime.CompilerServices;
    
    using static Konst;

    public readonly struct m128 : IAsmMemOperand128<m128,Fixed128>
    {
        public Fixed128 Content {get;}

        [MethodImpl(Inline)]
        public m128(Fixed128 src)
        {
            Content = src;
        }

        public DataWidth Width 
            => DataWidth.W128;
    }
}