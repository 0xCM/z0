//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Clr
{
    using System;
    using System.Runtime.CompilerServices;
    
    using static Konst;

    /// <summary>
    /// Represents a parametrically-identified clr type
    /// </summary>
    public readonly struct ClrType<T> : IClrType<T>
    {
        public Type Metadata{ get;}

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
        public static implicit operator ClrType(ClrType<T> src)
            => src.Metadata;

        [MethodImpl(Inline)]
        public static implicit operator Type(ClrType<T> src)
            => src.Metadata;

        public Type[] NestedTypes 
            => Reflex.nested(Metadata);

        public ClrTypeKind Kind 
            => ClrTypeKind.None;
    }
}