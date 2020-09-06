//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    /// <summary>
    /// Represents the generic type definition for a 512-bit vector
    /// </summary>
    public readonly struct Vec512Type : IVectorKind<Vec512Type,W512>
    {
        [MethodImpl(Inline)]
        public static implicit operator VectorWidthKind(Vec512Type src)
            => src.Class;

        [MethodImpl(Inline)]
        public static implicit operator VectorWidth(Vec512Type src)
            => src.W;

        [MethodImpl(Inline)]
        public static implicit operator Vec512Type(W512 src)
            => default;

        public W512 W
            => default;

        public VectorWidth Class
            => VectorWidth.W512;

        public uint Value
            => (uint)W.DataWidth;

        public int BitWidth
            => W;

        public Type TypeDefinition
            => typeof(Vector512<>).GenericDefinition2();
    }
}