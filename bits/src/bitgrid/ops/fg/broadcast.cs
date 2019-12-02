//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using System.Runtime.Intrinsics;

    using static zfunc;

    partial class BitGrid
    {
        /// <summary>
        /// Transmits the source state to all bits in a target grid
        /// </summary>
        /// <param name="state">The source state</param>
        /// <param name="dst">The target grid</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline)]
        public static ref BitGrid16<T> broadcast<T>(bit state, out BitGrid16<T> dst)
            where T : unmanaged
        {
            dst = state ? maxval<ushort>() : z16;
            return ref dst;
        }

        /// <summary>
        /// Transmits the content of a single cell to all cells in a grid
        /// </summary>
        /// <param name="cell">The source cell</param>
        /// <param name="dst">The target grid</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline)]
        public static ref readonly BitGrid16<T> broadcast<T>(T cell, out BitGrid16<T> dst)    
            where T : unmanaged
        {
            dst = zfunc.broadcast(cell, out ushort _);
            return ref dst;
        }

        /// <summary>
        /// Transmits the source state to all bits in a target grid
        /// </summary>
        /// <param name="state">The source state</param>
        /// <param name="dst">The target grid</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline)]
        public static ref BitGrid32<T> broadcast<T>(bit state, out BitGrid32<T> dst)
            where T : unmanaged
        {
            dst = state ? maxval<uint>() : z32;
            return ref dst;
        }

        /// <summary>
        /// Transmits the content of a single cell to all cells in a grid
        /// </summary>
        /// <param name="cell">The source cell</param>
        /// <param name="dst">The target grid</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline)]
        public static ref readonly BitGrid32<T> broadcast<T>(T cell, out BitGrid32<T> dst)    
            where T : unmanaged
        {
            dst = zfunc.broadcast(cell, out uint _);
            return ref dst;
        }

        /// <summary>
        /// Transmits the source state to all bits in a target grid
        /// </summary>
        /// <param name="state">The source state</param>
        /// <param name="dst">The target grid</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline)]
        public static ref readonly BitGrid64<T> broadcast<T>(bit state, out BitGrid64<T> dst)    
            where T : unmanaged
        {
            dst = state ? maxval<ulong>() : 0ul;
            return ref dst;
        }

        /// <summary>
        /// Transmits the content of a single cell to all cells in a grid
        /// </summary>
        /// <param name="cell">The source cell</param>
        /// <param name="dst">The target grid</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline)]
        public static ref readonly BitGrid64<T> broadcast<T>(T cell, out BitGrid64<T> dst)    
            where T : unmanaged
        {
            dst = zfunc.broadcast(cell, out ulong _);
            return ref dst;
        }

        /// <summary>
        /// Transmits the source cell value to all cells in a target grid
        /// </summary>
        /// <param name="state">The source state</param>
        /// <param name="dst">The target grid</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline)]
        public static ref readonly BitGrid128<T> broadcast<T>(T cell, out BitGrid128<T> dst)    
            where T : unmanaged
        {
            dst = ginx.vbroadcast(n128,cell);
            return ref dst;
        }

        /// <summary>
        /// Transmits the source cell value to all cells in a target grid
        /// </summary>
        /// <param name="state">The source state</param>
        /// <param name="dst">The target grid</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline)]
        public static ref readonly BitGrid256<T> broadcast<T>(T cell, out BitGrid256<T> dst)    
            where T : unmanaged
        {
            dst = ginx.vbroadcast(n256,cell);
            return ref dst;
        }
    }
}