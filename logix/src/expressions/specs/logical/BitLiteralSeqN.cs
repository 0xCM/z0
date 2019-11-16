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
   public sealed class LiteralLogicSeq<N> : ILiteralLogicSeq
        where N : unmanaged, ITypeNat
    {
        internal static LiteralLogicSeq<N> FromBitString(BitString src)
        {
            Nat.require<N>(src.Length);
            return new LiteralLogicSeq<N>(LiteralLogicSeq.FromBitString(src).Terms);
        }

        internal static LiteralLogicSeq<N> FromBits(params bit[] src)
        {
            Nat.require<N>(src.Length);
            return new LiteralLogicSeq<N>(src);
        }

        [MethodImpl(Inline)]
        LiteralLogicSeq(bit[] terms)
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

        public LogicExprKind ExprKind 
            => LogicExprKind.Literal;

        public BitString ToBitString()
            => BitString.from(Terms);    

        public string Format()
            => ToBitString().Format();

        public override string ToString()
            => Format();    
    }
}