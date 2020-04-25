//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    
    using static Seed;

    /// <summary>
    /// Defines a nonparametric environment variable
    /// </summary>
    public readonly struct EnvVar : IFormattable<EnvVar>
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
            => string.Equals(Name,src.Name, StringComparison.InvariantCultureIgnoreCase) 
            && string.Equals(Value, src.Value, StringComparison.InvariantCultureIgnoreCase);
        
        public override bool Equals(object src)
            => src is EnvVar v && Equals(v);
    }
}