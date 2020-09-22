//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.ClrData
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    /// <summary>
    /// Represents a parametrically-identified clr type
    /// </summary>
    public readonly struct ClrType<T> : IClrType<T>
    {
        public Type Definition {get;}

        [MethodImpl(Inline)]
        public ClrType(Type src)
        {
            Definition = src;
        }

        public ApiArtifactKey Id
        {
            [MethodImpl(Inline)]
            get => Definition.MetadataToken;
        }

        [MethodImpl(Inline)]
        public static implicit operator ClrType(ClrType<T> src)
            => src.Definition;

        [MethodImpl(Inline)]
        public static implicit operator Type(ClrType<T> src)
            => src.Definition;

        public Type[] NestedTypes
            => Reflex.nested(Definition);

        public ClrTypeKind Kind
            => ClrTypeKind.None;
    }
}