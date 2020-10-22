//-----------------------------------------------------------------------------
// Derivative Work
// Copyright  : Microsoft/.Net foundation
// Copyright  : (c) Chris Moore, 2020
// License    :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Buffers;
    using System.IO;
    using System.Runtime.CompilerServices;
    using System.Text;

    using static Konst;
    using static z;

    public unsafe struct ImageStream : IDisposable
    {
        public readonly Stream Stream;

        public readonly bool IsVirtual;

        uint Offset;

        [MethodImpl(Inline), Op]
        public ImageStream(Stream src, bool @virtual, uint offset = 0)
        {
            Stream = src;
            IsVirtual = @virtual;
            Offset = offset;
        }

        public void Dispose()
        {
            Stream.Dispose();
        }

        public void SeekTo(uint offset)
        {
            if (offset != Offset)
            {
                Stream.Seek(offset, SeekOrigin.Begin);
                Offset = offset;
            }
        }

        public string ReadString(uint offset, int len)
        {
            if (len > 4096)
                len = 4096;

            SeekTo(offset);

            byte[] buffer = ArrayPool<byte>.Shared.Rent(len);
            try
            {
                if (Stream.Read(buffer, 0, len) != len)
                    return null;

                int index = Array.IndexOf(buffer, (byte)'\0', 0, len);
                if (index >= 0)
                    len = index;

                return Encoding.ASCII.GetString(buffer, 0, len);
            }
            finally
            {
                ArrayPool<byte>.Shared.Return(buffer);
            }
        }

        public string ReadString(int len)
            => ReadString(Offset, len);

        public bool TryRead<T>(out T result)
            where T : unmanaged
                => TryRead(Offset, out result);

        public bool TryRead<T>(uint offset, out T t)
            where T : unmanaged
        {
            t = default;
            var size = z.size<T>();

            byte[] buffer = ArrayPool<byte>.Shared.Rent((int)size);
            try
            {
                SeekTo(offset);
                var read = (uint)Stream.Read(buffer, 0, (int)size);
                Offset = (offset + read);

                if (read != size)
                    return false;

                t = Unsafe.As<byte,T>(ref buffer[0]);

                return true;
            }
            finally
            {
                ArrayPool<byte>.Shared.Return(buffer);
            }
        }

        public T Read<T>(uint offset)
            where T : unmanaged
                => Read<T>(ref offset);

        public T Read<T>(ref uint offset)
            where T : unmanaged
        {
            int size = Unsafe.SizeOf<T>();
            T t = default;

            SeekTo(offset);
            var read = (uint)Stream.Read(new Span<byte>(&t, size));
            offset += read;
            Offset = offset;

            if (read != size)
                return default;
            return t;
        }

        public T Read<T>()
            where T : unmanaged
                => Read<T>(Offset);
    }
}