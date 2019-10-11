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

    public struct BitLogicSeq 
    {
        public static BitLogicSeq FromBitString(BitString bs)
        {
            var terms = new Bit[bs.Length];
            for(var i=0; i<terms.Length; i++)
                terms[i] = bs[i];
            return new BitLogicSeq(terms);
        }

        [MethodImpl(Inline)]
        public static BitLogicSeq FromBits(params Bit[] src)
            => new BitLogicSeq(src);

        [MethodImpl(Inline)]
        public static BitLogicSeq<N> FromBits<N>(N n, params Bit[] src)
            where N : ITypeNat, new()
                => BitLogicSeq<N>.FromBits(src);

        [MethodImpl(Inline)]
        BitLogicSeq(Bit[] terms)
        {
            this.Terms = terms;
        }

        public Bit[] Terms {get;}

        public Bit this[int index]
        {
            get => Terms[index];
            set => Terms[index] = value;
        }

        public ExprArity Arity => ExprArity.Literal;

        public int Length
            => Terms.Length;

        public BitString ToBitString()
            => BitString.FromBits(Terms);

    }

    public struct BitLogicSeq<N>
        where N : ITypeNat, new()
    {
        public static BitLogicSeq<N> FromBitString(BitString src)
        {
            Nat.require<N>(src.Length);
            return new BitLogicSeq<N>(BitLogicSeq.FromBitString(src).Terms);
        }

        public static BitLogicSeq<N> FromBits(params Bit[] src)
        {
            Nat.require<N>(src.Length);
            return new BitLogicSeq<N>(src);
        }

        [MethodImpl(Inline)]
        BitLogicSeq(Bit[] terms)
        {
            this.Terms = terms;
        }
            
        public Bit[] Terms {get;}
        
        public ExprArity Arity => ExprArity.Literal;

        public Bit this[int index]
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