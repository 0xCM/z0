//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Machines
{
    using System.Runtime.CompilerServices;

    using static Root;

    public readonly struct OpCode<K>
        where K : unmanaged
    {
        public readonly Label Name;

        internal readonly K Data;

        [MethodImpl(Inline)]
        public OpCode(Label name, K data)
        {
            Name = name;
            Data = data;
        }

        public OpCodeTable Table
        {
            [MethodImpl(Inline)]
            get => (byte)Table;
        }

        public Hex16 Value
        {
            [MethodImpl(Inline)]
            get => OpCodes.value(this);
        }

        public string Format()
            => OpCodes.format(this);

        public override string ToString()
            => Format();

        [MethodImpl(Inline)]
        public static implicit operator OpCode(OpCode<K> src)
            => OpCodes.untype(src);
    }
}