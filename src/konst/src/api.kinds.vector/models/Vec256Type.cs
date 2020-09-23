//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;

    using static Konst;

    /// <summary>
    /// Represents the generic type definition for a 256-bit vector
    /// </summary>
    public readonly struct Vec256Type : IVectorKind<Vec256Type,W256>
    {
        [MethodImpl(Inline)]
        public static implicit operator VectorWidthKind(Vec256Type src)
            => src.Class;

        [MethodImpl(Inline)]
        public static implicit operator VectorWidth(Vec256Type src)
            => src.W;

        [MethodImpl(Inline)]
        public static implicit operator Vec256Type(W256 src)
            => default;

        public W256 W
            => default;

        public VectorWidth Class
            => VectorWidth.W256;

        public uint Value
            => (uint)W.DataWidth;

        public int BitWidth
            => W;

        public Type TypeDefinition
            => typeof(Vector256<>).GenericDefinition2();
    }
}