//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Logix
{
    using System;
    using System.Runtime.CompilerServices;
    
    using static zfunc;

    /// <summary>
    /// Defines a sequence of literal bit values
    /// </summary>
    public sealed class LiteralLogicSeq : ILiteralLogicSeq
    {
        public bit[] Terms {get;}

        [MethodImpl(Inline)]
        internal LiteralLogicSeq(bit[] terms)
        {
            this.Terms = terms;
        }

        /// <summary>
        /// The expression classifier
        /// </summary>
        public LogicExprKind ExprKind
            => LogicExprKind.Literal;

        public bit this[int index]
        {
            [MethodImpl(Inline)]
            get => Terms[index];
            
            [MethodImpl(Inline)]
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