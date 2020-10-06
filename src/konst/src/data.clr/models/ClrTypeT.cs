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
    /// Represents a parametrically-identified clr type
    /// </summary>
    public readonly struct ClrType<T> : IClrType<T>
    {
        static readonly Type TD = typeof(T);

        public Type Definition => TD;

        public ClrArtifactKey Id
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

        [MethodImpl(Inline)]
        public string Format()
            => string.Format("{0}/{1}", Definition.Name, Id);

        public override string ToString()
            => Format();
    }
}