//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    using api = ClrQuery;

    [ApiDataType(ApiNames.ClrType, true)]
    public readonly struct ClrType : IClrRuntimeType<ClrType>
    {
        public Type Definition {get;}

        public ClrTypeKind TypeKind
            => api.kind(Definition);

        [MethodImpl(Inline)]
        public ClrType(Type src)
            => Definition = src;

        public ClrAssembly Assembly
        {
            [MethodImpl(Inline)]
            get => Definition.Assembly;
        }

        public ClrArtifactKey Token
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
            get => z.recover<Type,ClrType>(ClrQuery.nested(Definition));
        }

        [MethodImpl(Inline)]
        public static ClrType From(Type src)
            => new ClrType(src);

        [MethodImpl(Inline), Closures(AllNumeric)]
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