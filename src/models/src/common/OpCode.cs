//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Models
{
    using System.Runtime.CompilerServices;

    using static Root;

    using api = Model;

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
            get => api.table(this);
        }

        public Hex16 Value
        {
            [MethodImpl(Inline)]
            get => api.value(this);
        }

        public string Format()
            => api.format(this);

        public override string ToString()
            => Format();
    }
}