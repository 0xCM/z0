//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;
    using static memory;

    unsafe partial struct Pointers
    {
        /// <summary>
        /// Creates a void pointer representation
        /// </summary>
        /// <param name="pSrc">The pointer to represent</param>
        [MethodImpl(Inline), Op]
        public static Ptr pvoid(void* pSrc)
            => new Ptr(pSrc);

        /// <summary>
        /// Creates a void pointer representation
        /// </summary>
        /// <param name="pSrc">The pointer to represent</param>
        [MethodImpl(Inline), Op]
        public static ref Ptr pvoid<T>(in Ptr<T> src)
            where T : unmanaged
                => ref @as<Ptr<T>,Ptr>(src);

        /// <summary>
        /// Transforms the source representation to a void representation
        /// </summary>
        /// <param name="src">The source</param>
        [MethodImpl(Inline), Op]
        public static ref Ptr pvoid(in Ptr8 src)
            => ref @as<Ptr8,Ptr>(src);

        /// <summary>
        /// Creates a void pointer representation
        /// </summary>
        /// <param name="pSrc">The pointer to represent</param>
        [MethodImpl(Inline), Op]
        public static Ptr pvoid(byte* pSrc)
            => new Ptr(pSrc);

        /// <summary>
        /// Creates a void pointer representation
        /// </summary>
        /// <param name="pSrc">The pointer to represent</param>
        [MethodImpl(Inline), Op]
        public static Ptr pvoid(ushort* pSrc)
            => new Ptr(pSrc);

        /// <summary>
        /// Creates a void pointer representation
        /// </summary>
        /// <param name="pSrc">The pointer to represent</param>
        [MethodImpl(Inline), Op]
        public static Ptr pvoid(uint* pSrc)
            => new Ptr(pSrc);

        /// <summary>
        /// Creates a void pointer representation
        /// </summary>
        /// <param name="pSrc">The pointer to represent</param>
        [MethodImpl(Inline), Op]
        public static Ptr pvoid(ulong* pSrc)
            => new Ptr(pSrc);
    }
}