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

    public static partial class VectorExtensions
    {
        /// <summary>
        /// Determines whether any elements of the source match the target
        /// </summary>
        /// <param name="src">The source values</param>
        /// <param name="target">The target value to match</param>
        /// <typeparam name="T">The value type</typeparam>
        [MethodImpl(Inline)]
        public static bool Contains<T>(this ReadOnlySpan<T> src, T target)        
            where T : unmanaged
                => src.BinarySearch(target, Numeric.comparer<T>()) >= 0;

        [MethodImpl(Inline)]
        public static T FirstCell<T>(this Vector128<T> src)
            where T : unmanaged 
                => src.Cell(0);
        
        [MethodImpl(Inline)]
        public static T FirstCell<T>(this Vector256<T> src)
            where T : unmanaged 
                => src.Cell(0);

        [MethodImpl(Inline)]
        public static T LastCell<T>(this Vector128<T> src)
            where T : unmanaged 
        {
            if(Unsafe.SizeOf<T>() == 1)
                return src.Cell(15);
            else if(Unsafe.SizeOf<T>() == 2)
                return src.Cell(7);
            else if(Unsafe.SizeOf<T>() == 4)
                return src.Cell(3);
            else
                return src.Cell(1);
        }

        [MethodImpl(Inline)]
        public static T LastCell<T>(this Vector256<T> src)
            where T : unmanaged 
        {
            if(Unsafe.SizeOf<T>() == 1)
                return src.Cell(31);
            else if(Unsafe.SizeOf<T>() == 2)
                return src.Cell(15);
            else if(Unsafe.SizeOf<T>() == 4)
                return src.Cell(7);
            else
                return src.Cell(3);
        }    

        [MethodImpl(Inline)]
        public static Fixed512 ToFixed<T>(this Vector512<T> x)
            where T : unmanaged
                => Unsafe.As<Vector512<T>,Fixed512>(ref x);

        [MethodImpl(Inline)]
        public static Vector512<T> Apply<T>(this UnaryOp512 f, Vector512<T> x)
           where T : unmanaged
                => f(x.ToFixed()).ToVector<T>();

        [MethodImpl(Inline)]
        public static Vector512<T> Apply<T>(this BinaryOp512 f, Vector512<T> x, Vector512<T> y)
            where T : unmanaged
        {
            var zf = f(Unsafe.As<Vector512<T>,Fixed512>(ref x), Unsafe.As<Vector512<T>,Fixed512>(ref y));
            return Unsafe.As<Fixed512,Vector512<T>>(ref zf);
        }              
    }
}