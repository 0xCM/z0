//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    partial struct As
    {
        [MethodImpl(Inline), Op]
        static ref S gProject<S,T>(in S src, ref T dst)
            where S : unmanaged
            where T : unmanaged
        {
            @as<T,S>(ref dst) = src; 
            return ref add(src, size<S>()); 
        }

        /// <summary>
        /// Projects a reference-identified source into a reference-identifed target and advances the source by the projected size
        /// </summary>
        /// <param name="src">The source data</param>
        /// <param name="dst">The target reference</param>
        [MethodImpl(Inline), Op]
        public static ref ulong project(in ulong src, ref uint dst)
            => ref gProject(src, ref dst);    

        /// <summary>
        /// Projects a reference-identified source into a reference-identifed target and advances the source by the projected size
        /// </summary>
        /// <param name="src">The source data</param>
        /// <param name="dst">The target reference</param>
        [MethodImpl(Inline), Op]
        public static ref byte project(in byte src, ref byte dst)
            => ref gProject(src, ref dst);    

        /// <summary>
        /// Projects a reference-identified source into a reference-identifed target and advances the source by the projected size
        /// </summary>
        /// <param name="src">The source data</param>
        /// <param name="dst">The target reference</param>
        [MethodImpl(Inline), Op]
        public static ref ushort project(in ushort src, ref byte dst)
            => ref gProject(src, ref dst);    

        /// <summary>
        /// Projects a reference-identified source into a reference-identifed target and advances the source by the projected size
        /// </summary>
        /// <param name="src">The source</param>
        /// <param name="dst">The target reference</param>
        [MethodImpl(Inline), Op]
        public static ref uint project(in uint src, ref byte dst)
            => ref gProject(src, ref dst);    

        /// <summary>
        /// Projects a reference-identified source into a reference-identifed target and advances the source by the projected size
        /// </summary>
        /// <param name="src">The source data</param>
        /// <param name="dst">The target reference</param>
        [MethodImpl(Inline), Op]
        public static ref uint project(in uint src, ref ushort dst)
            => ref gProject(src, ref dst);    

        /// <summary>
        /// Projects a reference-identified source into a reference-identifed target and advances the source by the projected size
        /// </summary>
        /// <param name="src">The source data</param>
        /// <param name="dst">The target reference</param>
        [MethodImpl(Inline), Op]
        public static ref ulong project(in ulong src, ref byte dst)
            => ref gProject(src, ref dst);    

        /// <summary>
        /// Projects a reference-identified source into a reference-identifed target and advances the source by the projected size
        /// </summary>
        /// <param name="src">The source data</param>
        /// <param name="dst">The target reference</param>
        [MethodImpl(Inline), Op]
        public static ref ulong project(in ulong src, ref ushort dst)
            => ref gProject(src, ref dst);    
    }
}