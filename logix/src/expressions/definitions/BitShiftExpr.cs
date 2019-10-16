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
    /// Defines a bitwise shift, including circular shifts, over subject and offset operands
    /// </summary>
    public sealed class BitShiftExpr<T> : IBitShiftExpr<T>
        where T : unmanaged
    {
        [MethodImpl(Inline)]
        public BitShiftExpr(BitOpKind op, IBitExpr<T> subject, IBitExpr<int> offset)
        {
            this.Operator = op;
            this.Subject = subject;
            this.Offset = offset;
        }
        
        /// <summary>
        /// The shift operaator
        /// </summary>
        public BitOpKind Operator {get;}

        /// <summary>
        /// The number of parameters accepted by the expression
        /// </summary>
        public ExprArity Arity => ExprArity.Binary;

        /// <summary>
        /// The shiftee
        /// </summary>
        public IBitExpr<T> Subject {get;}

        /// <summary>
        /// The right operand
        /// </summary>
        public IBitExpr<int> Offset {get;}

    } 
}