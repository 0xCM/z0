//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    public readonly struct ClrType
    {
        public Type Definition {get;}

        public ClrTypeKind Kind
            => default;

        [MethodImpl(Inline)]
        public ClrType(Type src)
        {
            Definition = src;
        }

        public ClrAssembly Assembly
        {
            [MethodImpl(Inline)]
            get => Definition.Assembly;
        }

        public ClrArtifactKey Id
        {
            [MethodImpl(Inline)]
            get => Definition.MetadataToken;
        }

        public Type[] NestedTypes
            => Reflex.nested(Definition);

        [MethodImpl(Inline)]
        public static ClrType From(Type src)
            => new ClrType(src);

        [MethodImpl(Inline)]
        public static ClrType<T> From<T>()
            => default;

        [MethodImpl(Inline)]
        public static implicit operator ClrType(Type src)
            => From(src);

        [MethodImpl(Inline)]
        public static implicit operator Type(ClrType src)
            => src.Definition;

        [MethodImpl(Inline)]
        public string Format()
            => string.Format("{0}/{1}", Definition.Name, Id);

        public override string ToString()
            => Format();
    }
}