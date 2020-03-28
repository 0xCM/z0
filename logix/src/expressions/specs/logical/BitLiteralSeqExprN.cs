//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Logix
{
    using System;
    using System.Runtime.CompilerServices;
    
    using static root;

   /// <summary>
   /// Defines a natural-length sequence of literal bit values
   /// </summary>
   public sealed class LiteralLogicSeqExpr<N> : ILiteralLogicSeqExpr
        where N : unmanaged, ITypeNat
    {
        public bit[] Terms {get;}

        [MethodImpl(Inline)]
        internal LiteralLogicSeqExpr(bit[] terms)
        {
            this.Terms = terms;
        }
                    
        public bit this[int index]
        {
            [MethodImpl(Inline)]
            get => Terms[index];
            
            [MethodImpl(Inline)]
            set => Terms[index] = value;
        }

        public int Length
            => Terms.Length;

        public LogicExprKind ExprKind 
            => LogicExprKind.Literal;

        public BitString ToBitString()
            => BitString.load(Terms);    

        public string Format()
            => ToBitString().Format();

        public override string ToString()
            => Format();    
    }
}