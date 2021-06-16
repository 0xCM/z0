//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;

    using static core;

    partial class AsmModelGen
    {
        ReadOnlySpan<string> LoadMnemonicNames()
            => Wf.XedCatalog().MnemonicNames();
    }
}