//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{        
    using System;
    using System.Security;

    [SuppressUnmanagedCodeSecurity]
    public interface ITable : ITextual
    {
        string ITextual.Format()
            => "Unformatted";
    }
    
    [SuppressUnmanagedCodeSecurity]
    public interface ITable<T> : ITable
        where T : struct
    {

    }

    [SuppressUnmanagedCodeSecurity]
    public interface ITable<F,T> : ITable<T>
        where T : struct, ITable<F,T>
        where F : unmanaged, Enum
    {

    }    

    /// <summary>
    /// Characterizes a discriminated table 
    /// </summary>
    /// <typeparam name="F">The field type</typeparam>
    /// <typeparam name="T">The data type</typeparam>
    /// <typeparam name="D">The discriminator type</typeparam>
    [SuppressUnmanagedCodeSecurity]
    public interface ITable<F,T,D> : ITable<F,T>
        where F : unmanaged, Enum
        where T : struct, ITable<F,T>
        where D : unmanaged, Enum
    {
        D Id {get;}
    }
}