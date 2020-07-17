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

    /// <summary>
    /// Represents a parametrically-identified clr struct
    /// </summary>
    public readonly struct ClrStruct<T> : IClrStruct
        where T : struct
    {
        public Type Metadata {get;}
        
        [MethodImpl(Inline)]
        public ClrStruct(Type src)
        {
            Metadata = src;
        }

        public ArtifactIdentity Identifier

        {
            [MethodImpl(Inline)]
            get => Metadata.MetadataToken;
        }

        public ClrStruct Untyped 
        {
            [MethodImpl(Inline)]
            get => new ClrStruct(Metadata);
        }

        [MethodImpl(Inline)]
        public static implicit operator ClrStruct(ClrStruct<T> src)
            => src.Untyped;

        [MethodImpl(Inline)]
        public static implicit operator Type(ClrStruct<T> src)
            => src.Metadata;

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