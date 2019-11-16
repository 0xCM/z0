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
    /// Defines a sequence of literal bit values
    /// </summary>
    public sealed class LiteralLogicSeq : ILiteralLogicSeq
    {
        public static LiteralLogicSeq FromBitString(BitString bs)
        {
            var terms = new bit[bs.Length];
            for(var i=0; i<terms.Length; i++)
                terms[i] = bs[i];
            return new LiteralLogicSeq(terms);
        }

        [MethodImpl(Inline)]
        public static LiteralLogicSeq FromBits(params bit[] src)
            => new LiteralLogicSeq(src);

        [MethodImpl(Inline)]
        public static LiteralLogicSeq<N> FromBits<N>(N n, params bit[] src)
            where N : unmanaged, ITypeNat
                => LiteralLogicSeq<N>.FromBits(src);

        [MethodImpl(Inline)]
        LiteralLogicSeq(bit[] terms)
        {
            this.Terms = terms;
        }

        /// <summary>
        /// The expression classifier
        /// </summary>
        public LogicExprKind ExprKind
            => LogicExprKind.Literal;

        public bit[] Terms {get;}

        public bit this[int index]
        {
            get => Terms[index];
            set => Terms[index] = value;
        }
        
        public int Length
            => Terms.Length;

        public BitString ToBitString()
            => BitString.from(Terms);
        
        public string Format()
            => ToBitString().Format();
    
        public override string ToString()
            => Format();
    }
}