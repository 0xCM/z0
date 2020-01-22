//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Security;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using System.Runtime.Intrinsics;
    using System.Reflection;
    using System.Reflection.Emit;

    using static zfunc;
    
    [SuppressUnmanagedCodeSecurity]
    public static unsafe class FixedDelegates
    {
        /// <summary>
        /// Creates a unary operator over a primal type defined by supplied asm code
        /// </summary>
        /// <param name="address">A pointer to executable memory loaded with selected code</param>
        /// <param name="name">Identity conferred to the manufactured operator</param>
        /// <typeparam name="T">The primal operand type</typeparam>
        [MethodImpl(Inline)]
        public static UnaryOp<T> UnaryOp<T>(Moniker m, IntPtr address)
            where T : unmanaged
                => (UnaryOp<T>)Dynop.fixedUnary(m,address,typeof(T), typeof(UnaryOp<T>));

        /// <summary>
        /// Creates a binary operator over a primal type to execute specified asm code
        /// </summary>
        /// <param name="address">A pointer to executable memory loaded with selected code</param>
        /// <param name="name">Identity conferred to the manufactured operator</param>
        /// <typeparam name="T">The primal operand type</typeparam>
        [MethodImpl(Inline)]
        public static BinaryOp<T> BinOp<T>(Moniker m, IntPtr address)
            where T : unmanaged
                => (BinaryOp<T>)Dynop.fixedBinary(m,address, typeof(T), typeof(BinaryOp<T>));

        /// <summary>
        /// Creates a 8-bit unary operator over a specified executable memory location
        /// </summary>
        /// <param name="address">A pointer to executable memory loaded with selected code</param>
        /// <param name="name">Identity conferred to the manufactured operator</param>
        [MethodImpl(Inline)]
        public static UnaryOp8 UnaryOp(N8 w, Moniker m, IntPtr address)
            => (UnaryOp8)Dynop.fixedUnary(m, address, typeof(Fixed8), typeof(UnaryOp8));

        /// <summary>
        /// Creates a 16-bit unary operator over a specified executable memory location
        /// </summary>
        /// <param name="address">A pointer to executable memory loaded with selected code</param>
        /// <param name="name">Identity conferred to the manufactured operator</param>
        [MethodImpl(Inline)]
        public static UnaryOp16 UnaryOp(N16 w, Moniker m, IntPtr address)
            => (UnaryOp16)Dynop.fixedUnary(m, address, typeof(Fixed16), typeof(UnaryOp16));

        /// <summary>
        /// Creates a 32-bit unary operator over a specified executable memory location
        /// </summary>
        /// <param name="address">A pointer to executable memory loaded with selected code</param>
        /// <param name="name">Identity conferred to the manufactured operator</param>
        [MethodImpl(Inline)]
        public static UnaryOp32 UnaryOp(N32 w, Moniker m, IntPtr address)
            => (UnaryOp32)Dynop.fixedUnary(m, address, typeof(Fixed32), typeof(UnaryOp32));

        /// <summary>
        /// Creates a 64-bit unary operator over a specified executable memory location
        /// </summary>
        /// <param name="address">A pointer to executable memory loaded with selected code</param>
        /// <param name="name">Identity conferred to the manufactured operator</param>
        [MethodImpl(Inline)]
        public static UnaryOp64 UnaryOp(N64 w, Moniker m, IntPtr address)
            => (UnaryOp64)Dynop.fixedUnary(m, address, typeof(Fixed64), typeof(UnaryOp64));

        /// <summary>
        /// Creates a 128-bit unary operator defined by supplied asm code
        /// </summary>
        /// <param name="address">A pointer to executable memory loaded with selected code</param>
        /// <param name="name">Identity conferred to the manufactured operator</param>
        [MethodImpl(Inline)]
        public static UnaryOp128 UnaryOp(N128 w, Moniker m, IntPtr address)
            => (UnaryOp128)Dynop.fixedUnary(m, address, typeof(Fixed128), typeof(UnaryOp128));

        /// <summary>
        /// Creates a 256-bit unary operator defined by supplied asm code
        /// </summary>
        /// <param name="address">A pointer to executable memory loaded with selected code</param>
        /// <param name="name">Identity conferred to the manufactured operator</param>
        [MethodImpl(Inline)]
        public static UnaryOp256 UnaryOp(N256 w, Moniker m, IntPtr address)
            => (UnaryOp256)Dynop.fixedUnary(m, address, typeof(Fixed256), typeof(UnaryOp256));

        /// <summary>
        /// Creates a 8-bit binary operator over a specified executable memory location
        /// </summary>
        /// <param name="address">A pointer to executable memory loaded with selected code</param>
        /// <param name="name">Identity conferred to the manufactured operator</param>
        [MethodImpl(Inline)]
        public static BinaryOp8 BinOp(N8 w,Moniker m, IntPtr address)
            => (BinaryOp8)Dynop.fixedBinary(m,address, typeof(Fixed8), typeof(BinaryOp8));

        /// <summary>
        /// Creates a 32-bit binary operator over a specified executable memory location
        /// </summary>
        /// <param name="address">A pointer to executable memory loaded with selected code</param>
        /// <param name="name">Identity conferred to the manufactured operator</param>
        [MethodImpl(Inline)]
        public static BinaryOp16 BinOp(N16 w, Moniker id, IntPtr address)
            => (BinaryOp16)Dynop.fixedBinary(id,address, typeof(Fixed16), typeof(BinaryOp16));

        /// <summary>
        /// Creates a 32-bit binary operator over a specified executable memory location
        /// </summary>
        /// <param name="address">A pointer to executable memory loaded with selected code</param>
        /// <param name="name">Identity conferred to the manufactured operator</param>
        [MethodImpl(Inline)]
        public static BinaryOp32 BinOp(N32 w, Moniker id, IntPtr address)
            => (BinaryOp32)Dynop.fixedBinary(id,address, typeof(Fixed32), typeof(BinaryOp32));

        /// <summary>
        /// Creates a 64-bit binary operator over a specified executable memory location
        /// </summary>
        /// <param name="address">A pointer to executable memory loaded with selected code</param>
        /// <param name="name">Identity conferred to the manufactured operator</param>
        [MethodImpl(Inline)]
        public static BinaryOp64 BinOp(N64 w, Moniker id, IntPtr address)
            => (BinaryOp64)Dynop.fixedBinary(id,address, typeof(Fixed64), typeof(BinaryOp64));

        /// <summary>
        /// Creates a 128-bit binary operator over a specified executable memory location
        /// </summary>
        /// <param name="address">A pointer to executable memory loaded with selected code</param>
        /// <param name="name">Identity conferred to the manufactured operator</param>
        [MethodImpl(Inline)]
        public static BinaryOp128 BinOp(N128 w, Moniker id, IntPtr address)
            => (BinaryOp128)Dynop.fixedBinary(id,address, typeof(Fixed128), typeof(BinaryOp128));

        /// <summary>
        /// Creates a 256-bit binary operator over a specified executable memory location
        /// </summary>
        /// <param name="address">A pointer to executable memory loaded with selected code</param>
        /// <param name="name">Identity conferred to the manufactured operator</param>
        [MethodImpl(Inline)]
        public static BinaryOp256 BinOp(N256 w, Moniker id, IntPtr address)
            => (BinaryOp256)Dynop.fixedBinary(id,address, typeof(Fixed256), typeof(BinaryOp256));

        [MethodImpl(Inline)]
        public static UnaryOp8 UnaryOp(Func<byte,byte> f, PrimalKind<byte> k = default)
            => (Fixed8 a) =>f(a.X0);

        [MethodImpl(Inline)]
        public static UnaryOp8 UnaryOp(Func<sbyte,sbyte> f, PrimalKind<sbyte> k = default)
            => (Fixed8 a) =>f((sbyte)a.X0);

        [MethodImpl(Inline)]
        public static UnaryOp16 UnaryOp(Func<ushort,ushort> f, PrimalKind<ushort> k = default)
            => (Fixed16 a) =>f(a.X0);

        [MethodImpl(Inline)]
        public static UnaryOp16 UnaryOp(Func<short,short> f, PrimalKind<short> k = default)
            => (Fixed16 a) =>f((short)a.X0);

        [MethodImpl(Inline)]
        public static UnaryOp32 UnaryOp(Func<uint,uint> f, PrimalKind<uint> k = default)
            => (Fixed32 a) =>f(a.X0);

        [MethodImpl(Inline)]
        public static UnaryOp32 UnaryOp(Func<int,int> f, PrimalKind<int> k = default)
            => (Fixed32 a) =>f((int)a.X0);

        [MethodImpl(Inline)]
        public static UnaryOp64 UnaryOp(Func<ulong,ulong> f, PrimalKind<ulong> k = default)
            => (Fixed64 a) =>f(a.X0);

        [MethodImpl(Inline)]
        public static UnaryOp64 UnaryOp(Func<long,long> f, PrimalKind<long> k = default)
            => (Fixed64 a) =>f((long)a.X0);
    
        [MethodImpl(Inline)]
        public static UnaryOp128 UnaryOp<T>(Func<Vector128<T>,Vector128<T>> f, VectorKind128<T> k = default)
            where T : unmanaged
                => (Fixed128 a) =>f(a.ToVector<T>()).ToFixed();

        [MethodImpl(Inline)]
        public static UnaryOp256 UnaryOp<T>(Func<Vector256<T>,Vector256<T>> f, VectorKind256<T> k = default)
            where T : unmanaged
                => (Fixed256 a) =>f(a.ToVector<T>()).ToFixed();

        [MethodImpl(Inline)]
        public static BinaryOp8 BinOp(Func<byte,byte,byte> f, PrimalKind<byte> k = default)
            => (Fixed8 a, Fixed8 b) =>f(a.X0, b.X0);

        [MethodImpl(Inline)]
        public static BinaryOp8 BinOp(Func<sbyte,sbyte,sbyte> f, PrimalKind<sbyte> k = default)
            => (Fixed8 a, Fixed8 b) =>f((sbyte)a.X0, (sbyte)b.X0);

        [MethodImpl(Inline)]
        public static BinaryOp16 BinOp(Func<ushort,ushort,ushort> f, PrimalKind<ushort> t = default)
            => (Fixed16 a, Fixed16 b) =>f(a.X0, b.X0);

        [MethodImpl(Inline)]
        public static BinaryOp16 BinOp(Func<short,short,short> f, PrimalKind<short> k = default)
            => (Fixed16 a, Fixed16 b) =>f((short)a.X0, (short)b.X0);

        [MethodImpl(Inline)]
        public static BinaryOp32 BinOp(Func<uint,uint,uint> f, PrimalKind<uint> k = default)
            => (Fixed32 a, Fixed32 b) =>f(a.X0, b.X0);

        [MethodImpl(Inline)]
        public static BinaryOp32 BinOp(Func<int,int,int> f, PrimalKind<int> k = default)
            => (Fixed32 a, Fixed32 b) =>f((int)a.X0, (int)b.X0);

        [MethodImpl(Inline)]
        public static BinaryOp64 BinOp(Func<ulong,ulong,ulong> f, PrimalKind<ulong> k = default)
            => (Fixed64 a, Fixed64 b) =>f(a.X0, b.X0);

        [MethodImpl(Inline)]
        public static BinaryOp64 BinOp(Func<long,long,long> f, PrimalKind<long> k = default)
            => (Fixed64 a, Fixed64 b) =>f((long)a.X0, (long)b.X0);

        [MethodImpl(Inline)]
        public static BinaryOp8 BinOp(MethodInfo f, PrimalKind<byte> k)
            => BinOp(f.CreateDelegate<Func<byte,byte,byte>>(),k);

        [MethodImpl(Inline)]
        public static BinaryOp16 BinOp(MethodInfo f, PrimalKind<ushort> k)
            => BinOp(f.CreateDelegate<Func<ushort,ushort,ushort>>(),k);

        [MethodImpl(Inline)]
        public static BinaryOp32 BinOp(MethodInfo f, PrimalKind<uint> k)
            => BinOp(f.CreateDelegate<Func<uint,uint,uint>>(),k);

        [MethodImpl(Inline)]
        public static BinaryOp64 BinOp(MethodInfo f, PrimalKind<ulong> k)
            => BinOp(f.CreateDelegate<Func<ulong,ulong,ulong>>(),k);

        [MethodImpl(Inline)]
        public static BinaryOp128 BinOp<T>(Func<Vector128<T>,Vector128<T>,Vector128<T>> f, VectorKind128<T> k = default)
            where T : unmanaged
                => (Fixed128 a, Fixed128 b) =>f(a.ToVector<T>(),b.ToVector<T>()).ToFixed();

        [MethodImpl(Inline)]
        public static BinaryOp256 BinOp<T>(Func<Vector256<T>,Vector256<T>,Vector256<T>> f, VectorKind256<T> k = default)
            where T : unmanaged
                => (Fixed256 a, Fixed256 b) =>f(a.ToVector<T>(),b.ToVector<T>()).ToFixed();             
    }
}