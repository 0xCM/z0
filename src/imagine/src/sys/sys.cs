//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
        
    using static System.Runtime.CompilerServices.Unsafe;

    using static Konst;
    using static OpacityKind;
    using static As;
    
    using O = OpacityKind;

    [ApiHost]
    public readonly struct sys
    {
        const NumericKind Closure = AllNumeric;

        const MethodImplOptions Options = MethodImplOptions.NoInlining;

        
        [MethodImpl(Options), Opaque(O.Unbox), Closures(Closure)]
        public static ref T unbox<T>(object src)
            where T : struct
                => ref Unbox<T>(src);

        [MethodImpl(Options), Opaque(CreateString), Closures(Closure)]
        public static string @string<T>(T src)
            => src?.ToString() ?? EmptyString;
        
        [MethodImpl(Options), Opaque(O.Equals)]
        public static bool equals(object lhs, object rhs)
            => object.Equals(lhs,rhs);

        [MethodImpl(Options), Opaque(O.Equals), Closures(Closure)]
        public static bool equals<T>(T lhs, T rhs)
            where T : struct
                => lhs.Equals(rhs);

        [MethodImpl(Options), Opaque(Alloc), Closures(Closure)]
        public static T[] alloc<T>(int count)
            => new T[count];

        [MethodImpl(Options), Opaque(O.GetType), Closures(Closure)]
        public static Type type<T>()
            => typeof(T);

        [MethodImpl(Options), Opaque(O.GetType)]
        public static Type type(object src)
            => src?.GetType() ?? typeof(void);
        
        [MethodImpl(Options), Opaque(O.GetTypeCode), Closures(Closure)]
        public static TypeCode typecode<T>()
            => Type.GetTypeCode(typeof(T));

        [MethodImpl(Options), Opaque(O.GetTypeCode)]
        public static TypeCode typecode(Type src)
            => Type.GetTypeCode(src);

        [MethodImpl(Options), Opaque(O.Write), Closures(Closure)]
        public static void write<T>(in T src, ref byte dst)
            => WriteUnaligned(ref dst, src);

        [MethodImpl(Options), Opaque(O.Copy)]
        public static void copy(in byte src, ref byte dst, int count)
            => CopyBlock(ref dst, ref edit(src), (uint)count);

        [MethodImpl(Options), Opaque(O.Copy)]
        public static unsafe void copy(byte* pSrc, byte* pDst, int count)
            => CopyBlock(pDst, pSrc, (uint)count);


        [MethodImpl(Options), Opaque(O.Copy)]
        public static unsafe void copy<T>(T* pSrc, T* pDst, int count)
            where T : unmanaged
                => CopyBlock(pDst, pSrc, (uint)(count* Unsafe.SizeOf<T>()));
    }
}