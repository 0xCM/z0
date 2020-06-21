//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static System.Runtime.CompilerServices.Unsafe;
    using static System.Runtime.InteropServices.MemoryMarshal;

    partial struct Imagine
    {
        /// <summary>
        /// Interprets a readonly generic reference as a readonly uint8 reference
        /// </summary>
        /// <param name="src">The source reference</param>
        /// <typeparam name="T">The source type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ref readonly byte read<T>(W8 w, in T src)
            => ref As<T,byte>(ref AsRef(in src));

        /// <summary>
        /// Interprets a readonly generic reference as a readonly uint16 reference
        /// </summary>
        /// <param name="src">The source reference</param>
        /// <typeparam name="T">The source type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ref readonly ushort read<T>(W16 w, in T src)
            => ref As<T,ushort>(ref AsRef(in src));

        /// <summary>
        /// Interprets a readonly generic reference as a readonly uint32 reference
        /// </summary>
        /// <param name="src">The source reference</param>
        /// <typeparam name="T">The source type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ref readonly uint read<T>(W32 w, in T src)
            => ref As<T,uint>(ref AsRef(in src));

        /// <summary>
        /// Interprets a readonly generic reference as a readonly uint64 reference
        /// </summary>
        /// <param name="src">The source reference</param>
        /// <typeparam name="T">The source type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ref readonly ulong read<T>(W64 w, in T src)
            => ref As<T,ulong>(ref AsRef(in src));


        /// <summary>
        /// Deposits a source value, identified by pointer and offset, into a target reference
        /// </summary>
        /// <param name="pSrc">The data source</param>
        /// <param name="offset">The value offset</param>
        /// <param name="dst">The receiving reference</param>
        /// <typeparam name="T">The value type</typeparam>
        /// <remarks>u8:  movsxd rax,edx -> movzx eax,byte ptr [rcx+rax] -> mov [r8],al -> mov rax,r8 </remarks>
        /// <remarks>u16: movsxd rax,edx -> movzx eax,word ptr [rcx+rax*2] -> mov [r8],ax -> mov rax,r8 </remarks>
        /// <remarks>u32: movsxd rax,edx -> mov eax,[rcx+rax*4] -> mov [r8],eax -> mov rax,r8 </remarks>
        /// <remarks>u64: movsxd rax,edx -> mov rax,[rcx+rax*8] -> mov [r8],rax -> mov rax,r8 </remarks>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public unsafe static ref T read<T>(T* pSrc, int offset, ref T dst)
            where T : unmanaged
        {
            dst = *(pSrc + offset);
            return ref dst;
        }

        /// <summary>
        /// Deposits a range of source values into a target reference
        /// </summary>
        /// <param name="pSrc">The data source</param>
        /// <param name="offset">The value offset</param>
        /// <param name="dst">The receiving reference</param>
        /// <param name="count">The number of values to extract/deposit</param>
        /// <typeparam name="T">The value type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static unsafe void read<T>(T* pSrc, int offset, ref T dst, int count)
            where T : unmanaged
        {
            var last = offset + count;
            for(var i=offset; i<last; i++)
                read(pSrc, i, ref add(dst, i));
        }            
 
        /// <summary>
        /// Reads a T-value from an S-source
        /// </summary>
        /// <param name="src">The data source</param>
        /// <typeparam name="S">The source cell type</typeparam>
        /// <typeparam name="T">The target cell type</typeparam>
        [MethodImpl(Inline)]
        public static ref readonly T read<S,T>(in S src)        
            => ref As<S,T>(ref edit(src));

        /// <summary>
        /// Reads a T-value from an S-source after skipping a specified count of S-elements
        /// </summary>
        /// <param name="src">The data source</param>
        /// <param name="offset">The number of S-cells to skip</param>
        /// <typeparam name="S">The source cell type</typeparam>
        /// <typeparam name="T">The target cell type</typeparam>
        [MethodImpl(Inline)]
        public static ref readonly T read<S,T>(in S src, int offset)        
            => ref read<S,T>(Add(ref edit(src), offset));

    }
}