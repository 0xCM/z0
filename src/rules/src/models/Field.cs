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
        public readonly struct Field
        {
            public uint Index {get;}

            public Identifier Name {get;}

            public DataType Type {get;}

            [MethodImpl(Inline)]
            public Field(uint index, Identifier name, DataType type)
            {
                Index = index;
                Name = name;
                Type = type;
            }
        }
    }
}