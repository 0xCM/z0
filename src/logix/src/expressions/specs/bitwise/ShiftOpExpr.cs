//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Logix
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    /// <summary>
    /// Defines a bitwise shift operator expression
    /// </summary>
    public readonly struct ShiftOpExpr<T> : IShiftOpExpr<T>
        where T : unmanaged
    {
        /// <summary>
        /// The operator kind
        /// </summary>
        public BitShiftOpId OpKind {get;}

        /// <summary>
        /// The operand
        /// </summary>
        public IExpr<T> Subject {get;}

        /// <summary>
        /// The magnitude of the shift
        /// </summary>
        public IExpr<byte> Offset {get;}

        [MethodImpl(Inline)]
        public ShiftOpExpr(BitShiftOpId op, IExpr<T> subject, IExpr<byte> offset)
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