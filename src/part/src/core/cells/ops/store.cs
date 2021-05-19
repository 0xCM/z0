//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;
    using static core;

    partial class Cells
    {
        /// <summary>
        /// Writes source data to a fixed target which, hopefully, is of sufficient size
        /// </summary>
        /// <param name="src">The source</param>
        /// <param name="dst">The target</param>
        /// <typeparam name="T">The source type</typeparam>
        /// <typeparam name="F">The fixed target type</typeparam>
        [MethodImpl(Inline)]
        public static unsafe ref F store<S,F>(in S src, ref F dst)
            where S : struct
            where F : unmanaged, IDataCell
        {
            ref var dstBytes = ref @as<F,byte>(dst);
            ref var srcBytes = ref @as<S,byte>(Unsafe.AsRef(in src));
            Unsafe.CopyBlockUnaligned(ref dstBytes, ref srcBytes, (uint)sizeof(F));
            return ref dst;
        }

        /// <summary>
        /// Writes a specified number of source elements to a fixed target
        /// </summary>
        /// <param name="src">The source</param>
        /// <param name="count">The number of source elements to write</param>
        /// <param name="dst">The target</param>
        /// <param name="offset">The element-relative offset into the target</param>
        /// <typeparam name="S">The source cell type</typeparam>
        [MethodImpl(Inline)]
        public static unsafe void store<S,F>(in S src, int count, ref F dst, int offset)
            where S : struct
            where F : struct
                => store(src, (int)(size<S>() * count), ref Unsafe.Add(ref Unsafe.As<F,byte>(ref dst), (int)(size<S>() * offset)));

        [MethodImpl(Inline)]
        public static unsafe ref T store<S,T>(in S src, int bytecount, ref T dst)
            where S : struct
            where T : struct
        {
            ref var dstBytes = ref @as<T,byte>(dst);
            ref var srcBytes = ref @as<S,byte>(src);
            Unsafe.CopyBlockUnaligned(ref dstBytes, ref srcBytes, (uint)bytecount);
            return ref dst;
        }
    }
}