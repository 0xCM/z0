//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{        
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static As;
    using static refs;

    /// <summary>
    /// Defines a bitreader that targets parametric unsigned numeric types
    /// </summary>
    [ApiHost("bytereader.g")]
    public readonly struct ByteReaderG : IApiHost<ByteReaderG>
    {
        /// <summary>
        /// Reads at most size[T] bytes as determined by the length of the data source
        /// </summary>
        /// <param name="src">The data source</param>
        /// <typeparam name="T">The unsigned numeric type</typeparam>
        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public T Read<T>(ReadOnlySpan<byte> src)
        {
            if(typeof(T) == typeof(byte))
                return generic<T>(ByteReader.Read(head(src), (byte)src.Length));
            else if(typeof(T) == typeof(ushort))
                return generic<T>(ByteReader.Read(head(src), (byte)src.Length));
            else if(typeof(T) == typeof(uint))
                return generic<T>(ByteReader.Read(head(src), (byte)src.Length));
            else if(typeof(T) == typeof(ulong))
                return generic<T>(ByteReader.Read(head(src), (byte)src.Length));
            else
                return default;
        }



    }
}