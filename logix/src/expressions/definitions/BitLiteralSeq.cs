//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;
    using System.Runtime.CompilerServices;
    
    using static zfunc;

    /// <summary>
    /// Defines a sequence of literal bit values
    /// </summary>
    public struct BitLiteralSeq 
    {
        public static BitLiteralSeq FromBitString(BitString bs)
        {
            var terms = new bit[bs.Length];
            for(var i=0; i<terms.Length; i++)
                terms[i] = bs[i];
            return new BitLiteralSeq(terms);
        }

        [MethodImpl(Inline)]
        public static BitLiteralSeq FromBits(params bit[] src)
            => new BitLiteralSeq(src);

        [MethodImpl(Inline)]
        public static BitLiteralSeq<N> FromBits<N>(N n, params bit[] src)
            where N : ITypeNat, new()
                => BitLiteralSeq<N>.FromBits(src);

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
        
        public string Format()
            => ToBitString().Format();
    
        public override string ToString()
            => Format();
    }
}