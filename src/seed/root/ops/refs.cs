//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    
    using static System.Runtime.CompilerServices.Unsafe;
    using static System.Runtime.InteropServices.MemoryMarshal;

    using static Konst;


    partial class RootLegacy
    {
        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public static unsafe void copy<T>(MemRef src, Span<T> dst)
            where T : unmanaged
        {
            var reader = PointedReader.create<T>(src);
            reader.ReadAll(dst);
        }

        [MethodImpl(Inline), Op]
        public static Span<byte> replicate(MemRef src)
        {
            Span<byte> dst = sys.alloc<byte>(src.DataSize);            
            copy(src, dst);
            return dst;
        }
        
        /// <summary>
        /// Reimagines a boolean value as a character value
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline), Op]
        public static char @char(bool src)
            => (char)(u8(src) + 48);

        [MethodImpl(Inline)]
        public static char @char<S,T,N>(Symbol<S,T,N> src)
            where S : unmanaged
            where T : unmanaged
            where N : unmanaged, ITypeNat         
                => Unsafe.As<S,char>(ref edit(src.Value));

        [MethodImpl(Inline)]
        public static char @char<S,T>(Symbol<S,T> src)
            where S : unmanaged
            where T : unmanaged
                => Unsafe.As<S,char>(ref edit(src.Value));

        [MethodImpl(Inline)]
        public static char @char<S>(Symbol<S> src)
            where S : unmanaged
                => Unsafe.As<S,char>(ref edit(src.Value));

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static unsafe MemoryAddress locate<T>(in T src)
            => As.pvoid(src);

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static unsafe MemoryAddress address<P>(P* pSrc)
            where P : unmanaged
                => new MemoryAddress(pSrc);

        [MethodImpl(Inline), Op]
        public static unsafe MemoryAddress address(string src)
            => address(As.pchar(src));

        [MethodImpl(Inline), Op]
        public static void addresses(ReadOnlySpan<string> src, Span<MemoryAddress> dst)
        {
            ref readonly var r0 = ref As.first(src);
            for(var i=0; i<src.Length; i++)
                seek(dst,i) = address(skip(r0,i));
        }

        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public static unsafe Span<T> edit<T>(MemoryAddress src, int length)
            => CreateSpan(ref src.Ref<T>(), length);

        [MethodImpl(Inline), Op]
        public static unsafe Span<byte> edit(MemoryAddress src, int length)
            => CreateSpan(ref src.Ref<byte>(), length);

        /// <summary>
        /// Defines a memory reference
        /// </summary>
        /// <param name="address">The address</param>
        /// <param name="bytes">The number of reference bytes</param>
        [MethodImpl(Inline), Op]
        public static MemRef memref(MemoryAddress address, ByteSize bytes)
            => new MemRef(address,bytes);

        [MethodImpl(Inline), Op]
        public unsafe static MemRef memref(ReadOnlySpan<byte> src)
            => memref((ulong)As.gptr(src), src.Length);
        
        [MethodImpl(Inline), Op]
        public static unsafe MemRef memref(string src)
            => memref(address(src), src.Length*2);

        /// <summary>
        /// Presents a readonly S-reference as a readonly T-reference
        /// </summary>
        /// <param name="src">The data soruce</param>
        /// <typeparam name="S">The source type</typeparam>
        /// <typeparam name="T">The target type</typeparam>
        [MethodImpl(Inline)]
        public static ref readonly T view<S,T>(in S src)
            => ref Unsafe.As<S,T>(ref edit(src));


        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public static ReadOnlySpan<T> view<T>(in MemRef src)
            => CreateReadOnlySpan(ref @ref<T>(src.Address), src.Count<T>());


        [MethodImpl(Inline), Op]
        public static void refs(ReadOnlySpan<string> src, Span<StringRef> dst)
        {
            for(var i=0; i<src.Length; i++)
                seek(dst,i) = @ref(skip(src,i));
        }

        [MethodImpl(Inline), Op]
        public static StringRef[] refs(ReadOnlySpan<string> src)
        {
            var dst = sys.alloc<StringRef>(src.Length);
            refs(src,dst);
            return dst;
        }

        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public static unsafe ref T @ref<T>(MemoryAddress src)
            => ref AsRef<T>((void*)src.Location);

        [MethodImpl(Inline), Op]
        public static unsafe StringRef @ref(string src)
            => new StringRef(memref(src));                
    }
}