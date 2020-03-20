//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Logix
{
    using System;
    using System.Runtime.CompilerServices;
    
    using static Root;

    /// <summary>
    /// Defines a bitwise shift operator expression
    /// </summary>
    public sealed class ShiftOpExpr<T> : IShiftOpExpr<T>
        where T : unmanaged
    {
        /// <summary>
        /// The operator kind
        /// </summary>
        public ShiftOpKind OpKind {get;}

        /// <summary>
        /// The operand
        /// </summary>
        public IExpr<T> Subject {get;}

        /// <summary>
        /// The magnitude of the shift
        /// </summary>
        public IExpr<byte> Offset {get;}

        [MethodImpl(Inline)]
        public ShiftOpExpr(ShiftOpKind op, IExpr<T> subject, IExpr<byte> offset)
        {
            this.OpKind = op;
            this.Subject = subject;
            this.Offset = offset;
        }

        public string Format()
            => OpKind.Format(Subject,Offset);
        
        public override string ToString()
            => Format();
    } 
}