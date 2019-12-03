//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using System.Runtime.Intrinsics;
    using System.Collections.Generic;
    using System.Linq;
    using static zfunc;

    partial class BitGrid
    {                
        /// <summary>
        /// Enumerates the valid dimensions for a 16-bit fixed bitgrid
        /// </summary>
        /// <param name="w">The grid width selector</param>
        public static IEnumerable<IDim2> dimensions(N8 w)
        {
            yield return Dim.define(n1,n8);
            yield return Dim.define(n8,n1);
            yield return Dim.define(n2,n4);
            yield return Dim.define(n4,n2);
        }

        /// <summary>
        /// Enumerates the valid dimensions for a 16-bit fixed bitgrid
        /// </summary>
        /// <param name="w">The grid width selector</param>
        public static IEnumerable<IDim2> dimensions(N16 w)
        {
            yield return Dim.define(n1,n16);
            yield return Dim.define(n16,n1);
            yield return Dim.define(n2,n8);
            yield return Dim.define(n8,n2);
            yield return Dim.define(n4,n4);
        }

        /// <summary>
        /// Enumerates the valid dimensions for a 32-bit fixed bitgrid
        /// </summary>
        /// <param name="w">The grid width selector</param>
        public static IEnumerable<IDim2> dimensions(N32 w)
        {
            yield return Dim.define(n1,n32);
            yield return Dim.define(n32,n1);            
            yield return Dim.define(n2,n16);
            yield return Dim.define(n16,n2);            
            yield return Dim.define(n8,n4);
            yield return Dim.define(n4,n8);
        }

        /// <summary>
        /// Enumerates the valid dimensions for a 64-bit fixed bitgrid
        /// </summary>
        /// <param name="w">The grid width selector</param>
        public static IEnumerable<IDim2> dimensions(N64 w)
        {
            yield return Dim.define(n1,n64);
            yield return Dim.define(n64,n1);            
            yield return Dim.define(n2,n32);
            yield return Dim.define(n32,n2);            
            yield return Dim.define(n16,n4);
            yield return Dim.define(n4,n16);
            yield return Dim.define(n8,n8);
        }

        /// <summary>
        /// Enumerates the valid dimensions for a 128-bit fixed bitgrid
        /// </summary>
        /// <param name="w">The grid width selector</param>
        public static IEnumerable<IDim2> dimensions(N128 w)
        {
            yield return Dim.define(n1,n128);
            yield return Dim.define(n128,n1);            
            yield return Dim.define(n2,n64);
            yield return Dim.define(n64,n2);            
            yield return Dim.define(n32,n4);
            yield return Dim.define(n4,n32);
            yield return Dim.define(n8,n16);
            yield return Dim.define(n16,n8);
        }

        /// <summary>
        /// Enumerates the valid dimensions for a 256-bit fixed bitgrid
        /// </summary>
        /// <param name="w">The grid width selector</param>
        public static IEnumerable<IDim2> dimensions(N256 w)
        {
            yield return Dim.define(n1,n256);
            yield return Dim.define(n256,n1);            
            yield return Dim.define(n2,n128);
            yield return Dim.define(n128,n2);            
            yield return Dim.define(n64,n4);
            yield return Dim.define(n4,n64);
            yield return Dim.define(n8,n32);
            yield return Dim.define(n32,n8);
            yield return Dim.define(n16,n16);
        }

        public static IEnumerable<IDim2> dimensions(ulong w)
        {
            ulong m = 1;
            ulong n = w;
            var failsafe = 65;

            if(math.ispow2(w))
            {
                while(--failsafe >= 0)
                {
                    yield return Dim.define(m,n);

                    if(m == n)
                        break;

                    yield return Dim.define(n,m);

                    m <<= 1;
                    
                    if(m == n)
                        break;

                    n >>= 1;
                }
            }
        }
    }

}