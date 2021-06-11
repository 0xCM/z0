//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;

    using static core;

    partial class AsmGen
    {
        ReadOnlySpan<string> LoadMnemonicNames()
            => Wf.XedCatalog().MnemonicNames();
    }
}