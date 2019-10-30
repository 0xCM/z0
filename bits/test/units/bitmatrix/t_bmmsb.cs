//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;
    using System.Reflection;
    using System.Runtime.CompilerServices;

    using static zfunc;
    
    public class t_bmmsb : BitMatrixTest<t_bmor>
    {





        public static Span<int> steps(int first, int last)
        {
            if(first == last)
                return Span<int>.Empty;
            
            var length = math.abs(first - last) + 1;
            Span<int> dst = new int[length];
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