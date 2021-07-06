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
        public readonly struct OperandSpec
        {
            public byte Index {get;}

            public string Name {get;}

            public DataType Type {get;}

            [MethodImpl(Inline)]
            public OperandSpec(byte index, string name, DataType type)
            {
                Index = index;
                Name = name;
                Type = type;
            }
        }
    }
}