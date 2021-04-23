//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    public struct JsonDataPacket<T>
    {
        /// <summary>
        /// The fully-qualified content type name
        /// </summary>
        public string ContentType;

        public T Content;

        public JsonDataPacket(T content)
        {
            Content = content;
            ContentType = typeof(T).FullName;
        }

        [MethodImpl(Inline)]
        public static implicit operator JsonDataPacket<T>(T src)
            => new JsonDataPacket<T>(src);

        [MethodImpl(Inline)]
        public static implicit operator JsonDataPacket(JsonDataPacket<T> src)
            => new JsonDataPacket(src.Content);
    }
}