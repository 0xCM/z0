//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    using K = ApiOperatorClass;

    partial class XTend
    {
        public static BinaryOpClass<T> As<T>(this BinaryOpClass src)
             where T : unmanaged => default;

        public static BinaryOpClass<W> Fixed<W>(this BinaryOpClass src)
            where W : unmanaged, ITypeWidth => default;
    }

    public readonly struct BinaryOpClass : IOperatorClass<BinaryOpClass,K>
    {
        public static implicit operator OperatorClass(BinaryOpClass src)
            => src.Generalized;

        public K Kind
            => K.BinaryOp;

        public OperatorClass Generalized
            => new OperatorClass(Kind);
    }

    public readonly struct BinaryOpClass<T> : IOperatorClass<BinaryOpClass<T>,K,T>
    {
        public K Kind
            => K.BinaryOp;

        [MethodImpl(Inline)]
        public static implicit operator OperatorClass<T>(BinaryOpClass<T> src)
            => src.Generalized;

        [MethodImpl(Inline)]
        public static implicit operator BinaryOpClass(BinaryOpClass<T> src)
            => src.NonGeneric;

        public OperatorClass<T> Generalized
            => new OperatorClass<T>(Kind);

        public BinaryOpClass NonGeneric
            => default;
    }
}