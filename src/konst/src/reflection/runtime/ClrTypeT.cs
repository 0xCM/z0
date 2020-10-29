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
    public readonly struct ClrType<T>
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

        public ReadOnlySpan<ClrType> NestedTypes
        {
            [MethodImpl(Inline)]
            get => z.recover<Type,ClrType>(ClrReflexSvc.nested(Definition));
        }

        [MethodImpl(Inline)]
        public string Format()
            => Definition.FullName;

        public override string ToString()
            => Format();
    }
}