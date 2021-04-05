//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections.Generic;

    public class UriCode : Dictionary<OpUri,ApiCodeBlock>
    {
        public static UriCode Empty => new UriCode();
    }
}