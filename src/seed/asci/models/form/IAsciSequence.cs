//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{    
    using System;

    public interface IAsciSequence : INullity, ITextual
    {
        int Length {get;}

        string Text {get;}

        string ITextual.Format()
            => Text;
    }

    public interface IAsciSequence<N> : IAsciSequence
        where N : unmanaged, ITypeNat
    {
        int IAsciSequence.Length 
            => (int)TypeNats.value<N>();
    }

    public interface IAsciSequence<F,N> : IAsciSequence<N>, IEquatable<F>, INullary<F>
        where N : unmanaged, ITypeNat
        where F : unmanaged, IAsciSequence<F,N>
    {

    }
}