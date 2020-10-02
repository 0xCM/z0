//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using Free = System.Security.SuppressUnmanagedCodeSecurityAttribute;

    [Free]
    public interface ITable : ITextual
    {
        string FormatPattern
            => "{0}";

        string ITextual.Format()
            => string.Format(FormatPattern, this);
    }

    [Free]
    public interface ITable<T> : ITable
        where T : struct
    {

    }

    [Free]
    public interface ITable<F,T> : ITable<T>
        where T : struct, ITable<F,T>
        where F : unmanaged
    {

    }


}