//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    partial class Root
    {
        /// <summary>
        /// Allocates and populates a new array by filtering the source array with 
        /// a specified predicate
        /// </summary>
        /// <param name="src">The soruce array</param>
        /// <param name="f">The predicate</param>
        /// <typeparam name="T">The array element type</typeparam>
        public static T[] filter<T>(T[] src, Func<T,bool> f)
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