//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using K = ApiSigs.SigModifier;

    partial struct ApiSigs
    {
        public readonly struct Modifiers
        {
            public static In @in()
                => default;

            public static Out @out()
                => default;

            public static Ref @ref()
                => default;

            public static Ptr ptr()
                => default;

            public static Imm imm()
                => default;

            public readonly struct In : IApiSigModifier<In>
            {
                public Name Name => "in";

                public K Kind => K.In;

                public string Format()
                    => Name;

                public override string ToString()
                    => Name;
            }

            public readonly struct Out : IApiSigModifier<Out>
            {
                public Name Name => "out";

                public K Kind => K.Out;

                public string Format()
                    => Name;

                public override string ToString()
                    => Name;
            }

            public readonly struct Ref : IApiSigModifier<Ref>
            {
                public Name Name => "ref";

                public K Kind => K.Ref;

                public string Format()
                    => Name;

                public override string ToString()
                    => Name;
            }

            public readonly struct Ptr : IApiSigModifier<Ptr>
            {
                public Name Name => "ptr";

                public K Kind => K.Ptr;

                public string Format()
                    => Name;

                public override string ToString()
                    => Name;
            }

            public readonly struct Imm : IApiSigModifier<Imm>
            {
                public Name Name => "imm";

                public K Kind => K.Imm;

                public string Format()
                    => Name;

                public override string ToString()
                    => Name;
            }
        }

    }
}