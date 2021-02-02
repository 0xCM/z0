//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Lang
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    public readonly struct DataType
    {
        public Identifier Name {get;}

        public BitSize Width {get;}

        [MethodImpl(Inline)]
        public DataType(Identifier name, BitSize width)
        {
            Name = name;
            Width = width;
        }
    }
}