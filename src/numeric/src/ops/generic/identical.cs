//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Seed;
    using static Memories;
    
    partial class Numeric
    {
        /// <summary>
        /// Returns 1 if the left and right spans contain identical content and 0 otherwise
        /// </summary>
        /// <param name="xs">The left span</param>
        /// <param name="ys">The right span</param>
        /// <typeparam name="T">The span cell type</typeparam>
        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static bit identical<T>(Span<T> xs, Span<T> ys)  
            where T : unmanaged       
        {            
            if(xs.Length != ys.Length)
                return false;
            return identical(ref head(xs), ref head(ys), xs.Length);
        }

        /// <summary>
        /// Returns 1 if the left and right spans contain identical content and 0 otherwise
        /// </summary>
        /// <param name="xs">The left span</param>
        /// <param name="ys">The right span</param>
        /// <typeparam name="T">The span cell type</typeparam>
        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static bit identical<T>(ReadOnlySpan<T> xs, ReadOnlySpan<T> ys)  
            where T : unmanaged       
        {
            if(xs.Length != ys.Length)
                return false;
            return identical(ref edit(in head(xs)), ref edit(in head(ys)), xs.Length);
        }        

        /// <summary>
        ///  Adapted from corefx repo
        /// </summary>
        [Op, Closures(UnsignedInts)]
        public static bit identical<T>(ref T first, ref T second, int length)
            where T : unmanaged
        {
            if (Unsafe.AreSame(ref first, ref second))
                return true;

            IntPtr offset = (IntPtr)0; 
            T x;
            T y;
            while (length >= 8)
            {
                length -= 8;
                
                x = offset<T>(ref first, offset + 0);
                y = offset<T>(ref second, offset + 0);
                if(neq(x, y))
                    return false;                
                x = offset<T>(ref first, offset + 1);
                y = offset<T>(ref second, offset + 1);
                if(neq(x, y))
                    return false;
                x = offset<T>(ref first, offset + 2);
                y = offset<T>(ref second, offset + 2);
                if(neq(x, y))
                    return false;
                x = offset<T>(ref first, offset + 3);
                y = offset<T>(ref second, offset + 3);
                if(neq(x, y))
                    return false;
                x = offset<T>(ref first, offset + 4);
                y = offset<T>(ref second, offset + 4);
                if(neq(x, y))
                    return false;
                x = offset<T>(ref first, offset + 5);
                y = offset<T>(ref second, offset + 5);
                if(neq(x, y))
                    return false;
                x = offset<T>(ref first, offset + 6);
                y = offset<T>(ref second, offset + 6);
                if(neq(x, y))
                    return false;
                x = offset<T>(ref first, offset + 7);
                y = offset<T>(ref second, offset + 7);
                if(neq(x, y))
                    return false;

                offset += 8;
            }

            if (length >= 4)
            {
                length -= 4;

                x = offset<T>(ref first, offset);
                y = offset<T>(ref second, offset);
                if(Numeric.neq(x, y))
                    return false;
                x = offset<T>(ref first, offset + 1);
                y = offset<T>(ref second, offset + 1);
                if(Numeric.neq(x, y))
                    return false;
                x = offset<T>(ref first, offset + 2);
                y = offset<T>(ref second, offset + 2);
                if(Numeric.neq(x, y))
                    return false;
                x = offset<T>(ref first, offset + 3);
                y = offset<T>(ref second, offset + 3);
                if(Numeric.neq(x, y))
                    return false;

                offset += 4;
            }

            while (length > 0)
            {
                x = offset<T>(ref first, offset);
                y = offset<T>(ref second, offset);
                if(Numeric.neq(x, y))
                    return false;
                offset += 1;
                length--;
            }

            return true;
        }
    }
}