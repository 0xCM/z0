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
    /// Specifies host-independent api member identity
    /// </summary>
    public readonly struct OpIdentity : IIdentifiedOperation<OpIdentity>
    {
        /// <summary>
        /// Creates a moniker directly from source text
        /// </summary>
        /// <param name="src">The source text</param>
        [MethodImpl(Inline)]
        public static OpIdentity define(string src)
            => new OpIdentity(src);

        /// <summary>
        /// The operation identifier
        /// </summary>
        public string Identifier {get;}

        /// <summary>
        /// The unqualified operation name
        /// </summary>
        public string Name {get;}

        /// <summary>
        /// The identifier suffix, if any
        /// </summary>
        public string Suffix {get;}

        /// <summary>
        /// Specifies whether the operation was reified from a generic definition
        /// </summary>
        public bool IsGeneric {get;}

        /// <summary>
        /// Specifies whether the operation is specialized for an immediate value
        /// </summary>
        public bool HasImm {get;}

        /// <summary>
        /// The moniker parts, as determined by part delimiters
        /// </summary>
        public string[] Components {get;}

        public OpIdentity(string data, string name, string suffix, bool generic, bool imm, string[] components)
        {
            Identifier = text.trim(Safe(data));
            Name = text.trim(name);
            Suffix = text.trim(suffix);
            IsGeneric = generic;
            HasImm = imm;
            Components = components;
        }

        [MethodImpl(Inline)]
        OpIdentity(string data)
        {
            Identifier = Safe(data);
            Name = EmptyString;
            Suffix = EmptyString;
            IsGeneric = false;
            HasImm = false;
            Components = sys.empty<string>();
        }

        public bool IsEmpty
        {
            [MethodImpl(Inline)]
            get => text.empty(Identifier);
        }

        public bool IsNonEmpty
        {
            [MethodImpl(Inline)]
            get => text.nonempty(Identifier);
        }

        public override int GetHashCode()
            => (int)alg.hash.calc(Identifier);

        public bool Equals(OpIdentity src)
            => text.equals(Identifier, src.Identifier);

        public override bool Equals(object src)
            => src is OpIdentity x && Equals(x);

        public string Format()
            => Identifier;

        public override string ToString()
            => Identifier;

        [MethodImpl(Inline)]
        public static implicit operator string(OpIdentity src)
            => src.Identifier;

        [MethodImpl(Inline)]
        public static bool operator==(OpIdentity a, OpIdentity b)
            => a.Equals(b);

        [MethodImpl(Inline)]
        public static bool operator!=(OpIdentity a, OpIdentity b)
            => !a.Equals(b);

        static string Safe(string src)
            => src.Replace(Chars.Lt, IDI.TypeArgsOpen).Replace(Chars.Gt, IDI.TypeArgsClose);

        public static OpIdentity Empty => new OpIdentity(EmptyString);
    }
}