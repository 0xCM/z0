//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;
    using System.Runtime.Intrinsics.X86;
    
    using static Root;
    using static Nats;

    partial class gvec
    {
        /// <summary>
        /// Allocates and deposits vector content to a data block
        /// </summary>
        /// <param name="src">The source span</param>
        /// <typeparam name="T">The component type</typeparam>
        [MethodImpl(NotInline), Op, NumericClosures(NumericKind.All)]
        internal static Block128<T> block<T>(Vector128<T> src)
            where T : unmanaged            
        {
            var dst = Blocks.single<T>(n128);
            vstore(src, ref dst.Head);
            return dst;
        }                       

        /// <summary>
        /// Allocates and deposits vector content to a data block
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <typeparam name="T">The primitive type</typeparam>
        [MethodImpl(NotInline), Op, NumericClosures(NumericKind.All)]
        internal static Block256<T> block<T>(Vector256<T> src)
            where T : unmanaged            
        {
            var dst = Blocks.single<T>(n256);
            vstore(src, ref dst.Head);
            return dst;
        }            

        /// <summary>
        /// Allocates and deposits vector content to a data block
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <typeparam name="T">The primitive type</typeparam>
        [MethodImpl(NotInline), Op, NumericClosures(NumericKind.All)]
        internal static Block512<T> block<T>(Vector512<T> src)
            where T : unmanaged            
        {
            var dst = Blocks.single<T>(n512);
            vstore(src, ref dst.Head);
            return dst;
        }            
    }
}