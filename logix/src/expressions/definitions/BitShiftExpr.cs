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
    public sealed class BitShiftExpr<T> : IShiftOp<T>
        where T : unmanaged
    {
        [MethodImpl(Inline)]
        public BitShiftExpr(ShiftOpKind op, IExpr<T> subject, IExpr<int> offset)
        {
            this.Operator = op;
            this.Subject = subject;
            this.Offset = offset;
        }
        
        /// <summary>
        /// The shift operaator
        /// </summary>
        public ShiftOpKind Operator {get;}

        /// <summary>
        /// The number of parameters accepted by the expression
        /// </summary>
        public ArityKind Arity => ArityKind.Binary;

        /// <summary>
        /// The shiftee
        /// </summary>
        public IExpr<T> Subject {get;}

        /// <summary>
        /// The right operand
        /// </summary>
        public IExpr<int> Offset {get;}

    } 
}