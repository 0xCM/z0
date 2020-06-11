//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{

    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    public interface IHashed
    {
        uint Hash {get;}

        int HashCode {get;}
    }

    public readonly struct Hashed : IHashed
    {        
        public uint Hash {get;}

        [MethodImpl(Inline)]
        public Hashed(uint src)
            => Hash = src;

        public int HashCode
        {
            [MethodImpl(Inline)]
            get => (int)Hash;
        }        
    }
    
    public interface IHashed<F,C> : IHashed, IContented<C>
        where F : IHashed<F,C>
        where C : struct
     {

     }    
    
    /// <summary>
    /// Captures a hash code for structured content
    /// </summary>
    public readonly struct Hashed<C> : IHashed<Hashed<C>,C>
        where C : struct
    {
        public uint Hash {get;}

        public C Content {get;}
        
        [MethodImpl(Inline)]
        public Hashed(in C content)
        {
            Content = content;
            Hash = Control.hash(Control.bytes(content));
        }
        
        public int HashCode
        {
            [MethodImpl(Inline)]
            get => (int)Hash;
        }        
    }
}