//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    using api = ApiDataTypes;

    /// <summary>
    /// Specifies a constructed data type
    /// </summary>
    public readonly struct ApiDataType
    {
        public uint StorageWidth {get;}

        public Type ContainerType {get;}

        public Type ContentType {get;}

        public Func<string> Formatter {get;}

        public bool IsFixedWidth => StorageWidth != 0;

        [MethodImpl(Inline)]
        public ApiDataType(IDataType rep, uint width = 0)
        {
            StorageWidth = width;
            ContainerType = rep.ContainerType;
            ContentType = rep.ContentType;
            Formatter = rep.Format;
        }

        [MethodImpl(Inline)]
        public ApiDataType(uint width, Type container, Type content, Func<string> formatter = null)
        {
            StorageWidth = width;
            ContainerType = container;
            ContentType = content;
            Formatter = formatter  ?? new Func<string>(() => container.Name);
        }

        public bool IsEmpty
            => ContainerType == null || ContainerType == typeof(void);

        public bool IsNonEmpty
            => !IsEmpty;

        public static ApiDataType Empty
            => api.empty();
    }

    public readonly struct EmptyDataType : IDataType<EmptyDataType>
    {
        public static EmptyDataType Instance => default(EmptyDataType);

        public Type ContentType => typeof(void);

        public Type ContainerType => typeof(void);

        public ushort Width => 0;

        public string Format()
            => "<empty>";

        [MethodImpl(Inline)]
        public bool Equals(IDataType other)
            => other.ContentType == ContentType && other.ContainerType == ContainerType;

        public static bool eq(ApiDataType other)
            => Instance.Equals(other);
    }
}