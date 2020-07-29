//-----------------------------------------------------------------------------
// Derivative Work
// Copyright  : Microsft/.Net foundation
// Copyright  : (c) Chris Moore, 2020
// License    :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Image
{
    using System;
    using System.Buffers;
    using System.IO;
    using System.Linq;
    using System.Runtime.CompilerServices;
    using System.Text;

    public unsafe struct SourceStream : IDisposable
    {
        public static SourceStream create(Stream src, bool virt = false)
            => new SourceStream(src,virt);
        
        public readonly Stream Stream;
        
        public readonly bool IsVirtual;

        int Offset;

        SourceStream(Stream src, bool @virtual)
        {
            Stream = src;
            IsVirtual = @virtual;
            Offset = 0;
        }    

        public void SeekTo(int offset)
        {
            if (offset != Offset)
            {
                Stream.Seek(offset, SeekOrigin.Begin);
                Offset = offset;
            }
        }

        public void SeekTo(uint offset)
        {
            if (offset != Offset)
            {
                Stream.Seek(offset, SeekOrigin.Begin);
                Offset = (int)offset;
            }
        }

        public string ReadString(int offset, int len)
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
            where T : unmanaged => TryRead(Offset, out result);

        public bool TryRead<T>(int offset, out T t) 
            where T : unmanaged
        {
            t = default;
            int size = Unsafe.SizeOf<T>();

            byte[] buffer = ArrayPool<byte>.Shared.Rent(size);
            try
            {
                SeekTo(offset);
                int read = Stream.Read(buffer, 0, size);
                Offset = offset + read;

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

        public bool TryRead<T>(uint offset, out T t) 
            where T : unmanaged
        {
            t = default;
            int size = Unsafe.SizeOf<T>();

            byte[] buffer = ArrayPool<byte>.Shared.Rent(size);
            try
            {
                SeekTo((int)offset);
                int read = Stream.Read(buffer, 0, size);
                Offset = (int)(offset + read);

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

        public T Read<T>(int offset) where T : unmanaged 
            => Read<T>(ref offset);

        public T Read<T>(ref int offset) where T : unmanaged
        {
            int size = Unsafe.SizeOf<T>();
            T t = default;

            SeekTo(offset);
            int read = Stream.Read(new Span<byte>(&t, size));
            offset += read;
            Offset = offset;

            if (read != size)
                return default;
            return t;
        }

        public T Read<T>() 
            where T : unmanaged 
                => Read<T>(Offset);


        public void Dispose()
        {
            Stream.Dispose();
        }
    }
}