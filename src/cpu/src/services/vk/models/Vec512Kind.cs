//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    public readonly struct Vec512Kind<T> : IVectorKind<Vec512Kind<T>,W512,T>
        where T : unmanaged
    {
        public W512 W => default;

        public VectorWidth Width
            => VectorWidth.W512;

        public NumericKind CellKind
            => NumericKinds.kind<T>();

        public NumericWidth CellWidth
            => (NumericWidth)Widths.bits<T>();

        public Type TypeDefinition
            => typeof(Vector512<T>).GenericDefinition2();

        [MethodImpl(Inline)]
        public Type Close()
            => TypeDefinition.MakeGenericType(typeof(T));

        [MethodImpl(Inline)]
        public static implicit operator VectorWidth(Vec512Kind<T> src)
            => src.Width;

        [MethodImpl(Inline)]
        public static implicit operator Vec512Type(Vec512Kind<T> src)
            => default;
    }
}