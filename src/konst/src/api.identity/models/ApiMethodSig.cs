//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Reflection;
    using System.Runtime.CompilerServices;

    using static Root;

    partial struct ApiSigs
    {
        public readonly struct MethodSig
        {
            public Name Name {get;}

            public Index<OperandSig> Operands {get;}

            public OperandSig Return {get;}

            [MethodImpl(Inline)]
            public MethodSig(Name name, Index<OperandSig> operands, OperandSig @return)
            {
                Name = name;
                Operands = operands;
                Return = @return;
            }
        }
    }
}