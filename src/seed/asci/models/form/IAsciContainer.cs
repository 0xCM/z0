//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{    
    using System;


    /// <summary>
    /// Characterizes a container that refifies an asci sequence
    /// </summary>
    /// <typeparam name="A">The asci sequence type</typeparam>
    public interface IAsciContainer<A> : IAsciSequence, IContented<A>
        where A : unmanaged, IAsciSequence
    {        
        int IAsciSequence.Length  
            => Content.Length;

        int IAsciSequence.Capacity 
            => Content.Capacity;

        string IAsciSequence.Text 
            => Content.Text;
        
        ReadOnlySpan<byte> IAsciSequence.Encoded
            => Content.Encoded;

        ReadOnlySpan<char> IAsciSequence.Decoded 
            => Content.Decoded;
        
        bool INullity.IsEmpty   
            => Content.IsEmpty;
    }    
}