//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Lang
{
    using System;

    public interface IOperation : IScope
    {
        Index<Operand> Input {get;}

        Index<Statement> Definition {get;}
    }

    public interface IFunction : IOperation
    {
        Operand Output {get;}
    }

    public interface IAction : IOperation
    {

    }
}