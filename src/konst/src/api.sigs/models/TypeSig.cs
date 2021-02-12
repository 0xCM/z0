//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Reflection;
    using System.Runtime.CompilerServices;

    using static Root;

    partial struct ApiSigs
    {
        public readonly struct TypeSig : ITextual
        {
            public Name TypeName {get;}

            public Index<Modifier> Modifiers {get;}

            public Index<ITypeParameter> Parameters {get;}

            [MethodImpl(Inline)]
            public TypeSig(Name name, params ITypeParameter[] parameters)
            {
                Modifiers = Index<Modifier>.Empty;
                TypeName = name;
                Parameters = parameters;
            }

            [MethodImpl(Inline)]
            public TypeSig(Name name, Modifier mod, params ITypeParameter[] parameters)
            {
                Modifiers = root.array(mod);
                TypeName = name;
                Parameters = parameters;
            }

            [MethodImpl(Inline)]
            public TypeSig(Name name, Index<Modifier> modifiers, params ITypeParameter[] parameters)
            {
                Modifiers = modifiers;
                TypeName = name;
                Parameters = parameters;
            }

            public uint ParameterCount
            {
                [MethodImpl(Inline)]
                get => Parameters.Count;
            }

            public bool IsParametric
            {
                [MethodImpl(Inline)]
                get => ParameterCount != 0;
            }

            public bool IsVoid
            {
                [MethodImpl(Inline)]
                get => TypeName == "void";
            }

            public bool IsEmpty
            {
                [MethodImpl(Inline)]
                get => TypeName.IsEmpty;
            }

            public bool IsNonEmpty
            {
                [MethodImpl(Inline)]
                get => TypeName.IsNonEmpty;
            }

            public string Format()
                => format(this);

            public override string ToString()
                => Format();

            public static TypeSig Empty
            {
                [MethodImpl(Inline)]
                get => new TypeSig(EmptyString);
            }
        }
    }
}