//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    partial struct z
    {
        /// <summary>
        /// Converts a <see cref='bool'/> to a <see cref='ulong'/>
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline), Op]
        public static unsafe ulong @ulong(bool src)
            => (*((byte*)(&src))); 

        /// <summary>
        /// Converts a <see cref='double'/> to a <see cref='ulong'/>
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline), Op]
        public static unsafe ulong @ulong(double src)
            => (*((ulong*)(&src))); 

        /// <summary>
        /// Converts a <see cref='decimal'/> to a <see cref='ulong'/>
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline), Op]
        public static unsafe ulong @ulong(decimal src)
            => (*((ulong*)(&src))); 

        [MethodImpl(Inline), Op, Closures(Numeric64k)]
        public static unsafe ulong @ulong<T>(T src)
            where T : unmanaged             
                => *((ulong*)(&src));
    
        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public static ref T unbox<T>(object src)
            where T : struct
                => ref sys.unbox<T>(src);

        [MethodImpl(Inline)]
        public static ref T unbox<T>(Enum src)
            where T : unmanaged, Enum
                => ref sys.unbox<T>(src);
    }
}