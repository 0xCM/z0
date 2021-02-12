//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    partial struct ApiSigs
    {
        public readonly struct Modifier : ISigModifier<Modifier>
        {
            public Name Name {get;}

            public ModifierKind Kind {get;}

            public Modifier(Name name, ModifierKind kind)
            {
                Name = name;
                Kind = kind;
            }

            public string Format()
                => Name;

            public override string ToString()
                => Format();
        }
    }
}