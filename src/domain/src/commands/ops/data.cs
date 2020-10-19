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

    partial struct Cmd
    {
        /// <summary>
        /// Populates a <see cref='CmdOptionData'/> structure from a specified source
        /// </summary>
        /// <param name="src">The data source</param>
        [MethodImpl(Inline), Op]
        public static CmdOptionData data(in CmdOption src)
        {
            var dst = new CmdOptionData();
            data(src,ref dst);
            return dst;
        }

        /// <summary>
        /// Populates a <see cref='CmdOptionData'/> structure from a specified source
        /// </summary>
        /// <param name="src">The data source</param>
        /// <param name="dst">The data target</param>
        [MethodImpl(Inline), Op]
        public static ref CmdOptionData data(in CmdOption src, ref CmdOptionData dst)
        {
            dst.Id = src.Id;
            dst.Value = src.Value;
            return ref dst;
        }

        /// <summary>
        /// Populates a <see cref='CmdOptionData{T}'/> structure from a specified source
        /// </summary>
        /// <param name="src">The data source</param>
        /// <typeparam name="T">The option value type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static CmdOptionData<T> data<T>(in CmdOption<T> src)
        {
            var dst = new CmdOptionData<T>();
            data(src,ref dst);
            return dst;
        }

        /// <summary>
        /// Populates a <see cref='CmdOptionData{T}'/> structure from a specified source
        /// </summary>
        /// <param name="src">The data source</param>
        /// <param name="dst">The data target</param>
        /// <typeparam name="T">The option value type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ref CmdOptionData<T> data<T>(in CmdOption<T> src, ref CmdOptionData<T> dst)
        {
            dst.Id = src.Id;
            dst.Value = src.Value;
            return ref dst;
        }

        /// <summary>
        /// Populates a <see cref='CmdOptionData{K,T}'/> structure from a specified source
        /// </summary>
        /// <param name="src">The data source</param>
        /// <typeparam name="K">The option kind type</typeparam>
        /// <typeparam name="T">The option value type</typeparam>
        [MethodImpl(Inline)]
        public static CmdOptionData<K,T> data<K,T>(in CmdOption<K,T> src)
            where K : unmanaged
        {
            var dst = new CmdOptionData<K,T>();
            data(src,ref dst);
            return dst;
        }

        /// <summary>
        /// Populates a <see cref='CmdOptionData{K,T}'/> structure from a specified source
        /// </summary>
        /// <param name="src">The data source</param>
        /// <param name="dst">The data target</param>
        /// <typeparam name="K">The option kind type</typeparam>
        /// <typeparam name="T">The option value type</typeparam>
        [MethodImpl(Inline)]
        public static ref CmdOptionData<K,T> data<K,T>(in CmdOption<K,T> src, ref CmdOptionData<K,T> dst)
            where K : unmanaged
        {
            dst.Id = src.Kind;
            dst.Value = src.Value;
            return ref dst;
        }

        [MethodImpl(Inline), Op]
        public static CmdSpecData data(in CmdSpec src)
        {
            var dst = new CmdSpecData();
            data(src, ref dst);
            return dst;
        }

        [MethodImpl(Inline)]
        public static ref CmdSpecData data(in CmdSpec src, ref CmdSpecData dst)
        {
            dst.Id = src.Id;
            dst.Options = src.OptionStorage;
            return ref dst;
        }

        [MethodImpl(Inline)]
        public static ref CmdSpecData<K,T> data<K,T>(in CmdSpec<K,T> src, ref CmdSpecData<K,T> dst)
            where K : unmanaged
        {
            dst.Id = src.Id;
            dst.Options = src.OptionStorage;
            return ref dst;
        }
    }
}