//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    public interface ILiteralUsage
    {
        LiteralUsage Kind {get;}

    }

    public interface ILiteralUsage<T> : ILiteralUsage
        where T : unmanaged
    {

    }
}