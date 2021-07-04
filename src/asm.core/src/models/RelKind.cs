//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;

    partial struct AsmCodes
    {
        [SymSource]
        public enum RelKind : byte
        {
            None = 0,

            [Symbol("rel8")]
            Rel8,

            [Symbol("rel16")]
            Rel16,

            [Symbol("rel32")]
            Rel32
        }

        public readonly struct Rel8 : IAsmRel<Rel8>
        {
            public RelKind Kind => RelKind.Rel8;

            public string Name => "rel8";

            public string Format()
                => Name;

            public override string ToString()
                => Format();
        }

        public readonly struct Rel16: IAsmRel<Rel16>
        {
            public RelKind Kind => RelKind.Rel16;

            public string Name => "rel16";

            public string Format()
                => Name;

            public override string ToString()
                => Format();
        }

        public readonly struct Rel32: IAsmRel<Rel32>
        {
            public RelKind Kind => RelKind.Rel32;

            public string Name => "rel32";

            public string Format()
                => Name;

            public override string ToString()
                => Format();
        }
    }
}