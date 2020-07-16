//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;        
 
    public readonly struct EncodedPair<C,K,W>
        where C : struct, IEncoded<C>
        where W : unmanaged, ITypeWidth
        where K : IKind
    {
        public readonly C Left;        

        public readonly C Right;
        
        [MethodImpl(Inline)]
        public EncodedPair(C left, C right)
        {
            Left = left;
            Right = right;
        }        
    }
}