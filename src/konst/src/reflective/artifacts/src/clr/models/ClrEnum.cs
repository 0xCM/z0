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
        public Type Metadata {get;}

        public ArtifactIdentity Identifier
        {
            [MethodImpl(Inline)]
            get => Metadata.MetadataToken;
        }

        public ClrStruct BaseType
        {
            [MethodImpl(Inline)]
            get => new ClrStruct(Metadata.GetEnumUnderlyingType());
        }

        [MethodImpl(Inline)]
        public ClrEnum(Type src)
        {
            Metadata = src;
        }

        [MethodImpl(Inline)]
        public static implicit operator ClrType(ClrEnum src)
            => src.Metadata;

        [MethodImpl(Inline)]
        public static implicit operator Type(ClrEnum src)
            => src.Metadata;
    }
}