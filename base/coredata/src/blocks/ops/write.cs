//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;    
    using System.Runtime.InteropServices;    
        
    using static zfunc;

    partial class DataBlocks
    {
        /// <summary>
        /// Writes a specified number of bytes to a block beginning at a byte-relative offset
        /// </summary>
        /// <param name="src">The data source</param>
        /// <param name="dst">The target block</param>
        /// <param name="offset">The absolute number of bytes, measured from the head of the data structure, to skip</param>
        /// <param name="count">The number of to copy from the source into the target</param>
        /// <typeparam name="T">The block cell type</typeparam>
        [MethodImpl(Inline)]
        public static void write<T>(in byte src, in Block256<T> dst, int offset, int count)
            where T : unmanaged        
        {            
            ref var target = ref Unsafe.Add(ref Unsafe.As<T,byte>(ref dst.Head), offset);            
            Unsafe.CopyBlock(ref target, ref Unsafe.AsRef(in src), (uint)count);
        }

        /// <summary>
        /// Writes a specified number of bytes to a block beginning at a byte-relative offset
        /// </summary>
        /// <param name="src">The data source</param>
        /// <param name="dst">The target block</param>
        /// <param name="offset">The absolute number of bytes, measured from the head of the data structure, to skip</param>
        /// <param name="count">The number of to copy from the source into the target</param>
        /// <typeparam name="T">The block cell type</typeparam>
        [MethodImpl(Inline)]
        public static void write<T>(in byte src, in Block512<T> dst, int offset, int count)
            where T : unmanaged        
        {            
            ref var target = ref Unsafe.Add(ref Unsafe.As<T,byte>(ref dst.Head), offset);            
            Unsafe.CopyBlock(ref target, ref Unsafe.AsRef(in src), (uint)count);
        }

    }

}