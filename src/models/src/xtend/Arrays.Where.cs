//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Collections.Generic;
    using System.Linq;

    using static Konst;
    
    partial class XTend
    {
        /// <summary>
        /// Linq where operator specialized for arrays
        /// </summary>
        /// <param name="src">The source array</param>
        /// <param name="f"></param>
        /// <typeparam name="T">The array element type</typeparam>
        [MethodImpl(Inline)]
        public static T[] Where<T>(this T[] src, Func<T,bool> f)
            => filter(src,f);

        /// <summary>
        /// Result = Filter + Project
        /// </summary>
        /// <param name="src"></param>
        /// <param name="test"></param>
        /// <param name="project"></param>
        /// <typeparam name="S"></typeparam>
        /// <typeparam name="T"></typeparam>
        public static T[] Where<S,T>(this S[] src, Func<S,bool> test, Func<S,T> project)
            => map(filter(src,test), project);


        /// <summary>
        /// Allocates and populates a new array by filtering the source array with 
        /// a specified predicate
        /// </summary>
        /// <param name="src">The soruce array</param>
        /// <param name="f">The predicate</param>
        /// <typeparam name="T">The array element type</typeparam>
        static T[] filter<T>(T[] src, Func<T,bool> f)
        {
            Span<T> dst = new T[src.Length];
            var count = 0;
            for(var i=0; i<src.Length; i++)
            {
                ref readonly var test = ref src[i];
                if(f(test))
                    dst[count++] = test;                    
            }   
            return dst.Slice(0, count).ToArray();
        }
    }
}