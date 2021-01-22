//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Lang
{
    using Names = CSharp.KeywordNames;
    using L = CSharp;

    partial struct CSharp
    {
        public enum KW : ushort
        {
            None,

            Abstract,

            Add,

            Alias,

            As,

            Public,

            Struct,

            Unmanaged,
        }

        public readonly struct KeywordNames
        {
            public static Name Abstract => "abstract";

            public static Name Add => "add";

            public static Name Alias => "alias";

            public static Name As => "as";

            public static Name Public => "public";

            public static Name Struct => "struct";

            public static Name Unmanaged => "unmanaged";
        }

        public readonly struct KeywordSpecs
        {
            public readonly struct Abstract : IKeyword<L,KW>
            {
                public KW Kind=> KW.Abstract;

                public Name Name => Names.Abstract;
            }

            public readonly struct Add : IKeyword<L,KW>
            {
                public KW Kind=> KW.Add;

                public Name Name => Names.Add;
            }

            public readonly struct Alias : IKeyword<L,KW>
            {
                public KW Kind=> KW.Alias;

                public Name Name => Names.Alias;
            }

            public readonly struct As : IKeyword<L,KW>
            {
                public KW Kind=> KW.As;

                public Name Name => Names.As;
            }

            public readonly struct Public : IKeyword<L,KW>
            {
                public KW Kind=> KW.Public;

                public Name Name => Names.Public;
            }

            public readonly struct Struct : IKeyword<L,KW>
            {
                public KW Kind=> KW.Struct;

                public Name Name => Names.Struct;
            }

            public readonly struct Unmanaged : IKeyword<L,KW>
            {
                public KW Kind=> KW.Unmanaged;

                public Name Name => Names.Unmanaged;
            }
        }
    }
}