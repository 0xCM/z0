//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    partial struct Db
    {
        public const string dot = AsciCharText.Dot;

        public readonly struct Literals
        {
            public const string asm = nameof(asm);

            public const string cs = nameof(cs);

            public const string il = nameof(il);

            public const string log = nameof(log);

            public const string csv = nameof(csv);

            public const string hex= nameof(hex);

            public const string metadata = nameof(metadata);

            public const string field = nameof(field);

            public const string blob = nameof(blob);

            public const string image = nameof(image);
        }
    }
}