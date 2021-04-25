//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    /// <summary>
    /// Represents a parametrically-identified clr type
    /// </summary>
    public readonly struct ClrType<T> : IClrRuntimeType<T>
    {
        static readonly Type TD = typeof(T);

        public Type Definition => TD;

        public ClrToken Token
        {
            [MethodImpl(Inline)]
            get => Definition.MetadataToken;
        }

        public ClrType Untyped
        {
            [MethodImpl(Inline)]
            get => Definition;
        }

        public ReadOnlySpan<ClrType> NestedTypes
        {
            [MethodImpl(Inline)]
            get => Untyped.NestedTypes;
        }

        public ClrArtifactKind Kind
            => (ClrArtifactKind)Definition.Kind();

        string IClrArtifact.Name
            => Definition.Name;

        [MethodImpl(Inline)]
        public string Format()
            => Definition.FullName;

        public override string ToString()
            => Format();

        [MethodImpl(Inline)]
        public static implicit operator ClrType(ClrType<T> src)
            => src.Untyped;

        [MethodImpl(Inline)]
        public static implicit operator Type(ClrType<T> src)
            => src.Definition;
    }
}