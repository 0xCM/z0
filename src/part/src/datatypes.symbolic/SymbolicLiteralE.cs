//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    public struct SymbolicLiteral<E> : IComparableRecord<SymbolicLiteral<E>>
    {
        public ushort Index;

        public Name Component;

        public Name Type;

        public ClrPrimalKind DataType;

        public Name Name;

        public ulong ScalarValue;

        public E LiteralValue;

        public Identifier Identity
            => text.format(RP.SlotDot3, Component, Type, Index);

        [MethodImpl(Inline)]
        public string Format()
            => Name;

        public override string ToString()
            => Format();

        public int CompareTo(SymbolicLiteral<E> src)
            => Identity.CompareTo(src.Identity);
    }
}