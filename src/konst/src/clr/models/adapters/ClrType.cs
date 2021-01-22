//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    public readonly struct ClrType : IClrRuntimeType<ClrType>
    {
        public Type Definition {get;}

        public ClrArtifactKind Kind
            => (ClrArtifactKind)Definition.TypeKind();

        [MethodImpl(Inline)]
        public ClrType(Type src)
            => Definition = src;

        public ClrAssembly Assembly
        {
            [MethodImpl(Inline)]
            get => Definition.Assembly;
        }

        public ClrToken Token
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
            get => Clr.nested(Definition);
        }

        string IClrArtifact.Name
            => Definition.Name;

        [MethodImpl(Inline), Closures(AllNumeric)]
        public static ClrType<T> From<T>()
            => default;

        [MethodImpl(Inline), Ignore]
        public string Format()
            => Definition.FullName;

        public override string ToString()
            => Format();

        [MethodImpl(Inline)]
        public static implicit operator ClrType(Type src)
            => new ClrType(src);

        [MethodImpl(Inline)]
        public static implicit operator Type(ClrType src)
            => src.Definition;
    }
}