//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Lang
{
    using System;

    public interface IOperation : IScope
    {
        Identifier Name {get;}

        Index<Operand> Input {get;}

        Operand? Output {get;}

        OperationBody Definition {get;}
    }
}