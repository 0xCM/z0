//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using static ApiNameAtoms;

    [ApiNameProvider]
    readonly struct ApiNames
    {
        const string asm = nameof(asm);

        const string render = nameof(render);

        const string semantic = nameof(semantic);

        const string archive = nameof(archive);

        public const string AsmSemanticRender = asm + dot + semantic + dot + render;

        public const string AsmSemanticArchive = asm + dot + semantic + dot + archive;
    }
}