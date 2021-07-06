//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    using static Rules;

    public interface ICall
    {
        IOperation Target {get;}

        Index<OperandValue> Operands {get;}
    }
}