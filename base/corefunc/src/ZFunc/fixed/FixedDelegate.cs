//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using System.Runtime.Intrinsics;
    using System.Reflection;

    using static zfunc;
    using static Classifiers;

    public static class FixedDelegate
    {
        [MethodImpl(Inline)]
        public static UnaryOp8 from(Func<byte,byte> f, Primal8u k = default)
            => (Fixed8 a) =>f(a.X0);

        [MethodImpl(Inline)]
        public static UnaryOp8 from(Func<sbyte,sbyte> f, Primal8i k = default)
            => (Fixed8 a) =>f((sbyte)a.X0);

        [MethodImpl(Inline)]
        public static UnaryOp16 from(Func<ushort,ushort> f, Primal16u k = default)
            => (Fixed16 a) =>f(a.X0);

        [MethodImpl(Inline)]
        public static UnaryOp16 from(Func<short,short> f, Primal16i k = default)
            => (Fixed16 a) =>f((short)a.X0);

        [MethodImpl(Inline)]
        public static UnaryOp32 from(Func<uint,uint> f, Primal32u k = default)
            => (Fixed32 a) =>f(a.X0);

        [MethodImpl(Inline)]
        public static UnaryOp32 from(Func<int,int> f, Primal32i k = default)
            => (Fixed32 a) =>f((int)a.X0);

        [MethodImpl(Inline)]
        public static UnaryOp64 from(Func<ulong,ulong> f, Primal64u k = default)
            => (Fixed64 a) =>f(a.X0);
            
        [MethodImpl(Inline)]
        public static UnaryOp64 from(Func<long,long> f, Primal64i k = default)
            => (Fixed64 a) =>f((long)a.X0);
    
        [MethodImpl(Inline)]
        public static UnaryOp128 from<T>(Func<Vector128<T>,Vector128<T>> f, VectorKind128<T> k = default)
            where T : unmanaged
                => (Fixed128 a) =>f(a.ToVector<T>()).ToFixed();

        [MethodImpl(Inline)]
        public static UnaryOp256 from<T>(Func<Vector256<T>,Vector256<T>> f, VectorKind256<T> k = default)
            where T : unmanaged
                => (Fixed256 a) =>f(a.ToVector<T>()).ToFixed();

        [MethodImpl(Inline)]
        public static BinaryOp8 from(Func<byte,byte,byte> f, Primal8u k = default)
            => (Fixed8 a, Fixed8 b) =>f(a.X0, b.X0);

        [MethodImpl(Inline)]
        public static BinaryOp8 from(Func<sbyte,sbyte,sbyte> f, Primal8i k = default)
            => (Fixed8 a, Fixed8 b) =>f((sbyte)a.X0, (sbyte)b.X0);

        [MethodImpl(Inline)]
        public static BinaryOp16 from(Func<ushort,ushort,ushort> f, Primal16u t = default)
            => (Fixed16 a, Fixed16 b) =>f(a.X0, b.X0);

        [MethodImpl(Inline)]
        public static BinaryOp16 from(Func<short,short,short> f, Primal16i k = default)
            => (Fixed16 a, Fixed16 b) =>f((short)a.X0, (short)b.X0);

        [MethodImpl(Inline)]
        public static BinaryOp32 from(Func<uint,uint,uint> f, Primal32u k = default)
            => (Fixed32 a, Fixed32 b) =>f(a.X0, b.X0);

        [MethodImpl(Inline)]
        public static BinaryOp32 from(Func<int,int,int> f, Primal32i k = default)
            => (Fixed32 a, Fixed32 b) =>f((int)a.X0, (int)b.X0);

        [MethodImpl(Inline)]
        public static BinaryOp64 from(Func<ulong,ulong,ulong> f, Primal64u k = default)
            => (Fixed64 a, Fixed64 b) =>f(a.X0, b.X0);

        [MethodImpl(Inline)]
        public static BinaryOp8 binop(MethodInfo f, Primal8u k)
            => from(f.CreateDelegate<Func<byte,byte,byte>>(),k);

        [MethodImpl(Inline)]
        public static BinaryOp16 binop(MethodInfo f, Primal16u k)
            => from(f.CreateDelegate<Func<ushort,ushort,ushort>>(),k);

        [MethodImpl(Inline)]
        public static BinaryOp32 binop(MethodInfo f, Primal32u k)
            => from(f.CreateDelegate<Func<uint,uint,uint>>(),k);

        [MethodImpl(Inline)]
        public static BinaryOp64 binop(MethodInfo f, Primal64u k)
            => from(f.CreateDelegate<Func<ulong,ulong,ulong>>(),k);

        [MethodImpl(Inline)]
        public static BinaryOp64 from(Func<long,long,long> f, Primal64i k = default)
            => (Fixed64 a, Fixed64 b) =>f((long)a.X0, (long)b.X0);

        [MethodImpl(Inline)]
        public static BinaryOp128 from<T>(Func<Vector128<T>,Vector128<T>,Vector128<T>> f, VectorKind128<T> k = default)
            where T : unmanaged
                => (Fixed128 a, Fixed128 b) =>f(a.ToVector<T>(),b.ToVector<T>()).ToFixed();

        [MethodImpl(Inline)]
        public static BinaryOp256 from<T>(Func<Vector256<T>,Vector256<T>,Vector256<T>> f, VectorKind256<T> k = default)
            where T : unmanaged
                => (Fixed256 a, Fixed256 b) =>f(a.ToVector<T>(),b.ToVector<T>()).ToFixed();

    }
}