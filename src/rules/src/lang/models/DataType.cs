//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    partial struct Rules
    {
        public readonly struct DataType : IType
        {
            public string Name {get;}

            [MethodImpl(Inline)]
            public DataType(string name)
            {
                Name = name;
            }
        }
    }
}