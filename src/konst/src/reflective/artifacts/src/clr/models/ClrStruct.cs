//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Runtime.CompilerServices;
    
    using static Konst;

    public readonly struct ClrStruct : IClrStruct
    {
        public Type Metadata {get;}

        [MethodImpl(Inline)]
        public ClrStruct(Type src)
        {
            Metadata = src;
        }

        public ClrType Generalized
        {
            [MethodImpl(Inline)]
            get => Reflex.@struct(Metadata);
        }

        public ArtifactIdentity Identifier

        {
            [MethodImpl(Inline)]
            get => Metadata.MetadataToken;
        }

        [MethodImpl(Inline)]
        public static implicit operator ClrType(ClrStruct src)
            => src.Generalized;

        [MethodImpl(Inline)]
        public static implicit operator Type(ClrStruct src)
            => src.Metadata;

        [MethodImpl(Inline)]
        internal static ClrStruct Unchecked(Type src)
            => new ClrStruct(src);

        public IEnumerable<ClrStruct> NestedTypes 
            => Metadata.GetNestedTypes().Select(t => new ClrStruct(t));
    }
}