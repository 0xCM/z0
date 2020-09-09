//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Security;
    using System.Runtime.CompilerServices;

    using static Konst;

    /// <summary>
    /// Classifies and describes operations defined over fixed operands
    /// </summary>
    /// <typeparam name="W">The operand width</typeparam>
    /// <typeparam name="T">The operand type</typeparam>
    /// <typeparam name="D">The operator type</typeparam>
    public readonly struct FixedOpKind<W,T,D> : IFixedOpKind<W,T,D>
        where W : unmanaged, IFixedWidth
        where T : IDataCell
        where D : Delegate
    {
        [MethodImpl(Inline)]
        public static implicit operator FixedOpKind(FixedOpKind<W,T,D> src)
            => src.Untyped;

        public FixedWidth OperandWidth
             => Widths.tfixed<W>();

        public Type OperandType
            => typeof(T);

        public Type OperatorType
            => typeof(D);

        public FixedOpKind Untyped
        {
            [MethodImpl(Inline)]
            get => new FixedOpKind(OperandWidth, OperandType, OperatorType);
        }
    }
}