//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    using Free = System.Security.SuppressUnmanagedCodeSecurityAttribute;

    [Free]
    public interface ITableId : ITextual
    {
        Type RecordType {get;}

        Name Identifier {get;}

        string ITextual.Format()
            => Identifier.Format();
    }
}