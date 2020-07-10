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
    public readonly struct MetadataToken : ITextual, IEquatable<MetadataToken>, INullity
    {
        readonly Address32 Data;        
    
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
        public static MetadataToken From(Type src)
            => new MetadataToken(src);

        [MethodImpl(Inline)]
        public static MetadataToken From<T>()
            => new MetadataToken(typeof(T));

        [MethodImpl(Inline)]
        public static MetadataToken From(FieldInfo src)
            => new MetadataToken(src);

        [MethodImpl(Inline)]
        public static MetadataToken From(PropertyInfo src)
            => new MetadataToken(src);

        [MethodImpl(Inline)]
        public static MetadataToken From(MethodInfo src)
            => new MetadataToken(src);

        [MethodImpl(Inline)]
        public static MetadataToken From(ParameterInfo src)
            => new MetadataToken(src);

        [MethodImpl(Inline)]
        public static bool operator ==(MetadataToken x, MetadataToken y)
            => x.Equals(y);

        [MethodImpl(Inline)]
        public static bool operator !=(MetadataToken x, MetadataToken y)
            => !x.Equals(y);

        [MethodImpl(Inline)]
        public static implicit operator MetadataToken(Type src)
            => From(src);

        [MethodImpl(Inline)]
        public static implicit operator MetadataToken(FieldInfo src)
            => From(src);

        [MethodImpl(Inline)]
        public static implicit operator MetadataToken(PropertyInfo src)
            => From(src);

        [MethodImpl(Inline)]
        public static implicit operator MetadataToken(MethodInfo src)
            => From(src);

        [MethodImpl(Inline)]
        public static implicit operator MetadataToken(ParameterInfo src)
            => From(src);
        
        [MethodImpl(Inline)]
        internal MetadataToken(Type src)
            : this(src.MetadataToken)
        {
            
        }

        [MethodImpl(Inline)]
        internal MetadataToken(FieldInfo src)
            : this(src.MetadataToken)
        {

        }

        [MethodImpl(Inline)]
        internal MetadataToken(PropertyInfo src)
            : this(src.MetadataToken)
        {

        }

        [MethodImpl(Inline)]
        internal MetadataToken(ParameterInfo src)
            : this(src.MetadataToken)
        {

        }

        [MethodImpl(Inline)]
        internal MetadataToken(MethodInfo src)
            : this(src.MetadataToken)
        {

        }

        [MethodImpl(Inline)]
        internal MetadataToken(Module src)
            : this(src.MetadataToken)
        {

        }

        [MethodImpl(Inline)]
        internal MetadataToken(int token)
        {
            Data = (uint)token;
        }        

        public override string ToString()
            => Format();

        [MethodImpl(Inline)]
        public bool Equals(MetadataToken src)
            => Data == src.Data;

        public override int GetHashCode() 
            => Data.GetHashCode();

        public override bool Equals(object src)
            => src is MetadataToken t && Equals(t);

        public static MetadataToken Empty 
            => default;
    }
}