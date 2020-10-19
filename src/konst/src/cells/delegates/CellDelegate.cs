//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Reflection.Emit;

    using static Konst;

    public readonly struct CellDelegate
    {
        /// <summary>
        /// The operation identity
        /// </summary>
        public readonly OpIdentity Id;

        public readonly MemoryAddress SourceAddress;

        public readonly DynamicMethod Enclosure;

        public readonly Delegate DynamicOp;

        [MethodImpl(Inline)]
        public static CellDelegate define(OpIdentity id, MemoryAddress src, DynamicMethod enclosure, Delegate dynop)
            => new CellDelegate(id,src,enclosure,dynop);

        [MethodImpl(Inline)]
        public static implicit operator Delegate(CellDelegate src)
            => src.DynamicOp;

        [MethodImpl(Inline)]
        public CellDelegate(OpIdentity id, MemoryAddress src, DynamicMethod enclosure, Delegate dynop)
        {
            Id = id;
            SourceAddress = src;
            Enclosure = enclosure;
            DynamicOp = dynop;
        }
    }
}