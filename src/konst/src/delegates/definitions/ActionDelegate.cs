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

    public readonly struct ActionDelegate
    {
        /// <summary>
        /// The operation identity
        /// </summary>
        public readonly string Id;

        public readonly MemoryAddress SourceAddress;

        public readonly DynamicMethod Enclosure;

        public readonly Action DynamicOp;

        [MethodImpl(Inline)]
        public ActionDelegate(string id, MemoryAddress src, DynamicMethod enclosure, Action dynop)
        {
            Id = id;
            SourceAddress = src;
            Enclosure = enclosure;
            DynamicOp = dynop;
        }

        [MethodImpl(Inline)]
        public static implicit operator Delegate(ActionDelegate src)
            => src.DynamicOp;

        public void Invoke()
            => DynamicOp.Invoke();
    }
}