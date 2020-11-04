//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Security;

    using Free = System.Security.SuppressUnmanagedCodeSecurityAttribute;

    [Free]
    public interface IDataRow
    {
        BinaryCode[] Cells {get;}
    }

    [Free]
    public interface IDataRow<F> : IDataRow
        where F : unmanaged
    {
        ref BinaryCode this[F index] {get;}
    }

    [Free]
    public interface IDataRow<F,T> : IDataRow<F>
        where F : unmanaged
        where T : struct
    {
        T Data {get;}
    }
}