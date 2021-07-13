//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;

    public sealed class RegMachine : StateMachine<RegBank>
    {
        internal RegMachine(RegBank bank)
            : base(bank)
        {


        }

        public override void Accept(ReadOnlySpan<byte> src)
        {

        }

        public override ReadOnlySpan<byte> Reveal()
        {
            return default;
        }
    }
}
