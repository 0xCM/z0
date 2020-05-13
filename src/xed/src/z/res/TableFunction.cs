//-----------------------------------------------------------------------------
// Copyright   : (c) 2019 Intel Corporation
// Copyright   : (c) Chris Moore, 2020
// License     : Apache
//-----------------------------------------------------------------------------
namespace Z0.Xed
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Collections.Generic;
    using System.Linq;

    partial class Res
    {
        public readonly struct TableFunction
        {
            public static TableFunction Define(TextRow header, TextRow[] body)
                => new TableFunction(header, body);
            public TableFunction(TextRow header, TextRow[] body)
            {
                Header = header;
                Body = body;
            }
            public TextRow Header {get;}

            public TextRow[] Body {get;}
        }

    }
}