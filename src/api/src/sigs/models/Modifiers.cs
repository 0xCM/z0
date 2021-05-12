//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using K = ApiSigs.ModifierKind;

    using System.Runtime.CompilerServices;

    using static Root;

    partial struct ApiSigs
    {
        [ApiHost("apisigs.modifiers")]
        public readonly struct Modifiers
        {
            [Op]
            public static In @in()
                => default;

            [Op]
            public static Out @out()
                => default;

            [Op]
            public static Ref @ref()
                => default;

            [Op]
            public static Ptr ptr()
                => default;

            [Op]
            public static Imm imm()
                => default;

            public readonly struct In : ISigModifier<In>
            {
                public Name Name => "in";

                public K Kind => K.In;

                public string Format()
                    => Name;

                public override string ToString()
                    => Name;

                [MethodImpl(Inline)]
                public static implicit operator Modifier(In src)
                    => new Modifier(src.Name,src.Kind);
            }

            public readonly struct Out : ISigModifier<Out>
            {
                public Name Name => "out";

                public K Kind => K.Out;

                public string Format()
                    => Name;

                public override string ToString()
                    => Name;

                [MethodImpl(Inline)]
                public static implicit operator Modifier(Out src)
                    => new Modifier(src.Name,src.Kind);
            }

            public readonly struct Ref : ISigModifier<Ref>
            {
                public Name Name => "ref";

                public K Kind => K.Ref;

                public string Format()
                    => Name;

                public override string ToString()
                    => Name;

                [MethodImpl(Inline)]
                public static implicit operator Modifier(Ref src)
                    => new Modifier(src.Name,src.Kind);
            }

            public readonly struct Ptr : ISigModifier<Ptr>
            {
                public Name Name => "ptr";

                public K Kind => K.Ptr;

                public string Format()
                    => Name;

                public override string ToString()
                    => Name;


                [MethodImpl(Inline)]
                public static implicit operator Modifier(Ptr src)
                    => new Modifier(src.Name,src.Kind);

            }

            public readonly struct Imm : ISigModifier<Imm>
            {
                public Name Name => "imm";

                public K Kind => K.Imm;

                public string Format()
                    => Name;

                public override string ToString()
                    => Name;

                [MethodImpl(Inline)]
                public static implicit operator Modifier(Imm src)
                    => new Modifier(src.Name,src.Kind);
            }
        }
    }
}