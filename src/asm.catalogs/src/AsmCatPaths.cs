//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    public readonly struct AsmCatPaths
    {
        readonly IEnvPaths Env;

        const string xed = "xed";

        [MethodImpl(Inline)]
        public AsmCatPaths(IEnvPaths env)
        {
            Env = env;
        }

        public FS.FilePath XedFormDetailPath()
            => Env.AsmCatalogPath(xed, FS.file("xed.forms.details", FS.Csv));

        public FS.FilePath XedSymIndexPath()
            => Env.AsmCatalogPath(xed, FS.file("xed.symbols", FS.Csv));

        public FS.FilePath XedFormAspectPath()
            => Env.AsmCatalogTable<XedFormAspect>(xed);
    }
}