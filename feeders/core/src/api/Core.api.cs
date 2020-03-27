//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Collections.Generic;
    using System.Threading;

    using static Components;

    public static class core
    {
        [MethodImpl(Inline)]
        public static int bitsize<T>()            
            => Unsafe.SizeOf<T>()*8;

        [MethodImpl(Inline)]
        public static int size<T>()
            => Unsafe.SizeOf<T>();

        /// <summary>
        /// Explicitly casts a source value to value of the indicated type, raising an exception if operation fails
        /// </summary>
        /// <param name="src">The source value</param>
        /// <typeparam name="T">The target type</typeparam>
        [MethodImpl(Inline)]   
        public static T cast<T>(object src) 
            => (T)src;

        [MethodImpl(Inline)]
        public static IEnumerable<T> seq<T>(params T[] src)
            => src;
        
        [MethodImpl(Inline)]
        public static T[] array<T>(params T[] src)
            => src;

        /// <summary>
        /// Joins the string representation of a sequence of items with no interspersed separator
        /// </summary>
        /// <param name="src">The values to be joined</param>
        public static string concat(params object[] src)    
            => string.Concat(src);
        
        public static void require(bool invariant)
        {
            if(!invariant)
                throw new Exception($"Application invaraiant failed");
        }

        /// <summary>
        /// Atomically increments a value in-place
        /// </summary>
        /// <param name="src">The value to increment in-place</param>
        [MethodImpl(Inline)]
        public static int increment(ref int src)
            => Interlocked.Increment(ref src);
 
        /// <summary>
        /// Atomically increments a value in-place
        /// </summary>
        /// <param name="src">The value to increment in-place</param>
        [MethodImpl(Inline)]
        public static long increment(ref long src)
            => Interlocked.Increment(ref src);

        public static void error(Exception e)
            => Console.Error.WriteLine(e);

        public static void error(object src)
            => Console.Error.WriteLine(src);

        [MethodImpl(Inline)]
        public static bool empty(string src)
            => string.IsNullOrWhiteSpace(src);

        [MethodImpl(Inline)]
        public static bool nonempty(string src)
            => !string.IsNullOrWhiteSpace(src);

    }
}