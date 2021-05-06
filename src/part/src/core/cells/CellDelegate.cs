//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Reflection.Emit;

    using static Part;

    public readonly struct CellDelegate
    {
        public Identifier Name {get;}

        public MemoryAddress SourceAddress {get;}

        public DynamicMethod Enclosure {get;}

        public Delegate Operation {get;}

        [MethodImpl(Inline)]
        public CellDelegate(Identifier name, MemoryAddress src, DynamicMethod enclosure, Delegate dynop)
        {
            Name = name;
            SourceAddress = src;
            Enclosure = enclosure;
            Operation = dynop;
        }

        [MethodImpl(Inline)]
        public static implicit operator Delegate(CellDelegate src)
            => src.Operation;
    }
}