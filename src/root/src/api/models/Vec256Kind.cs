//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;

    using static Root;

    public readonly struct Vec256Kind<T> : IVectorKind<Vec256Kind<T>,W256,T>
        where T : unmanaged
    {
        public W256 W => default;

        public VectorWidth Width
            => VectorWidth.W256;

        public NumericKind CellKind
            => NumericKinds.kind<T>();

        public NumericWidth CellWidth
            => (NumericWidth)Widths.bits<T>();

        public Type TypeDefinition
            => typeof(Vector256<T>).GenericDefinition2();

        [MethodImpl(Inline)]
        public Type Close()
            => TypeDefinition.MakeGenericType(typeof(T));

        [MethodImpl(Inline)]
        public static implicit operator VectorWidth(Vec256Kind<T> src)
            => src.Width;

        [MethodImpl(Inline)]
        public static implicit operator Vec256Type(Vec256Kind<T> src)
            => default;
    }
}