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
        bool IsFixedWidth => true;
    }

    [Free]
    public interface IDataType<T> : IDataType
        where T : struct
    {
        T Content => (T)this;

        BitSize ISized.StorageWidth
            => Unsafe.SizeOf<T>()*8;

        string ITextual.Format()
            => Content.ToString();
    }

    [Free]
    public interface IDataTypeComparable<T> : IDataType<T>, IComparable<T>
        where T : struct
    {

    }

    [Free]
    public interface IDataTypeEquatable<T> : IDataType<T>, IEquatable<T>
        where T : struct
    {

    }

    /// <summary>
    /// Characterizes an indexed <see cref='IDataType{T}'/> sequence
    /// </summary>
    /// <typeparam name="T">The datatype type</typeparam>
    [Free]
    public interface IDataTypeIndex<T> : IIndex<T>
        where T : struct, IDataType<T>
    {

    }

    [Free]
    public interface IDataType<W,T> : IDataType<T>
        where W : unmanaged, ITypeWidth<W>
        where T : struct
    {
        bool IDataType.IsFixedWidth
            => true;
    }
}