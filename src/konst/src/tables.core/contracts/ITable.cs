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

    /// <summary>
    /// Characterizes a discriminated table
    /// </summary>
    /// <typeparam name="F">The field type</typeparam>
    /// <typeparam name="T">The data type</typeparam>
    /// <typeparam name="D">The discriminator type</typeparam>
    [Free]
    public interface ITable<F,T,D> : ITable<F,T>
        where F : unmanaged, Enum
        where T : struct, ITable<F,T>
        where D : unmanaged, Enum
    {
        D Id {get;}
    }
}