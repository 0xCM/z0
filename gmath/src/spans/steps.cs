//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
        
    using static zfunc;    

    partial class mathspan
    {
        public static Span<T> steps<T>(T first, T last)
            where T : unmanaged
        {
            var src = steps(convert<T,long>(first), convert<T,long>(last));
            Span<T> dst = new T[src.Length];
            for(var i=0; i< dst.Length; i++)
                dst[i] = convert<T>(src[i]);
            return dst;
        }

        static Span<long> steps(long first, long last)
        {
            if(first == last)
                return Span<long>.Empty;
            
            var length = math.abs(first - last) + 1;
            Span<long> dst = new long[length];
            var pos = 0;
            if(first < last)
            {
                var current = first;
                while(current <= last)
                    dst[pos++] = current++;                
            }
            else
            {
                var current = first;
                while(current >= last)
                    dst[pos++] = current--;                

            }   
            return dst;         
        }
    }
}