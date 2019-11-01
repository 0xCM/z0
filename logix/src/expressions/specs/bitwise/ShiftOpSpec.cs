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
    /// Defines a bitwise shift, including circular shifts, over subject and offset operands
    /// </summary>
    public sealed class ShiftOpSpec<T> : IShiftOp<T>
        where T : unmanaged
    {

        [MethodImpl(Inline)]
        public ShiftOpSpec(ShiftOpKind op, IExpr<T> subject, IExpr<int> offset)
        {
            this.OpKind = op;
            this.Subject = subject;
            this.Offset = offset;
        }

        /// <summary>
        /// The shift operaator
        /// </summary>
        public ShiftOpKind OpKind {get;}


        /// <summary>
        /// The shiftee
        /// </summary>
        public IExpr<T> Subject {get;}

        /// <summary>
        /// The magnitude of the shift
        /// </summary>
        public IExpr<int> Offset {get;}

        public string Format()
            => OpKind.Format(Subject,Offset);
        
        public override string ToString()
            => Format();

    } 
}