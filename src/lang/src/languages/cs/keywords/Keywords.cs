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
            public const string Abstract = "abstract";

            public const string Add = "add";

            public const string Alias = "alias";

            public const string As = "as";

            public const string Public = "public";

            public const string Struct = "struct";

            public const string Unmanaged = "unmanaged";
        }

        public readonly struct KeywordSpecs
        {
            public readonly struct Abstract : IKeyword<L,KW>
            {
                public KW Kind=> KW.Abstract;

                public string Name => Names.Abstract;
            }

            public readonly struct Add : IKeyword<L,KW>
            {
                public KW Kind=> KW.Add;

                public string Name => Names.Add;
            }

            public readonly struct Alias : IKeyword<L,KW>
            {
                public KW Kind=> KW.Alias;

                public string Name => Names.Alias;
            }

            public readonly struct As : IKeyword<L,KW>
            {
                public KW Kind=> KW.As;

                public string Name => Names.As;
            }

            public readonly struct Public : IKeyword<L,KW>
            {
                public KW Kind=> KW.Public;

                public string Name => Names.Public;
            }

            public readonly struct Struct : IKeyword<L,KW>
            {
                public KW Kind=> KW.Struct;

                public string Name => Names.Struct;
            }

            public readonly struct Unmanaged : IKeyword<L,KW>
            {
                public KW Kind=> KW.Unmanaged;

                public string Name => Names.Unmanaged;
            }
        }
    }
}