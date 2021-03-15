//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;
    using static gmath;
    using static memory;

    partial struct gAlg
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
            return identical(ref first(xs), ref first(ys), (uint)xs.Length);
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
            return identical(ref edit(in first(xs)), ref edit(in first(ys)), (uint)xs.Length);
        }

        /// <summary>
        ///  Adapted from corefx repo
        /// </summary>
        [Op, Closures(UnsignedInts)]
        public static bit identical<T>(ref T first, ref T second, uint count)
            where T : unmanaged
        {
            if (Unsafe.AreSame(ref first, ref second))
                return true;

            var offset = 0;
            T x;
            T y;
            while (count >= 8)
            {
                count -= 8;

                x = add<T>(first, offset + 0);
                y = add<T>(second, offset + 0);
                if(neq(x, y))
                    return false;
                x = add<T>(first, offset + 1);
                y = add<T>(second, offset + 1);
                if(neq(x, y))
                    return false;
                x = add<T>(first, offset + 2);
                y = add<T>(second, offset + 2);
                if(neq(x, y))
                    return false;
                x = add<T>(first, offset + 3);
                y = add<T>(second, offset + 3);
                if(neq(x, y))
                    return false;
                x = add<T>(first, offset + 4);
                y = add<T>(second, offset + 4);
                if(neq(x, y))
                    return false;
                x = add<T>(first, offset + 5);
                y = add<T>(second, offset + 5);
                if(neq(x, y))
                    return false;
                x = add<T>(first, offset + 6);
                y = add<T>(second, offset + 6);
                if(neq(x, y))
                    return false;
                x = add<T>(first, offset + 7);
                y = add<T>(second, offset + 7);
                if(neq(x, y))
                    return false;

                offset += 8;
            }

            if (count >= 4)
            {
                count -= 4;

                x = add<T>(first, offset);
                y = add<T>(second, offset);
                if(gmath.neq(x, y))
                    return false;
                x = add<T>(first, offset + 1);
                y = add<T>(second, offset + 1);
                if(gmath.neq(x, y))
                    return false;
                x = add<T>(first, offset + 2);
                y = add<T>(second, offset + 2);
                if(gmath.neq(x, y))
                    return false;
                x = add<T>(first, offset + 3);
                y = add<T>(second, offset + 3);
                if(gmath.neq(x, y))
                    return false;

                offset += 4;
            }

            while (count > 0)
            {
                x = add<T>(first, offset);
                y = add<T>(second, offset);
                if(gmath.neq(x, y))
                    return false;
                offset += 1;
                count--;
            }

            return true;
        }
    }
}