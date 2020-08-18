//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.ClrData
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Runtime.CompilerServices;

    using static Konst;

    /// <summary>
    /// Represents a parametrically-identified clr struct
    /// </summary>
    public readonly struct ClrStruct<T> : IClrStruct
        where T : struct
    {
        public Type Definition {get;}

        [MethodImpl(Inline)]
        public ClrStruct(Type src)
        {
            Definition = src;
        }

        public ArtifactIdentity Id

        {
            [MethodImpl(Inline)]
            get => Definition.MetadataToken;
        }

        public ClrStruct Untyped
        {
            [MethodImpl(Inline)]
            get => new ClrStruct(Definition);
        }

        [MethodImpl(Inline)]
        public static implicit operator ClrStruct(ClrStruct<T> src)
            => src.Untyped;

        [MethodImpl(Inline)]
        public static implicit operator Type(ClrStruct<T> src)
            => src.Definition;

        [MethodImpl(Inline)]
        public static implicit operator ClrType<T>(ClrStruct<T> src)
            => ClrType.From<T>();

        public IEnumerable<ClrStruct> NestedTypes
        {
            [MethodImpl(Inline)]
            get => Untyped.NestedTypes;
        }
    }
}