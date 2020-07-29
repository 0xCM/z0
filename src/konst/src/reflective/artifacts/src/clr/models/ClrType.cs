//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Clr
{
    using System;
    using System.Runtime.CompilerServices;
    
    using static Konst;

    public readonly struct ClrType : IClrType<ClrType>
    {
        public Type Metadata {get;}
                
        public ClrTypeKind Kind 
            => default;
        
        [MethodImpl(Inline)]
        public ClrType(Type src)
        {
            Metadata = src;
        }

        public ArtifactIdentity Identifier
        {
            [MethodImpl(Inline)]
            get => Metadata.MetadataToken;
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
            => src.Metadata;
        
        public Type[] NestedTypes 
            => Reflex.nested(Metadata);
    }
}