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
    /// Identifies a metadata element along with the declaring module
    /// </summary>
    public readonly struct MetadataToken : ITextual, IEquatable<MetadataToken>, INullity
    {
        readonly ulong Data;

        public static MetadataToken Empty => new MetadataToken(0.0);
    
        public int TokenValue
        {
            [MethodImpl(Inline)]
            get => (int)Data;
        }

        public int TokenModule
        {
            [MethodImpl(Inline)]
            get => (int)(Data >> 32);
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

        string FormatModule()
        {
            var m = TokenModule;
            if(m <= byte.MaxValue)
                return ((byte)m).FormatHex(zpad:true,specifier:false);
            else if(m <= ushort.MaxValue)
                return ((ushort)m).FormatHex(zpad:true,specifier:false);
            else
                return m.FormatHex(zpad:true,specifier:false);
        }

        public string Format()
            => $"{FormatModule()}:{TokenValue.FormatHex(zpad:true, specifier:false)}";

 
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

        MetadataToken(double x)
        {
            Data = 0;
        }
        
        [MethodImpl(Inline)]
        MetadataToken(Type src)
            : this(src.MetadataToken, src.Module)
        {
            
        }

        [MethodImpl(Inline)]
        MetadataToken(FieldInfo src)
            : this(src.MetadataToken, src.Module)
        {

        }


        [MethodImpl(Inline)]
        MetadataToken(PropertyInfo src)
            : this(src.MetadataToken, src.Module)
        {

        }

        [MethodImpl(Inline)]
        MetadataToken(ParameterInfo src)
            : this(src.MetadataToken, src.Member.Module)
        {

        }

        [MethodImpl(Inline)]
        MetadataToken(MethodInfo src)
            : this(src.MetadataToken, src.Module)
        {

        }


        [MethodImpl(Inline)]
        MetadataToken(int token, Module m)
        {
            Data = (uint)token | ((ulong)m.MetadataToken << 32);
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
    }
}