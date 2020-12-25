//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    public interface INamedLiteral<T> : ILiteralValue<T>
        where T : IEquatable<T>
    {
        Name Name {get;}
    }

    public interface INamedLiteral<H,T> : INamedLiteral<T>, ILiteralValue<H,T>
        where T : IEquatable<T>
        where H : struct, ILiteralValue<H,T>
    {

    }
}