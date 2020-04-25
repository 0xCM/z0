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
    /// Defines a value-parametric environment variable
    /// </summary>
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
            => string.Equals(Name,src.Name, StringComparison.InvariantCultureIgnoreCase) 
            && Object.Equals(Value, src.Value);
        
        public override bool Equals(object src)
            => src is EnvVar<T> v && Equals(v);
    }
}