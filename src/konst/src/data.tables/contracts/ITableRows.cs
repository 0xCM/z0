//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Security;

    public interface ITableRows : ITextual
    {
        string ITextual.Format()
            => "Unformatted";
    }

    public interface ITableRows<F> : ITableRows
        where F : unmanaged, Enum
    {

    }

}