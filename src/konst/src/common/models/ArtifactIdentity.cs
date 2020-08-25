//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{    
    using System;
    using System.Runtime.CompilerServices;
    using System.Reflection;

    using static Konst;

    /// <summary>
    /// Identifies a metadata element
    /// </summary>
    public readonly struct ArtifactIdentity : ITextual, IEquatable<ArtifactIdentity>, INullity
    {
        readonly Address32 Data;        
    
        [MethodImpl(Inline)]
        public static implicit operator ArtifactIdentity(int src)
            => new ArtifactIdentity(src);
        
        public int TokenValue
        {
            [MethodImpl(Inline)]
            get => (int)Data.Location;
        }
         
        public bool IsEmpty
        {
            [MethodImpl(Inline)]
            get => Data == 0;
        }
                
        public bool IsNonEmpty
        {
            [MethodImpl(Inline)]
            get => Data != 0;
        }
        public string Format()
            => Data.Format();
 
        [MethodImpl(Inline)]
        public static ArtifactIdentity From(Type src)
            => new ArtifactIdentity(src);

        [MethodImpl(Inline)]
        public static ArtifactIdentity From<T>()
            => new ArtifactIdentity(typeof(T));

        [MethodImpl(Inline)]
        public static ArtifactIdentity From(FieldInfo src)
            => new ArtifactIdentity(src);

        [MethodImpl(Inline)]
        public static ArtifactIdentity From(PropertyInfo src)
            => new ArtifactIdentity(src);

        [MethodImpl(Inline)]
        public static ArtifactIdentity From(MethodInfo src)
            => new ArtifactIdentity(src);

        [MethodImpl(Inline)]
        public static ArtifactIdentity From(ParameterInfo src)
            => new ArtifactIdentity(src);

        [MethodImpl(Inline)]
        public static bool operator ==(ArtifactIdentity x, ArtifactIdentity y)
            => x.Equals(y);

        [MethodImpl(Inline)]
        public static bool operator !=(ArtifactIdentity x, ArtifactIdentity y)
            => !x.Equals(y);

        [MethodImpl(Inline)]
        public static implicit operator ArtifactIdentity(Type src)
            => From(src);

        [MethodImpl(Inline)]
        public static implicit operator ArtifactIdentity(FieldInfo src)
            => From(src);

        [MethodImpl(Inline)]
        public static implicit operator ArtifactIdentity(PropertyInfo src)
            => From(src);

        [MethodImpl(Inline)]
        public static implicit operator ArtifactIdentity(MethodInfo src)
            => From(src);

        [MethodImpl(Inline)]
        public static implicit operator ArtifactIdentity(ParameterInfo src)
            => From(src);
        
        [MethodImpl(Inline)]
        internal ArtifactIdentity(Type src)
            : this(src.MetadataToken)
        {
            
        }

        [MethodImpl(Inline)]
        internal ArtifactIdentity(Assembly src)
            : this(src.GetHashCode())
        {
            
        }

        [MethodImpl(Inline)]
        internal ArtifactIdentity(FieldInfo src)
            : this(src.MetadataToken)
        {

        }

        [MethodImpl(Inline)]
        internal ArtifactIdentity(PropertyInfo src)
            : this(src.MetadataToken)
        {

        }

        [MethodImpl(Inline)]
        internal ArtifactIdentity(ParameterInfo src)
            : this(src.MetadataToken)
        {

        }

        [MethodImpl(Inline)]
        internal ArtifactIdentity(MethodInfo src)
            : this(src.MetadataToken)
        {

        }

        [MethodImpl(Inline)]
        internal ArtifactIdentity(Module src)
            : this(src.MetadataToken)
        {

        }

        [MethodImpl(Inline)]
        internal ArtifactIdentity(int token)
        {
            Data = (uint)token;
        }        

        public override string ToString()
            => Format();

        [MethodImpl(Inline)]
        public bool Equals(ArtifactIdentity src)
            => Data == src.Data;

        public override int GetHashCode() 
            => Data.GetHashCode();

        public override bool Equals(object src)
            => src is ArtifactIdentity t && Equals(t);

        public static ArtifactIdentity Empty 
            => default;
    }
}