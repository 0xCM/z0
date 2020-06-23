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
        /// Specifies the number of characters that precede a null terminator, if any; otherwise, returns the capacity
        /// </summary>
        int Length {get;}

        /// <summary>
        /// The maximum number of asci characters the sequence can cover
        /// </summary>
        int Capacity {get;}

        /// <summary>
        /// The sequence content rendered as text
        /// </summary>
        string Text {get;}
        
        /// <summary>
        /// The sequence prasented as an encoded byte span
        /// </summary>
        ReadOnlySpan<byte> Encoded {get;}            

        /// <summary>
        /// The sequence prasented as a decoded character span
        /// </summary>
        ReadOnlySpan<char> Decoded {get;}
        
        string ITextual.Format()
            => Text;
    }

    public interface IAsciSequence<N> : IAsciSequence
        where N : unmanaged, ITypeNat
    {
        int IAsciSequence.Capacity 
            => (int)TypeNats.value<N>();
    }

    public interface IAsciSequence<F,N> : IAsciSequence<N>, IEquatable<F>, INullary<F>
        where N : unmanaged, ITypeNat
        where F : unmanaged, IAsciSequence<F,N>
    {

    }
}