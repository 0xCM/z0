//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;    
        
    using static Konst; 
    using static Root;       

    partial class Blocks
    {
        /// <summary>
        /// Computes the number of cells that comprise a single 8-bit block
        /// </summary>
        /// <param name="w">The block width selector</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline), Op, Closures(Numeric8k)]
        public static int length<T>(W8 w, T t = default)
            where T : unmanaged
                => size<T>();

        /// <summary>
        /// Computes the number of cells that comprise a single 16-bit block
        /// </summary>
        /// <param name="w">The block width selector</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline), Op, Closures(Numeric8x16k)]
        public static int length<T>(W16 w, T t = default)
            where T : unmanaged
                => 2/size<T>();

        /// <summary>
        /// Computes the number of cells that comprise a single 32-bit block
        /// </summary>
        /// <param name="w">The block width selector</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline), Op, Closures(Numeric8x16x32k)]
        public static int length<T>(W32 w, T t = default)
            where T : unmanaged
                => 4/size<T>();

        /// <summary>
        /// Computes the number of elements that comprise a single 64-bit block
        /// </summary>
        /// <param name="w">The block width selector</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public static int length<T>(W64 w, T t = default)
            where T : unmanaged
                => 8/size<T>();

        /// <summary>
        /// Computes the number of elements that comprise a single 128-bit block
        /// </summary>
        /// <param name="w">The block width selector</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public static int length<T>(W128 w, T t = default)
            where T : unmanaged
                => 16/size<T>();

        /// <summary>
        /// Computes the number of elements that comprise a 256-bit block
        /// </summary>
        /// <param name="w">The block width selector</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public static int length<T>(W256 w, T t = default)
            where T : unmanaged
                => 32/size<T>();

        /// <summary>
        /// Computes the number of elements that comprise a 512-bit block
        /// </summary>
        /// <param name="w">The block width selector</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public static int length<T>(W512 w, T t = default)
            where T : unmanaged
                => 64/size<T>();

        /// <summary>
        /// Computes the number of T-cells that comprise an N-block
        /// </summary>
        /// <param name="w">The block width representative</param>
        /// <param name="t">The cell type representative</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline)]
        public static int length<W,T>(W w = default, T t = default)
            where W : unmanaged, ITypeNat
            where T : unmanaged
                => ((int)NatCalc.div(w,default(N8)))/size<T>(); 

        /// <summary>
        /// Returns the length of equal-length blocks; otherwise raises an error
        /// </summary>
        /// <param name="lhs">The left span</param>
        /// <param name="rhs">The right span</param>
        public static int length<S,T>(Block128<S> lhs, Block128<T> rhs)
            where T : unmanaged
            where S : unmanaged
                => lhs.CellCount == rhs.CellCount ? lhs.CellCount : throw AppErrors.LengthMismatch(lhs.CellCount, rhs.CellCount);

        /// <summary>
        /// Returns the length of equal-length blocks; otherwise raises an error
        /// </summary>
        /// <param name="lhs">The left span</param>
        /// <param name="rhs">The right span</param>
        public static int length<S,T>(Block256<S> lhs, Block256<T> rhs)
            where T : unmanaged
            where S : unmanaged
                => lhs.CellCount == rhs.CellCount ? lhs.CellCount : throw AppErrors.LengthMismatch(lhs.CellCount, rhs.CellCount);

        /// <summary>
        /// Returns the length of equal-length blocks; otherwise raises an error
        /// </summary>
        /// <param name="lhs">The left span</param>
        /// <param name="rhs">The right span</param>
        public static int length<S,T>(Block512<S> lhs, Block512<T> rhs)
            where T : unmanaged
            where S : unmanaged
                => lhs.CellCount == rhs.CellCount ? lhs.CellCount : throw AppErrors.LengthMismatch(lhs.CellCount, rhs.CellCount);
    }
}