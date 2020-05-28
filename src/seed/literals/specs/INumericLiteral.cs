//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Seed;

    public interface INumericLiteral : ILiteral
    {
        bool ILiteral.MultiLiteral => false;
    }

    public interface INumericLiteral<F> : INumericLiteral, ILiteral<F>
        where F : struct, INumericLiteral<F>
    {
        F Rename(string name);
    }
}