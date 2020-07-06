// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    
    partial class Root
    {
        /// <summary>
        /// Takes a value out of a box
        /// </summary>
        /// <param name="src">The boxed value</param>
        /// <typeparam name="T">The boxed type</typeparam>
        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public static ref T unbox<T>(object src) 
            where T : struct
                => ref Unsafe.Unbox<T>(src);

        /// <summary>
        /// Takes an enum value out of a box
        /// </summary>
        /// <param name="src">The boxed value</param>
        /// <typeparam name="T">The boxed type</typeparam>
        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public static ref T unbox<T>(Enum src) 
            where T : unmanaged
                => ref Unsafe.Unbox<T>(src);
    }
}