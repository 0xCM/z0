//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Logix
{
    using System;
    using System.Linq;
    using System.Runtime.CompilerServices;
    
    using static zfunc;

   /// <summary>
   /// Defines a natural-length sequence of literal bit values
   /// </summary>
   public struct BitLiteralSeq<N> : IBitLiteralSeq
        where N : ITypeNat, new()
    {
        internal static BitLiteralSeq<N> FromBitString(BitString src)
        {
            Nat.require<N>(src.Length);
            return new BitLiteralSeq<N>(BitLiteralSeq.FromBitString(src).Terms);
        }

        internal static BitLiteralSeq<N> FromBits(params bit[] src)
        {
            Nat.require<N>(src.Length);
            return new BitLiteralSeq<N>(src);
        }

        [MethodImpl(Inline)]
        BitLiteralSeq(bit[] terms)
        {
            this.Terms = terms;
        }
            
        public bit[] Terms {get;}
        
        public bit this[int index]
        {
            get => Terms[index];
            set => Terms[index] = value;
        }

        public int Length
            => Terms.Length;

        public BitString ToBitString()
            => BitString.FromBits(Terms);        
    }

}