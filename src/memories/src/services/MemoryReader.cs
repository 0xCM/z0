//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    
    using static Seed;
    using static Memories;

    public readonly struct MemoryReader : IMemoryReader
    {
        public IContext Context {get;}
        
        [MethodImpl(Inline)]
        public static MemoryReader Create(IContext context)
            => new MemoryReader(context);

        [MethodImpl(Inline)]
        MemoryReader(IContext context)
        {
            this.Context = context;
        }

        [MethodImpl(Inline)]
        public unsafe int Read(MemoryAddress src, int count, Span<byte> dst)
        {
            var pSrc = src.ToPointer<byte>();
            return Read(ref pSrc, count, dst);
        }

        [MethodImpl(Inline)]
        public unsafe int Read(MemoryAddress src, int count, ref byte dst)
        {
            var pSrc = src.ToPointer<byte>();
            return Read(ref pSrc, count, ref dst);
        }

        [MethodImpl(Inline)]
        unsafe int Read(ref byte* pSrc, int count, Span<byte> dst)
            => Read(ref pSrc, count, ref head(dst));

        unsafe int Read(ref byte* pSrc, int count, ref byte dst)
        {
            var offset = 0;
            var zcount = 0;
            while(offset < count && zcount < 10)        
            {
                var value = Unsafe.Read<byte>(pSrc++);
                seek(ref dst, offset++) = value;
                if(value != 0)
                    zcount = 0;
                else
                    zcount++;
            }
            return offset;
        }
    }

    public static class ReaderExtensions
    {
        [MethodImpl(Inline)]
        public static IMemoryReader MemoryReader(this IContext context)
            => Z0.MemoryReader.Create(context);        

    }    
}