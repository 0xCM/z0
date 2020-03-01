//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{        
    using System;
    using System.Collections;
    using System.Runtime.CompilerServices;
    using System.Collections.Generic;
    using System.Linq;
    
    using static Root;

    public interface IAnySeq<T> : IEnumerable<T>
    {

    }

    public interface IAnySeq<P,T> : IAnySeq<T>, IAny<P>
        where P: IAnySeq<P,T>, new()         
    {
        /// <summary>
        ///  A self-hosted factory
        /// </summary>
        Func<IEnumerable<T>,P> Factory {get;}

        /// <summary>
        /// The sequence terms
        /// </summary>
        IEnumerable<T> Terms {get;}

        IEnumerator IEnumerable.GetEnumerator()
            => Terms.GetEnumerator();

        IEnumerator<T> IEnumerable<T>.GetEnumerator()
            => Terms.GetEnumerator();

        
        /// <summary>
        /// It is not assumed that sequence is finite; in discrete computing
        /// context, concrete evaluation (i.e. non-symbolic evaluation) of
        /// infinite...anything...isn't possible. Equality evaluation of two (potentially) infinite 
        /// sequences is not a well-defined operation and in the face of problem, the only
        /// think that can be done to make it a well-defined operation is to simply define
        /// the result to be false, which is what is done here
        /// </summary>
        /// <param name="src">The sequenct that will not be compared to this one</param>
        bool IEquatable<P>.Equals(P src)
            => false;

        /// <summary>
        /// Creates the empty sequence
        /// </summary>
        public static P Empty => Create();

        private static P Create(params T[] src) => Empty.Factory(src);

        /// <summary>
        /// Creates a concrete sequence from a source enumerable
        /// </summary>
        /// <param name="src">The term source</param>
        public static P Create(IEnumerable<T> src) => Empty.Factory(src);

    }


}