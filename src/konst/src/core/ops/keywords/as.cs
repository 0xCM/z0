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

    partial struct core
    {


        /// <summary>
        /// Presents an S-cell as a T-cell
        /// </summary>
        /// <param name="src">The source cell</param>
        /// <typeparam name="S">The source type</typeparam>
        /// <typeparam name="T">The target type</typeparam>
        [MethodImpl(Inline)]
        public static ref T @as<S,T>(ref S src)   
            => ref As<S,T>(ref src);

        /// <summary>
        /// Presents an S-cell as a T-cell
        /// </summary>
        /// <param name="src">The source cell</param>
        /// <param name="src">The target cell</param>
        /// <typeparam name="S">The source type</typeparam>
        /// <typeparam name="T">The target type</typeparam>
        [MethodImpl(Inline)]
        public static ref T @as<S,T>(ref S src, ref T dst)   
            => ref As<S,T>(ref src);
                    
        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public static ref T @as<T>(in sbyte src)        
            => ref As<sbyte,T>(ref AsRef(src));

        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public static ref T @as<T>(in byte src)        
            => ref As<byte,T>(ref AsRef(src));

        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public static ref T @as<T>(in short src)        
            => ref As<short,T>(ref AsRef(src));

        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public static ref T @as<T>(in ushort src)        
            => ref As<ushort,T>(ref AsRef(src));

        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public static ref T @as<T>(in int src)        
            => ref As<int,T>(ref AsRef(src));

        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public static ref T @as<T>(in uint src)        
            => ref As<uint,T>(ref AsRef(src));

        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public static ref T @as<T>(in long src)        
            => ref As<long,T>(ref AsRef(src));

        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public static ref T @as<T>(in ulong src)        
            => ref As<ulong,T>(ref AsRef(src));

        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public static ref T @as<T>(in float src)        
            => ref As<float,T>(ref AsRef(src));

        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public static ref T @as<T>(in double src)        
            => ref As<double,T>(ref AsRef(src));

        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public static ref T @as<T>(in decimal src)        
            => ref As<decimal,T>(ref AsRef(src));

        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public static ref T @as<T>(in char src)        
            => ref As<char,T>(ref AsRef(src));

        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public static ref T @as<T>(in bool src)        
            => ref As<bool,T>(ref AsRef(src));

        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public static ref T @as<T>(in string src)        
            => ref As<string,T>(ref AsRef(src));
    }
}