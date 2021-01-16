//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    using api = DataTypes;

    /// <summary>
    /// Specifies a constructed data type
    /// </summary>
    /// <typeparam name="T">The content type and reifying type</typeparam>
    public readonly struct DataType
    {
        public uint StorageWidth {get;}

        public Type ContainerType {get;}

        public Type ContentType {get;}

        public Func<string> Formatter {get;}

        public bool IsFixedWidth => StorageWidth != 0;

        [MethodImpl(Inline)]
        public DataType(IDataType rep)
        {
            StorageWidth = rep.StorageWidth;
            ContainerType = rep.ContainerType;
            ContentType = rep.ContentType;
            Formatter = rep.Format;
        }

        public bool IsEmpty
            => EmptyDataType.eq(this);

        public bool IsNonEmpty
            => !IsEmpty;

        public static DataType Empty
            => api.empty();
    }

    public readonly struct EmptyDataType : IDataType<EmptyDataType>
    {
        public static EmptyDataType Instance => default(EmptyDataType);

        public Type ContentType => typeof(void);

        public Type ContainerType => typeof(void);

        public BitSize StorageWidth => 0;

        public string Format()
            => EmptyString;

        [MethodImpl(Inline)]
        public bool Equals(IDataType other)
        {
            return other.ContentType == ContentType
                && other.ContainerType == ContainerType;
        }

        public static bool eq(DataType other)
            => Instance.Equals(other);
    }
}