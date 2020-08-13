//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm.Dsl
{        
    using System;
    using System.Runtime.CompilerServices;
        
    using static Konst;

    public readonly struct m512 : IMemOperand512<m512,Fixed512>
    {
        public Fixed512 Content {get;}

        [MethodImpl(Inline)]
        public m512(Fixed512 src)
        {
            Content = src;
        }

        public DataWidth Width 
            => DataWidth.W512;
    }
}