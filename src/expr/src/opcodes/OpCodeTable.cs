//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Machines
{
    using System.Runtime.CompilerServices;

    using static Root;

    public readonly struct OpCodeTable
    {
        public readonly byte Id;

        [MethodImpl(Inline)]
        public OpCodeTable(byte id)
        {
            Id = id;
        }

        public string Format()
            => Id.ToString();

        public override string ToString()
            => Format();

        [MethodImpl(Inline)]
        public static implicit operator OpCodeTable(byte id)
            => new OpCodeTable(id);

        [MethodImpl(Inline)]
        public static explicit operator uint(OpCodeTable src)
            => src.Id;
    }
}