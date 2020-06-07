//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{    
    using System;
    using System.Runtime.CompilerServices;
    using System.Reflection;

    using static Seed;

    /// <summary>
    /// Identifies a metadata element along with the declaring module
    /// </summary>
    public readonly struct MetadataToken
    {
        readonly ulong Data;
        
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
         
        [MethodImpl(Inline)]
        public static MetadataToken From(Type src)
            => new MetadataToken(src);

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

    }
}