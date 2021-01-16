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
        /// <summary>
        /// The operation identity
        /// </summary>
        public OpIdentity Id {get;}

        public MemoryAddress SourceAddress {get;}

        public DynamicMethod Enclosure {get;}

        public Delegate Operation {get;}

        [MethodImpl(Inline)]
        public CellDelegate(OpIdentity id, MemoryAddress src, DynamicMethod enclosure, Delegate dynop)
        {
            Id = id;
            SourceAddress = src;
            Enclosure = enclosure;
            Operation = dynop;
        }

        [MethodImpl(Inline)]
        public static implicit operator Delegate(CellDelegate src)
            => src.Operation;
    }
}