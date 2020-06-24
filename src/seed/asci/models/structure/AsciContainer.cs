//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{    
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    public readonly struct AsciContainer<A> : IAsciContainer<A>
        where A : unmanaged, IAsciSequence
    {
        public A Content {get;}        

        [MethodImpl(Inline)]
        public static implicit operator A(AsciContainer<A> src)
            => src.Content;

        [MethodImpl(Inline)]
        public static implicit operator AsciContainer<A>(A src)
            => new AsciContainer<A>(src);
       
        [MethodImpl(Inline)]
        public AsciContainer(A src)
            => Content = src;        
    }
}