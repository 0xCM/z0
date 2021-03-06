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

    /// <summary>
    /// Represents the generic type definition for a 128-bit vector
    /// </summary>
    public readonly struct Vec128Type : IVectorKind<Vec128Type,W128>
    {
        public W128 W
            => default;

        public VectorWidth Class
            => VectorWidth.W128;

        public uint Value
            => (uint)W.DataWidth;

        public int BitWidth
            => W;

        public Type TypeDefinition
            => typeof(Vector128<>).GenericDefinition2();

        [MethodImpl(Inline)]
        public Type Close(Type cell)
            => TypeDefinition.MakeGenericType(cell);

        [MethodImpl(Inline)]
        public static implicit operator VectorWidthKind(Vec128Type src)
            => src.Class;

        [MethodImpl(Inline)]
        public static implicit operator VectorWidth(Vec128Type src)
            => src.W;

        [MethodImpl(Inline)]
        public static implicit operator Vec128Type(W128 src)
            => default;
    }
}