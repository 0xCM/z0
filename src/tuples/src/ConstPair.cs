//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    /// <summary>
    /// Defines const pair manipulation api
    /// </summary>
    [ApiHost]
    public class ConstPair : IApiHost<ConstPair>
    {
        /// <summary>
        /// Presents a scalar pair as a parametric pair
        /// </summary>
        /// <param name="src">The source pair</param>
        /// <typeparam name="T">The target type</typeparam>
        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public static ConstPair<T> generic<T>(in ConstPair<sbyte> src)
            where T : unmanaged            
                => src.As<T>();
                
        /// <summary>
        /// Presents a scalar pair as a parametric pair
        /// </summary>
        /// <param name="src">The source pair</param>
        /// <typeparam name="T">The target type</typeparam>
        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public static ConstPair<T> generic<T>(in ConstPair<byte> src)
            where T : unmanaged            
                => src.As<T>();

        /// <summary>
        /// Presents a scalar pair as a parametric pair
        /// </summary>
        /// <param name="src">The source pair</param>
        /// <typeparam name="T">The target type</typeparam>
        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public static ConstPair<T> generic<T>(in ConstPair<short> src)
            where T : unmanaged            
                => src.As<T>();

        /// <summary>
        /// Presents a scalar pair as a parametric pair
        /// </summary>
        /// <param name="src">The source pair</param>
        /// <typeparam name="T">The target type</typeparam>
        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public static ConstPair<T> generic<T>(in ConstPair<ushort> src)
            where T : unmanaged            
                => src.As<T>();

        /// <summary>
        /// Presents a scalar pair as a parametric pair
        /// </summary>
        /// <param name="src">The source pair</param>
        /// <typeparam name="T">The target type</typeparam>
        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public static ConstPair<T> generic<T>(in ConstPair<int> src)
            where T : unmanaged            
                => src.As<T>();

        /// <summary>
        /// Presents a scalar pair as a parametric pair
        /// </summary>
        /// <param name="src">The source pair</param>
        /// <typeparam name="T">The target type</typeparam>
        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public static ConstPair<T> generic<T>(in ConstPair<uint> src)
            where T : unmanaged            
                => src.As<T>();

        /// <summary>
        /// Presents a scalar pair as a parametric pair
        /// </summary>
        /// <param name="src">The source pair</param>
        /// <typeparam name="T">The target type</typeparam>
        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public static ConstPair<T> generic<T>(in ConstPair<long> src)
            where T : unmanaged            
                => src.As<T>();

        /// <summary>
        /// Presents a scalar pair as a parametric pair
        /// </summary>
        /// <param name="src">The source pair</param>
        /// <typeparam name="T">The target type</typeparam>
        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public static ConstPair<T> generic<T>(in ConstPair<ulong> src)
            where T : unmanaged            
                => src.As<T>();

        /// <summary>
        /// Presents a scalar pair as a parametric pair
        /// </summary>
        /// <param name="src">The source pair</param>
        /// <typeparam name="T">The target type</typeparam>
        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public static ConstPair<T> generic<T>(in ConstPair<float> src)
            where T : unmanaged            
                => src.As<T>();
                
        /// <summary>
        /// Presents a scalar pair as a parametric pair
        /// </summary>
        /// <param name="src">The source pair</param>
        /// <typeparam name="T">The target type</typeparam>
        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public static ConstPair<T> generic<T>(in ConstPair<double> src)
            where T : unmanaged            
                => src.As<T>();
    }
}