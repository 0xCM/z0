//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    
    using static As;
    using static gmath;
    using static refs;

    public static class XGSpan
    {
        /// <summary>
        /// Returns 1 if the left and right spans contain identical content and 0 otherwise
        /// </summary>
        /// <param name="xs">The left span</param>
        /// <param name="ys">The right span</param>
        /// <typeparam name="T">The span cell type</typeparam>
        [MethodImpl(Inline)]
        public static bit Identical<T>(this Span<T> xs, Span<T> ys)  
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
        [MethodImpl(Inline)]
        public static bit Identical<T>(this ReadOnlySpan<T> xs, ReadOnlySpan<T> ys)  
            where T : unmanaged       
        {
            if(xs.Length != ys.Length)
                return false;
            return identical(ref edit(in head(xs)), ref edit(in head(ys)), xs.Length);
        }
 
        //Adapted from corefx repo
        static bit identical<T>(ref T first, ref T second, int length)
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
                
                x = refAdd(ref first, offset + 0);
                y = refAdd(ref second, offset + 0);
                if(gmath.neq(x, y))
                    return false;                
                x = refAdd(ref first, offset + 1);
                y = refAdd(ref second, offset + 1);
                if(gmath.neq(x, y))
                    return false;
                x = refAdd(ref first, offset + 2);
                y = refAdd(ref second, offset + 2);
                if(gmath.neq(x, y))
                    return false;
                x = refAdd(ref first, offset + 3);
                y = refAdd(ref second, offset + 3);
                if(gmath.neq(x, y))
                    return false;
                x = refAdd(ref first, offset + 4);
                y = refAdd(ref second, offset + 4);
                if(gmath.neq(x, y))
                    return false;
                x = refAdd(ref first, offset + 5);
                y = refAdd(ref second, offset + 5);
                if(gmath.neq(x, y))
                    return false;
                x = refAdd(ref first, offset + 6);
                y = refAdd(ref second, offset + 6);
                if(gmath.neq(x, y))
                    return false;
                x = refAdd(ref first, offset + 7);
                y = refAdd(ref second, offset + 7);
                if(gmath.neq(x, y))
                    return false;

                offset += 8;
            }

            if (length >= 4)
            {
                length -= 4;

                x = refAdd(ref first, offset);
                y = refAdd(ref second, offset);
                if(gmath.neq(x, y))
                    return false;
                x = refAdd(ref first, offset + 1);
                y = refAdd(ref second, offset + 1);
                if(gmath.neq(x, y))
                    return false;
                x = refAdd(ref first, offset + 2);
                y = refAdd(ref second, offset + 2);
                if(gmath.neq(x, y))
                    return false;
                x = refAdd(ref first, offset + 3);
                y = refAdd(ref second, offset + 3);
                if(gmath.neq(x, y))
                    return false;

                offset += 4;
            }

            while (length > 0)
            {
                x = refAdd(ref first, offset);
                y = refAdd(ref second, offset);
                if(gmath.neq(x, y))
                    return false;
                offset += 1;
                length--;
            }

            return true;
        }

        //Adapted from corefx repo
        static bit contains<T>(ref T src, T match, int length)
            where T : unmanaged
        {
            IntPtr index = (IntPtr)0;

            while (length >= 8)
            {
                length -= 8;

                if (gmath.eq(match, refAdd(ref src, index + 0)) ||
                    gmath.eq(match, refAdd(ref src, index + 1)) ||
                    gmath.eq(match, refAdd(ref src, index + 2)) ||
                    gmath.eq(match, refAdd(ref src, index + 3)) ||
                    gmath.eq(match, refAdd(ref src, index + 4)) ||
                    gmath.eq(match, refAdd(ref src, index + 5)) ||
                    gmath.eq(match, refAdd(ref src, index + 6)) ||
                    gmath.eq(match, refAdd(ref src, index + 7)))
                return true;
                
                index += 8;
            }

            if (length >= 4)
            {
                length -= 4;

                if (gmath.eq(match, refAdd(ref src, index + 0)) ||
                    gmath.eq(match, refAdd(ref src, index + 1)) ||
                    gmath.eq(match, refAdd(ref src, index + 2)) ||
                    gmath.eq(match, refAdd(ref src, index + 3)))
                return true;

                index += 4;
            }

            while (length > 0)
            {
                length -= 1;

                if (gmath.eq(match, refAdd(ref src, index)))
                    return true;

                index += 1;
            }
            return false;        
        }  
    }
}