//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;

    using static Root;
    using static core;

    [ApiHost]
    public class BdDisasmProcessor : AppService<BdDisasmProcessor>
    {
        bool Verbose
            => false;

    }
}