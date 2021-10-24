//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Machines
{
    using System.Runtime.CompilerServices;

    using static Root;


    public readonly struct OpCode
    {
        public readonly Label Name;

        internal readonly uint Data;

        [MethodImpl(Inline)]
        public OpCode(Label name, uint data)
        {
            Data = data;
            Name = name;
        }

        public OpCodeTable Table
        {
            [MethodImpl(Inline)]
            get => OpCodes.table(this);
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
    }
}