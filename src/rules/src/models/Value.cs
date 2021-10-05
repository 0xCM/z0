//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    partial struct RuleModels
    {
        public readonly struct Value
        {
            public DataType Type {get;}

            public dynamic Content {get;}

            [MethodImpl(Inline)]
            public Value(DataType type, dynamic content)
            {
                Type = type;
                Content = content;
            }
        }

    }
}