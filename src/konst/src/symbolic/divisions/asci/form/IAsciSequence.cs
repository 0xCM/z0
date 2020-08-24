//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{    
    using System;

    public interface IAsciSequence : INullity, ITextual
    {    
        /// <summary>
        /// The sequence presented as an encoded byte span
        /// </summary>
        ReadOnlySpan<byte> View {get;}            

        /// <summary>
        /// The maximum number of asci characters the sequence can cover
        /// </summary>
        int Capacity {get;}

        /// <summary>
        /// Specifies the number of characters that precede a null terminator, if any; otherwise, returns the capacity
        /// </summary>
        int Length {get;}
    }
    
    public interface IAsciSequence<F> : IAsciSequence
        where F : struct, IAsciSequence<F>
    {
    }

    public interface IAsciSequence<F,N> : IAsciSequence<F>, IEquatable<F>, INullary<F>
        where N : unmanaged, ITypeNat
        where F : struct, IAsciSequence<F,N>
    {
        int IAsciSequence.Capacity 
            => (int)TypeNats.value<N>();
    }
}