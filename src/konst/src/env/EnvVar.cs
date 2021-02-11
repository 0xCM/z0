//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    /// <summary>
    /// Defines a nonparametric environment variable
    /// </summary>
    public readonly struct EnvVar : IEnvVar
    {
        /// <summary>
        /// The environment variable name
        /// </summary>
        public Name Name {get;}

        /// <summary>
        /// The environment variable value
        /// </summary>
        public string Value {get;}

        [MethodImpl(Inline)]
        public EnvVar(string name, string value)
        {
            Name = name;
            Value = value;
        }

        public VarSymbol Symbol
            => new VarSymbol(Name);

        public bool IsEmpty
        {
            [MethodImpl(Inline)]
            get => Name.IsEmpty || text.empty(Value);
        }

        public bool IsNonEmpty
        {
            [MethodImpl(Inline)]
            get => Name.IsNonEmpty && text.nonempty(Value);
        }

        public EnvVar<T> Transform<T>(Func<string,T> f)
            => Environs.define(Name, f(Value));

        [MethodImpl(Inline)]
        public string Format()
            => $"{Name}={Value}";

        public override string ToString()
            => Format();

        public override int GetHashCode()
            => Format().GetHashCode();

        [MethodImpl(Inline)]
        public bool Equals(EnvVar src)
            => string.Equals(Name,src.Name, NoCase) && string.Equals(Value, src.Value, NoCase);

        public override bool Equals(object src)
            => src is EnvVar v && Equals(v);

        [MethodImpl(Inline)]
        public static implicit operator EnvVar((string name, string value) src)
            => Environs.define(src.name, src.value);

        [MethodImpl(Inline)]
        public static implicit operator string(EnvVar src)
            => src.Value;

        public static EnvVar Empty
        {
            [MethodImpl(Inline)]
            get => new EnvVar(EmptyString, EmptyString);
        }
    }
}