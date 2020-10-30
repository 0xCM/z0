//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static z;

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
        public static unsafe void deposit<S,F>(in S src, ref F dst)
            where S : struct
            where F : unmanaged, IDataCell
        {
            ref var dstBytes = ref @as<F,byte>(dst);
            ref var srcBytes = ref @as<S,byte>(Unsafe.AsRef(in src));
            Unsafe.CopyBlockUnaligned(ref dstBytes, ref srcBytes, (uint)sizeof(F));
        }
    }
}