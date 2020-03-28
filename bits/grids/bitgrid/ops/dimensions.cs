//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections.Generic;

    using static root;
    using static Nats;

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

        /// <summary>
        /// Computes dimension information for a grid predicated on parametric types
        /// </summary>
        /// <param name="m">The row count representative</param>
        /// <param name="n">The col count representative</param>
        /// <param name="t">The cell type representative</param>
        /// <typeparam name="M">The row type</typeparam>
        /// <typeparam name="N">The col type</typeparam>
        /// <typeparam name="T">The cell type</typeparam>
        public static GridDim<M,N,T> dimension<M,N,T>(M m = default, N n = default, T t = default)
            where M : unmanaged, ITypeNat
            where N : unmanaged, ITypeNat
            where T : unmanaged
                => default;

        /// <summary>
        /// Computes dimension information for a blocked grid predicated on parametric types
        /// </summary>
        /// <param name="w">The block width representative</param>
        /// <param name="m">The row count representative</param>
        /// <param name="n">The col count representative</param>
        /// <param name="t">The cell type representative</param>
        /// <typeparam name="W">The block width</typeparam>
        /// <typeparam name="M">The row type</typeparam>
        /// <typeparam name="N">The col type</typeparam>
        /// <typeparam name="T">The cell type</typeparam>
        public static GridDim<W,M,N,T> dimension<W,M,N,T>(W w = default, M m = default, N n = default, T t = default)
            where W : unmanaged, ITypeNat
            where M : unmanaged, ITypeNat
            where N : unmanaged, ITypeNat
            where T : unmanaged
                => default;

        /// <summary>
        /// Enunerates the valid grid dimensions where the total bit width is a power of 2
        /// </summary>
        /// <typeparam name="W">The grid dimension type</typeparam>
        public static IEnumerable<IDim2> p2dimensions<W>()
            where W : unmanaged,  ITypeNat<W>, INatPow2<W>
                => p2dimensions(natval<W>());

        /// <summary>
        /// Enunerates the valid grid dimensions where the total bit width is a power of 2
        /// </summary>
        /// <param name="w">A power of 2 that specifies the bit width of the grid</param>
        public static IEnumerable<IDim2> p2dimensions(ulong w)
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