//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm.Dsl
{        
    using System;
    using System.Runtime.CompilerServices;
    
    using static Konst;

    public readonly struct m256 : IMemOp256<m256>
    {
        public Fixed256 Content {get;}

        [MethodImpl(Inline)]
        public m256(Fixed256 src)
        {
            Content = src;
        }

        public DataWidth Width 
            => DataWidth.W256;
    }
}