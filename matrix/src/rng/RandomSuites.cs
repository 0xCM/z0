//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Runtime.CompilerServices;

    using static Root;

    /// <summary>
    /// Characterizes a suite of random number generators
    /// </summary>
    /// <typeparam name="N">The number of generators in the suite</typeparam>
    public interface IRngSuite256<N>
        where N : unmanaged, ITypeNat
    {
        /// <summary>
        /// Retrieves the next vector from the suite, where the components 
        /// are bound only by the domain of the type
        /// </summary>
        RowVector256<N,T> Next<T>()
            where T : unmanaged;

        /// <summary>
        /// Retrieves the next vector from the suite, where each component is 
        /// constrained by an upper bound
        /// </summary>
        /// <param name="max">The exclusive upper bound</param>
        /// <typeparam name="T">The point type</typeparam>
        RowVector256<N,T> Next<T>(T max)
            where T : unmanaged;

        /// <summary>
        /// Retrieves the next vector from the suite, where each component is 
        /// constrained by both lower and upper bounds
        /// </summary>
        /// <param name="min">The inclusive lower bound</param>
        /// <param name="max">The exclusive upper bound</param>
        /// <typeparam name="T">The point type</typeparam>
        RowVector256<N,T> Next<T>(T min, T max)
            where T : unmanaged;

        /// <summary>
        /// Retrieves the next vector from the suite, where each component is 
        /// constrained by an interval domain
        /// </summary>
        /// <param name="domain">The range</param>
        /// <typeparam name="T">The point type</typeparam>
        RowVector256<N,T> Next<T>(Interval<T> domain)
            where T : unmanaged;
        
        /// <summary>
        /// Retrieves the generator corresponding to a specified index that
        /// is in the range 0, 1, ..., N - 1
        /// </summary>
        /// <param name="index">The rng index</param>
        IPolyrand Select(int index);
    }
    /// <summary>
    /// Defines a suite of random number generators
    /// </summary>
    /// <typeparam name="N">The number of generators in the suite</typeparam>
    public class RngSuite256<N> : IRngSuite256<N>
        where N : unmanaged, ITypeNat
    {
        readonly IPolyrand[] members;

        static readonly int n = (int)new N().NatValue;        

        public RngSuite256(IPolyrand[] members)
        {
            this.members = members.ToArray();
            core.require(this.members.Length == n);
        }

        public RngSuite256(IEnumerable<IPolyrand> members)
        {
            this.members = members.ToArray();
            core.require(this.members.Length == n);
        }

        public RowVector256<N, T> Next<T>() 
            where T : unmanaged
        {
            var dst = RowVector.blockalloc<N,T>();
            for(var i=0; i<n; i++)
                dst[i] = members[i].Next<T>();
            return dst;
        }

        public RowVector256<N, T> Next<T>(T min) 
            where T : unmanaged
        {
            var dst = RowVector.blockalloc<N,T>();
            for(var i=0; i<n; i++)
                dst[i] = members[i].Next<T>(min);
            return dst;
        }

        public RowVector256<N, T> Next<T>(T min, T max) 
            where T : unmanaged
        {
            var dst = RowVector.blockalloc<N,T>();
            for(var i=0; i<n; i++)
                dst[i] = members[i].Next<T>(min,max);
            return dst;
        }

        public RowVector256<N, T> Next<T>(Interval<T> domain)
             where T : unmanaged
        {
            var dst = RowVector.blockalloc<N,T>();
            for(var i=0; i<n; i++)
                dst[i] = members[i].Next<T>(domain);
            return dst;
        }

        public IPolyrand Select(int index)
            => members[index];


    }

}
