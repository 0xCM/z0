//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    
    using static Konst;

    [ApiHost]
    public partial class Root : IApiHost<Root>
    {
        const NumericKind Closure = Integers8x64k;
    }
}