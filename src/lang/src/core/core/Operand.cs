//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Lang
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    public readonly struct Operand
    {
        public byte Index {get;}

        public Name Name {get;}

        public DataType Type {get;}

        [MethodImpl(Inline)]
        public Operand(byte index, string name, DataType type)
        {
            Index = index;
            Name = name;
            Type = type;
        }
    }
}