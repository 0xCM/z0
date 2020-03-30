//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    using static Core;

    /// <summary>
    /// Requires k1:K1 & k2:K2 => k1 + 1 = k2
    /// </summary>
    /// <typeparam name="K1">The first nat type</typeparam>
    /// <typeparam name="K2">The second nat type</typeparam>
    public interface INatNext<K1,K2> : INatLt<K1,K2> 
        where K1 : unmanaged, ITypeNat
        where K2 : unmanaged, ITypeNat
    {

    } 
    
    /// <summary>
    /// Captures evidence that k1 + 1 = k2
    /// </summary>
    /// <typeparam name="K1">The first nat type</typeparam>
    /// <typeparam name="K2">The second nat type</typeparam>
    public readonly struct NatNext<K1,K2> : INatNext<K1,K2>
        where K1: unmanaged, ITypeNat
        where K2: unmanaged, ITypeNat
    {
        static readonly K1 k1 = default;
        static readonly K2 k2 = default;
        
        public static string Description => $"++{k1} = {k2}";

        public NatNext(K1 n1, K2 n2)
        {
            require(n1.NatValue + 1 == n2.NatValue);
            this.valid = true;
        }

        public bool valid {get;}
        
        public override string ToString()
            => Description;
    }

    /// <summary>
    /// Captures evidence that k1 - 1 = k2
    /// </summary>
    /// <typeparam name="K1">The first nat type</typeparam>
    /// <typeparam name="K2">The second nat type</typeparam>
    public readonly struct NatPrior<K1,K2> : INatPrior<K1,K2>
        where K1: unmanaged, ITypeNat
        where K2: unmanaged, ITypeNat
    {
        static readonly K1 k1 = default;
        
        static readonly K2 k2 = default;
        
        static string Description => $"{k1} - 1 = {k2}";

        public NatPrior(K1 n1, K2 n2)
        {
            valid = true; 
            require(n1.NatValue - 1 == n2.NatValue);
        }

        public bool valid {get;}

        public ulong NatValue => value<K1>() -1;

        public override string ToString()
            => Description;
    }
}