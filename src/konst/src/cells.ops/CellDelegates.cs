//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Reflection;
    using System.Runtime.Intrinsics;
    using System.Reflection.Emit;

    using static Konst;

    using Free = System.Security.SuppressUnmanagedCodeSecurityAttribute;

    [ApiHost(ApiNames.CellDelegates, true)]
    public readonly struct CellDelegates
    {
        const NumericKind Closure = Integers;

        [MethodImpl(Inline)]
        public static CellDelegate define(OpIdentity id, MemoryAddress src, DynamicMethod enclosure, Delegate dynop)
            => new CellDelegate(id,src,enclosure,dynop);

        /// <summary>
        /// Creates a fixed 8-bit binary operator from caller-supplied delegate
        /// </summary>
        /// <param name="f">The source delegate</param>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static UnaryOp8 define<T>(Func<T,T> f, U8 dst)
            where T : unmanaged
                => (Cell8 a) => Cells.c8(f(a.As<T>()));

        /// <summary>
        /// Creates a fixed 16-bit binary operator from caller-supplied delegate
        /// </summary>
        /// <param name="f">The source delegate</param>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static UnaryOp16 define<T>(Func<T,T> f, U16 dst)
            where T : unmanaged
                => (Cell16 a) => Cells.c16(f(a.As<T>()));

        /// <summary>
        /// Creates a fixed 32-bit binary operator from caller-supplied delegate
        /// </summary>
        /// <param name="f">The source delegate</param>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static UnaryOp32 define<T>(Func<T,T> f, U32 dst)
            where T : unmanaged
                => (Cell32 a) => Cells.c32(f(a.As<T>()));

        /// <summary>
        /// Creates a fixed 64-bit binary operator from caller-supplied delegate
        /// </summary>
        /// <param name="f">The source delegate</param>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static UnaryOp64 define<T>(Func<T,T> f, U64 dst)
            where T : unmanaged
                => (Cell64 a) => Cells.c64(f(a.As<T>()));

        /// <summary>
        /// Creates a fixed 16-bit binary operator from caller-supplied delegate
        /// </summary>
        /// <param name="f">The source delegate</param>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static BinaryOp8 define<T>(Func<T,T,T> f, U8 dst)
            where T : unmanaged
                => (Cell8 a, Cell8 b) => Cells.c8(f(a.As<T>(),b.As<T>()));

        /// <summary>
        /// Creates a fixed 16-bit binary operator from caller-supplied delegate
        /// </summary>
        /// <param name="f">The source delegate</param>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static BinaryOp16 define<T>(Func<T,T,T> f, U16 dst)
            where T : unmanaged
                => (Cell16 a, Cell16 b) => Cells.c16(f(a.As<T>(),b.As<T>()));

        /// <summary>
        /// Creates a fixed 32-bit binary operator from caller-supplied delegate
        /// </summary>
        /// <param name="f">The source delegate</param>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static BinaryOp32 define<T>(Func<T,T,T> f, U32 dst)
            where T : unmanaged
                => (Cell32 a, Cell32 b) => Cells.c32(f(a.As<T>(),b.As<T>()));

        /// <summary>
        /// Creates a fixed 64-bit binary operator from caller-supplied delegate
        /// </summary>
        /// <param name="f">The source delegate</param>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static BinaryOp64 define<T>(Func<T,T,T> f, U64 dst)
            where T : unmanaged
                => (Cell64 a, Cell64 b) => Cells.c64(f(a.As<T>(),b.As<T>()));

        [MethodImpl(Inline), Op, Closures(Closure)]
        internal static UnaryOp<T> uFx<T>(MethodInfo src, UnaryOpClass<T> k)
            where T : unmanaged
                => Delegates.unary<T>(src);

        [MethodImpl(Inline), Op, Closures(Closure)]
        internal static BinaryOp<T> bFx<T>(MethodInfo src, BinaryOpClass<T> K)
            where T : unmanaged
                => Delegates.binary<T>(src);

        /// <summary>
        /// Manufactures a fixed-parametric unary operator from T-parametric unary operator
        /// </summary>
        /// <param name="f">The source operator</param>
        /// <typeparam name="F">The target operand type</typeparam>
        /// <typeparam name="T">The source operand type</typeparam>
        [MethodImpl(Inline)]
        public static UnaryOp<F> define<F,T>(UnaryOp<T> f)
            where F : unmanaged, IDataCell
            where T : unmanaged
                => a => Cells.fix<T,F>(f(Cells.unfix<F,T>(a)));

        /// <summary>
        /// Manufactures a fixed-parametric binary operator from T-parametric binary operator
        /// </summary>
        /// <param name="f">The source operator</param>
        /// <typeparam name="F">The target operand type</typeparam>
        /// <typeparam name="T">The source operand type</typeparam>
        [MethodImpl(Inline)]
        public static BinaryOp<F> define<F,T>(BinaryOp<T> f)
            where F : unmanaged, IDataCell
            where T : unmanaged
                => (F a, F b) => Cells.fix<T,F>(f(Cells.unfix<F,T>(a), Cells.unfix<F,T>(b)));

        /// <summary>
        /// Manufactures a T-parametric unary operator from a fixed-parametric unary operator
        /// </summary>
        /// <param name="f">The source operator</param>
        /// <typeparam name="F">The source operand type</typeparam>
        /// <typeparam name="T">The target operand type</typeparam>
        [MethodImpl(Inline)]
        public static UnaryOp<T> revert<F,T>(UnaryOp<F> f)
            where F : unmanaged, IDataCell
            where T : unmanaged
                => a => Cells.unfix<F,T>(f(Cells.fix<T,F>(a)));

        /// <summary>
        /// Manufactures a T-parametric binary operator from a fixed-parametric binary operator
        /// </summary>
        /// <param name="f">The source operator</param>
        /// <typeparam name="F">The source operand type</typeparam>
        /// <typeparam name="T">The target operand type</typeparam>
        [MethodImpl(Inline)]
        public static BinaryOp<T> revert<F,T>(BinaryOp<F> f)
            where F : unmanaged, IDataCell
            where T : unmanaged
                => (T a, T b) => Cells.unfix<F,T>(f(Cells.fix<T,F>(a), Cells.fix<T,F>(b)));

        [MethodImpl(Inline), Op]
        public static BinaryOp1 define(BinaryOp<bit> f)
            => (a,b) => f(a,b);

        [MethodImpl(Inline), Op]
        public static BinaryOp8 define(BinaryOp<sbyte> f)
            => (a, b) => f((sbyte)a.Content, (sbyte)b.Content);

        [MethodImpl(Inline), Op]
        public static BinaryOp8 define(BinaryOp<byte> f)
            => (a, b) => f(a.Content, b.Content);

        [MethodImpl(Inline), Op]
        public static BinaryOp16 define(BinaryOp<short> f)
            => (a, b) => f((short)a.Content, (short)b.Content);

        [MethodImpl(Inline), Op]
        public static BinaryOp16 define(BinaryOp<ushort> f)
            => (a, b) => f(a.Content, b.Content);

        [MethodImpl(Inline), Op]
        public static BinaryOp32 define(BinaryOp<int> f)
            => (a, b) => f((int)a.Content, (int)b.Content);

        [MethodImpl(Inline), Op]
        public static BinaryOp32 define(BinaryOp<uint> f)
            => (a, b)  => f(a.Content, b.Content);

        [MethodImpl(Inline), Op]
        public static BinaryOp64 define(BinaryOp<long> f)
            => (a, b)  => f((long)a.Content, (long)b.Content);

        [MethodImpl(Inline), Op]
        public static BinaryOp64 define(BinaryOp<ulong> f)
            => (a, b)  => f(a.Content, b.Content);

        [MethodImpl(Inline), Op]
        public static Emitter1 define(Emitter<bit> f)
            => () => f();

        [MethodImpl(NotInline), Op]
        public static Emitter8 define(Emitter<sbyte> f)
            => () => f();

        [MethodImpl(NotInline), Op]
        public static Emitter8 define(Emitter<byte> f)
            => () => f();

        [MethodImpl(NotInline), Op]
        public static Emitter16 define(Emitter<short> f)
            => () => f();

        [MethodImpl(NotInline), Op]
        public static Emitter16 define(Emitter<ushort> f)
            => () => f();

        [MethodImpl(NotInline), Op]
        public static Emitter32 define(Emitter<int> f)
            => () => f();

        [MethodImpl(NotInline), Op]
        public static Emitter32 define(Emitter<uint> f)
            => () => f();

        [MethodImpl(NotInline), Op]
        public static Emitter64 define(Emitter<long> f)
            => () => f();

        [MethodImpl(NotInline), Op]
        public static Emitter64 define(Emitter<ulong> f)
            => () => f();

        [MethodImpl(NotInline), Op]
        public static UnaryOp1 define(MethodInfo f, UnaryOpClass<bit> k)
            => define(uFx(f,k));

        [MethodImpl(NotInline), Op]
        public static UnaryOp8 define(MethodInfo f, UnaryOpClass<sbyte> k)
            => define(uFx(f,k));

        [MethodImpl(NotInline), Op]
        public static UnaryOp8 define(MethodInfo f, UnaryOpClass<byte> k)
            => define(uFx(f,k));

        [MethodImpl(NotInline), Op]
        public static UnaryOp16 define(MethodInfo f, UnaryOpClass<short> k)
            => define(uFx(f,k));

        [MethodImpl(NotInline), Op]
        public static UnaryOp16 define(MethodInfo f, UnaryOpClass<ushort> k)
            => define(uFx(f,k));

        [MethodImpl(NotInline), Op]
        public static UnaryOp32 define(MethodInfo f, UnaryOpClass<int> k)
            => define(uFx(f,k));

        [MethodImpl(NotInline), Op]
        public static UnaryOp32 define(MethodInfo f, UnaryOpClass<uint> k)
            => define(uFx(f,k));

        [MethodImpl(NotInline), Op]
        public static UnaryOp64 define(MethodInfo f, UnaryOpClass<long> k )
            => define(uFx(f,k));

        [MethodImpl(NotInline), Op]
        public static UnaryOp64 define(MethodInfo f, UnaryOpClass<ulong> k)
            => define(uFx(f,k));

        [MethodImpl(Inline), Op]
        public static BinaryOp1 define(MethodInfo f, BinaryOpClass<bit> k)
            => define(bFx(f,k));

        [MethodImpl(Inline), Op]
        public static BinaryOp8 define(MethodInfo f, BinaryOpClass<sbyte> k)
            => define(bFx(f,k));

        [MethodImpl(Inline), Op]
        public static BinaryOp8 define(MethodInfo f, BinaryOpClass<byte> k)
            => define(bFx(f,k));

        [MethodImpl(Inline), Op]
        public static BinaryOp16 define(MethodInfo f, BinaryOpClass<short> k)
            => define(bFx(f,k));

        [MethodImpl(Inline), Op]
        public static BinaryOp16 define(MethodInfo f, BinaryOpClass<ushort> k)
            => define(bFx(f,k));

        [MethodImpl(Inline), Op]
        public static BinaryOp32 define(MethodInfo f, BinaryOpClass<uint> k)
            => define(bFx(f,k));

        [MethodImpl(Inline), Op]
        public static BinaryOp32 define(MethodInfo f, BinaryOpClass<int> k)
            => define(bFx(f,k));

        [MethodImpl(Inline), Op]
        public static BinaryOp64 define(MethodInfo f, BinaryOpClass<ulong> k)
            => define(bFx(f,k));

        [MethodImpl(Inline), Op]
        public static BinaryOp64 define(MethodInfo f, BinaryOpClass<long> k)
            => define(bFx(f,k));

        [MethodImpl(Inline), Op]
        public static UnaryOp1 define(UnaryOp<bit> f)
            => a => f(a);

        [MethodImpl(Inline), Op]
        public static UnaryOp8 define(UnaryOp<sbyte> f)
            => a => f((sbyte)a.Content);

        [MethodImpl(Inline), Op]
        public static UnaryOp8 define(UnaryOp<byte> f)
            => a => f((byte)a.Content);

        [MethodImpl(Inline), Op]
        public static UnaryOp16 define(UnaryOp<short> f)
            => a => f((short)a.Content);

        [MethodImpl(Inline), Op]
        public static UnaryOp16 define(UnaryOp<ushort> f)
            => a => f((ushort)a.Content);

        [MethodImpl(Inline), Op]
        public static UnaryOp32 define(UnaryOp<int> f)
            => a => f((int)a.Content);

        [MethodImpl(Inline), Op]
        public static UnaryOp32 define(UnaryOp<uint> f)
            => a => f((uint)a.Content);

        [MethodImpl(Inline), Op]
        public static UnaryOp64 define(UnaryOp<long> f)
            => a => f((long)a.Content);

        [MethodImpl(Inline), Op]
        public static UnaryOp64 define(UnaryOp<ulong> f)
            => a => f(a.Content);

        [MethodImpl(Inline), Op]
        public static UnaryPredicate1 define(UnaryPredicate<Bit32> f)
            => a => f(a);

        [MethodImpl(Inline), Op]
        public static UnaryPredicate8 define(UnaryPredicate<sbyte> f)
            => a => f((sbyte)a.Content);

        [MethodImpl(Inline), Op]
        public static UnaryPredicate8 define(UnaryPredicate<byte> f)
            => a => f((byte)a.Content);

        [MethodImpl(Inline), Op]
        public static UnaryPredicate16 define(UnaryPredicate<short> f)
            => a => f((short)a.Content);

        [MethodImpl(Inline), Op]
        public static UnaryPredicate16 define(UnaryPredicate<ushort> f)
            => a => f((ushort)a.Content);

        [MethodImpl(Inline), Op]
        public static UnaryPredicate32 define(UnaryPredicate<int> f)
            => a => f((int)a.Content);

        [MethodImpl(Inline), Op]
        public static UnaryPredicate32 define(UnaryPredicate<uint> f)
            => a => f((uint)a.Content);

        [MethodImpl(Inline), Op]
        public static UnaryPredicate64 define(UnaryPredicate<long> f)
            => a => f((long)a.Content);

        [MethodImpl(Inline), Op]
        public static UnaryPredicate64 define(UnaryPredicate<ulong> f)
            => a => f(a.Content);

        [MethodImpl(Inline), Op]
        public static BinaryPredicate1 define(BinaryPredicate<bit> f)
            => (a, b) => f(a, b);

        [MethodImpl(Inline), Op]
        public static BinaryPredicate8 define(BinaryPredicate<sbyte> f)
            => (a, b) => f((sbyte)a.Content, (sbyte)b.Content);

        [MethodImpl(Inline), Op]
        public static BinaryPredicate8 define(BinaryPredicate<byte> f)
            => (a, b) => f(a.Content, b.Content);

        [MethodImpl(Inline), Op]
        public static BinaryPredicate16 define(BinaryPredicate<short> f)
            => (a, b) => f((short)a.Content, (short)b.Content);

        [MethodImpl(Inline), Op]
        public static BinaryPredicate16 define(BinaryPredicate<ushort> f)
            => (a, b) => f(a.Content, b.Content);

        [MethodImpl(Inline), Op]
        public static BinaryPredicate32 define(BinaryPredicate<int> f)
            => (a, b) => f((int)a.Content, (int)a.Content);

        [MethodImpl(Inline), Op]
        public static BinaryPredicate32 define(BinaryPredicate<uint> f)
            => (a, b) => f(a.Content, b.Content);

        [MethodImpl(Inline), Op]
        public static BinaryPredicate64 define(BinaryPredicate<long> f)
            => (a, b) => f((long)a.Content, (long)b.Content);

        [MethodImpl(Inline), Op]
        public static BinaryPredicate64 define(BinaryPredicate<ulong> f)
            => (a, b) => f(a.Content, b.Content);

        /// <summary>
        /// Creates a fixed 128-bit unary operator from caller-supplied delegate
        /// </summary>
        /// <param name="f">The source delegate</param>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static UnaryOp128 define<T>(Func<Vector128<T>, Vector128<T>> f)
            where T : unmanaged
                => (Cell128 a) => f(a.ToVector<T>()).ToCell();

        /// <summary>
        /// Creates a fixed 256-bit binary operator from caller-supplied delegate
        /// </summary>
        /// <param name="f">The source delegate</param>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static UnaryOp256 define<T>(Func<Vector256<T>,Vector256<T>> f)
            where T : unmanaged
                => (Cell256 a) => f(a.ToVector<T>()).ToCell();

        /// <summary>
        /// Creates a fixed 128-bit binary operator from caller-supplied delegate
        /// </summary>
        /// <param name="f">The source delegate</param>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static BinaryOp128 define<T>(Func<Vector128<T>,Vector128<T>,Vector128<T>> f)
            where T : unmanaged
                => (Cell128 a, Cell128 b) => f(a.ToVector<T>(),b.ToVector<T>()).ToCell();

        /// <summary>
        /// Creates a fixed 256-bit binary operator from caller-supplied delegate
        /// </summary>
        /// <param name="f">The source delegate</param>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static BinaryOp256 define<T>(Func<Vector256<T>,Vector256<T>,Vector256<T>> f)
            where T : unmanaged
                => (Cell256 a, Cell256 b) => f(a.ToVector<T>(),b.ToVector<T>()).ToCell();

        [Free]
        public delegate bit Emitter1();

        [Free]
        public delegate bit UnaryOp1(bit a);

        [Free]
        public delegate Cell8 UnaryOp8(Cell8 a);

        [Free]
        public delegate Cell16 UnaryOp16(Cell16 a);

        [Free]
        public delegate Cell32 UnaryOp32(Cell32 a);

        [Free]
        public delegate Cell64 UnaryOp64(Cell64 a);

        [Free]
        public delegate Cell128 UnaryOp128(Cell128 a);

        [Free]
        public delegate Cell256 UnaryOp256(Cell256 a);

        [Free]
        public delegate Cell512 UnaryOp512(Cell512 a);

        [Free]
        public delegate bit BinaryOp1(bit a, bit b);

        [Free]
        public delegate Cell8 BinaryOp8(Cell8 a, Cell8 b);

        [Free]
        public delegate Cell32 BinaryOp32(Cell32 a, Cell32 b);

        [Free]
        public delegate Cell16 BinaryOp16(Cell16 a, Cell16 b);

        [Free]
        public delegate Cell64 BinaryOp64(Cell64 a, Cell64 b);

        [Free]
        public delegate Cell128 BinaryOp128(Cell128 a, Cell128 b);

        [Free]
        public delegate Cell256 BinaryOp256(Cell256 a, Cell256 b);

        [Free]
        public delegate Cell512 BinaryOp512(Cell512 a, Cell512 b);

        [Free]
        public delegate bit BinaryPredicate1(bit a, bit b);

        [Free]
        public delegate bit BinaryPredicate<T>(T a, T b);

    }
}