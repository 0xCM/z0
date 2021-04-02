//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Lang
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    public interface IStatement : IExpr
    {

    }

    public readonly struct Statement : IStatement
    {
        public IScope Scope {get;}
    }
}