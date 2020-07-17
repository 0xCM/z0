//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Reflection;
    using System.Runtime.CompilerServices;
    
    using static Konst;
        
    public readonly struct ClrField
    {   
        public FieldInfo Metadata {get;}

        public ArtifactIdentity Identifier
        {
            [MethodImpl(Inline)]
            get => Metadata.MetadataToken;
        }

        [MethodImpl(Inline)]
        public static bool operator ==(ClrField lhs, ClrField rhs)
            => lhs.Equals(rhs);
        
        [MethodImpl(Inline)]
        public static bool operator !=(ClrField lhs, ClrField rhs)
            => !lhs.Equals(rhs);

        [MethodImpl(Inline)]
        public static implicit operator FieldInfo(ClrField src)
            => src.Metadata;

        [MethodImpl(Inline)]
        public ClrField(FieldInfo data)
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