//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{        
    using System;
    using System.Collections.Generic;
    using System.Linq;
    
    public interface IAnySeq : IContentAggregate
    {
        
    }

    public interface IAnySeq<T> : IAnySeq, IContainer<IEnumerable<T>>, IContentAggregate<T>
    {        
        IEnumerable<T> IContentAggregate<T>.Items
            => Content;
    }

    public delegate C AnySeqFactory<T,C>(IEnumerable<T> terms)
        where C: IAnySeq<C,T>, new();         

    public interface IAnySeq<C,T> : IAnySeq<T>, IAny<C>, IContainer<C, IEnumerable<T>, T>
        where C: IAnySeq<C,T>, new()         
    {
        /// <summary>
        ///  A self-hosted factory
        /// </summary>
        AnySeqFactory<T,C> Factory {get;}
        
        /// <summary>
        /// It is not assumed that sequence is finite; in discrete computing
        /// context, concrete evaluation (i.e. non-symbolic evaluation) of
        /// infinite...anything...isn't possible. Equality evaluation of two (potentially) infinite 
        /// sequences is not a well-defined operation and in the face of problem, the only
        /// think that can be done to make it a well-defined operation is to simply define
        /// the result to be false, which is what is done here
        /// </summary>
        /// <param name="src">The sequenct that will not be compared to this one</param>
        bool IEquatable<C>.Equals(C src)
            => false;

        /// <summary>
        /// Creates the empty sequence
        /// </summary>
        public static C Empty => Create();

        private static C Create(params T[] src) => Empty.Factory(src);

        /// <summary>
        /// Creates a concrete sequence from a source enumerable
        /// </summary>
        /// <param name="src">The term source</param>
        public static C Create(IEnumerable<T> src) => Empty.Factory(src);
    }

    public interface IAnyFormattableSeq<T> : IAnySeq<T>, ICustomFormattable
        where T : ICustomFormattable
    {
        string ICustomFormattable.Format()
            => Items.FormatList();        
    }
}