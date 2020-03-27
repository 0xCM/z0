//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    
    using static Apps;

    public readonly struct EnvVar : IFormattable<EnvVar>
    {
        public readonly string Name;

        public readonly string Value;

        [MethodImpl(Inline)]
        public static EnvVar Read(string name) 
            => EnvVar.Define(name, Environment.GetEnvironmentVariable(name));
        
        [MethodImpl(Inline)]
        public static EnvVar<T> Define<T>(string name, T value)
            => EnvVar<T>.Define(name,value);
        
        [MethodImpl(Inline)]
        public static EnvVar Define(string name, string value)
            => new EnvVar(name,value);

        [MethodImpl(Inline)]
        public static implicit operator EnvVar((string name, string value) src)
            => Define(src.name, src.value);

        [MethodImpl(Inline)]
        public static implicit operator string(EnvVar src)
            => src.Value;

        [MethodImpl(Inline)]
        EnvVar(string name, string value)
        {
            this.Name = name;
            this.Value = value;
        }

        public EnvVar<T> Transform<T>(Func<string,T> f)
                => Define(Name,f(Value));

        public string Format()
            => $"{Name} := {Value}";
        
        public override string ToString()
            => Format();

        public override int GetHashCode()
            => Format().GetHashCode();

        public bool Equals(EnvVar src)
            => text.equals(Name,src.Name) && text.equals(Value, src.Value);
        
        public override bool Equals(object src)
            => src is EnvVar v && Equals(v);
    }

    public readonly struct EnvVar<T> : IFormattable<EnvVar<T>>
    {
        public static EnvVar<T> Define(string name, T value)
            => new EnvVar<T>(name,value);

        public static implicit operator EnvVar(EnvVar<T> src)
            => EnvVar.Define(src.Name, src.Value.ToString());

        [MethodImpl(Inline)]
        public static implicit operator EnvVar<T>((string name, T value) src)
            => Define(src.name, src.value);

        [MethodImpl(Inline)]
        public static implicit operator T(EnvVar<T> src)
            => src.Value;

        [MethodImpl(Inline)]
        EnvVar(string name, T value)
        {
            this.Name = name;
            this.Value = value;
        }

        public readonly string Name;

        public readonly T Value;

        public string Format()
            => $"{Name} := {Value}";
        
        public override string ToString()
            => Format();
        
        public override int GetHashCode()
            => Format().GetHashCode();

        public bool Equals(EnvVar<T> src)
            => text.equals(Name,src.Name) && Object.Equals(Value, src.Value);
        
        public override bool Equals(object src)
            => src is EnvVar<T> v && Equals(v);

    }
}