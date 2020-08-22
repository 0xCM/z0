//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.ClrData
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    public readonly struct ClrEnum : IClrEnum<ClrEnum>
    {
        public Type Definition {get;}

        public ArtifactIdentity Id
        {
            [MethodImpl(Inline)]
            get => Definition.MetadataToken;
        }

        public ClrStruct BaseType
        {
            [MethodImpl(Inline)]
            get => new ClrStruct(Definition.GetEnumUnderlyingType());
        }

        [MethodImpl(Inline)]
        public ClrEnum(Type src)
        {
            Definition = src;
        }

        [MethodImpl(Inline)]
        public static implicit operator ClrType(ClrEnum src)
            => src.Definition;

        [MethodImpl(Inline)]
        public static implicit operator Type(ClrEnum src)
            => src.Definition;
    }
}