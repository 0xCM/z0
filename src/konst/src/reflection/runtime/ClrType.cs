//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    [ApiDataType(ApiNames.ClrType, true)]
    public readonly struct ClrType
    {
        public Type Definition {get;}

        public ClrTypeKind Kind
            => default;

        [MethodImpl(Inline)]
        public ClrType(Type src)
            => Definition = src;

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

        public ClrTypeName Name
        {
            [MethodImpl(Inline)]
            get => Definition;
        }

        public ReadOnlySpan<ClrType> NestedTypes
        {
            [MethodImpl(Inline)]
            get => z.recover<Type,ClrType>(ClrReflexSvc.nested(Definition));
        }

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

        [MethodImpl(Inline), Ignore]
        public string Format()
            => Definition.FullName;

        public override string ToString()
            => Format();
    }
}