//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static z;

    public readonly struct BinaryLiterals<T> : ITableSpan<BinaryLiterals<T>, BinaryLiteral<T>>
        where T : unmanaged
    {
        readonly TableSpan<BinaryLiteral<T>> Data;

        public BinaryLiteral<T>[] Storage
        {
            [MethodImpl(Inline)]
            get => Data;
        }

        [MethodImpl(Inline)]
        public static implicit operator BinaryLiterals<T>(BinaryLiteral<T>[] src)
            => new BinaryLiterals<T>(src);

        [MethodImpl(Inline)]
        public BinaryLiterals(BinaryLiteral<T>[] src)
            => Data = src;

        public TableSpan<BinaryLiteral<T>> Table
        {
            [MethodImpl(Inline)]
            get => Data;
        }

        [MethodImpl(Inline)]
        public BinaryLiterals<T> Refresh(BinaryLiteral<T>[] src)
            => new BinaryLiterals<T>(src);
    }
}