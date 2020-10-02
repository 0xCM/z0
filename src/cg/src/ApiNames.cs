//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    using static ApiNameAtoms;

    using A = ApiNameAtoms;

    readonly struct ApiNames
    {
        const string models = nameof(models);

        const string cs = nameof(cs);

        const string tests = nameof(tests);

        const string builder = nameof(builder);

        const string render = nameof(render);

        public const string Models = A.lang + dot + models;

        public const string Cs = A.lang + dot + cs;

        public const string Asm = A.lang + dot + A.asm;

        public const string CsRender = Cs + dot + render;

        public const string CsBuilder = Cs + dot + builder;
    }
}

