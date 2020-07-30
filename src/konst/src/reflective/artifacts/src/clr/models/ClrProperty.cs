//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Clr
{
    using System;
    using System.Reflection;
    using System.Runtime.CompilerServices;
    
    using static Konst;
    
    public readonly struct ClrProperty
    {   
        public PropertyInfo Metadata {get;}

        public ArtifactIdentity Identifier

        {
            [MethodImpl(Inline)]
            get => Metadata.MetadataToken;
        }

        [MethodImpl(Inline)]
        public static bool operator ==(ClrProperty lhs, ClrProperty rhs)
            => lhs.Equals(rhs);
        
        [MethodImpl(Inline)]
        public static bool operator !=(ClrProperty lhs, ClrProperty rhs)
            => !lhs.Equals(rhs);

        [MethodImpl(Inline)]
        public static implicit operator PropertyInfo(ClrProperty src)
            => src.Metadata;

        [MethodImpl(Inline)]
        public ClrProperty(PropertyInfo data)
            => Metadata = data;
        
        public string Format()
            => Metadata.ToString();
        
        public override bool Equals(object obj)
            => Metadata.Equals(obj);

        public override int GetHashCode()
            => Metadata.GetHashCode();

        public override string ToString()
            => Format();
    }
}