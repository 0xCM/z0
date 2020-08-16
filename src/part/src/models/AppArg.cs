//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Linq;

    using static Part;

    public readonly struct AppArg<P,V>
    {
        public readonly P Param;

        public readonly V Value;

        [MethodImpl(Inline)]
        public static implicit operator AppArg<P,V>((P param, V value) src)
            => new AppArg<P,V>(src.param, src.value);

        [MethodImpl(Inline)]
        public AppArg(P p, V v)
        {
            Param = p;
            Value = v;
        }        

        public static AppArg<P,V> Empty 
            => new AppArg<P,V>(default(P), default(V));
    }
    
    public readonly struct AppArg<T>
    {
        public readonly string Name;

        public readonly T Value;

        [MethodImpl(Inline)]
        public static implicit operator AppArg<T>((string name, T value) src)
            => new AppArg<T>(src.name, src.value);

        [MethodImpl(Inline)]
        public static implicit operator AppArg(AppArg<T> src)
            => new AppArg(src.Name, src.Value?.ToString() ?? "");

        [MethodImpl(Inline)]
        public AppArg(string name, T value)
        {
            Name = name;
            Value = value;
        }

        public static AppArg<T> Empty 
            => new AppArg<T>("", default(T));
    }
    
    public readonly struct AppArg
    {        
        public readonly string Name;

        public readonly string Value;

        [MethodImpl(Inline)]
        public static implicit operator AppArg((string name, string value) src)
            => new AppArg(src.name, src.value);
 
        [MethodImpl(Inline)]
        public AppArg(string name, string value)
        {
            Name = name;
            Value = value;
        }

        public bool IsEmpty 
            => string.IsNullOrWhiteSpace(Value);

        public bool IsNonEmpty 
            => !IsEmpty;
        
        public static AppArg Empty 
            => new AppArg("", "");
    }
}