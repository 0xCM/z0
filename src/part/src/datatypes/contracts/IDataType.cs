//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using Free = System.Security.SuppressUnmanagedCodeSecurityAttribute;

    [Free]
    public interface IDataType : ISized, ITextual
    {

    }

    [Free]
    public interface IDataType<T> : IDataType
        where T : struct
    {
        T Content => (T)this;

        BitSize ISized.StorageWidth
            => Unsafe.SizeOf<T>();

        string ITextual.Format()
            => Content.ToString();
    }

    [Free]
    public interface IDataType<H,T> : IDataType<T>
        where H : struct, IDataType<H,T>
        where T : struct
    {

    }
}