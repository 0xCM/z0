//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm.Dsl
{        
    using System;
    using System.Runtime.CompilerServices;
    
    using static Konst;

    public readonly struct m8 : IMemOp8<m8>
    {
        public byte Content {get;}

        [MethodImpl(Inline)]
        public static implicit operator m8(byte src)
            => new m8(src);

        [MethodImpl(Inline)]
        public static implicit operator byte(m8 src)
            => src.Content;

        [MethodImpl(Inline)]
        public m8(byte src)
        {
            Content = src;
        }        

        public DataWidth Width => DataWidth.W8;
    }
}