//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    
    using static Konst;

    /// <summary>
    /// Defines a nonparametric environment variable
    /// </summary>
    public readonly struct EnvVar : ITextual
    {
        /// <summary>
        /// The environment variable name
        /// </summary>
        public string Name {get;}

        /// <summary>   
        /// The environment variable value
        /// </summary>
        public string Value {get;}

        [MethodImpl(Inline)]
        public static EnvVar Read(string name) 
            => new EnvVar(name, Environment.GetEnvironmentVariable(name));
        
        [MethodImpl(Inline)]
        public static EnvVar<T> Define<T>(string name, T value)
            => new EnvVar<T>(name,value);
        
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
        public EnvVar(string name, string value)
        {
            Name = name;
            Value = value;
        }

        public EnvVar<T> Transform<T>(Func<string,T> f)
                => Env.define(Name,f(Value));
        
        public string Format()
            => $"{Name} := {Value}";
        
        public override string ToString()
            => Format();

        public override int GetHashCode()
            => Format().GetHashCode();

        public bool Equals(EnvVar src)
            => string.Equals(Name,src.Name, NoCase) 
            && string.Equals(Value, src.Value, NoCase);
        
        public override bool Equals(object src)
            => src is EnvVar v && Equals(v);
    }
}