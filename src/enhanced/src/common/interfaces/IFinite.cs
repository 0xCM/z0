//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    /// <summary>
    /// Characterizes a type for which a well-defined Count() function can be implemented
    /// such types will be referred to as "countable" athough this terminology unfortunately conflicts
    /// with mathematical countability wich only requries the existence of a bijection with
    /// the subject and the natural numbers which does imply that the cardinality is finite
    /// </summary>
    public interface IFinite
    {
        /// <summary>
        /// Counts the finite things
        /// </summary>
        int Count();   
    }

    /// <summary>
    /// Characterizes a finite thing that yeilds a count value that does not require computation/enumeration 
    /// to reveal; in other words, the count function for counted things is free, as evinced by
    /// the default implementation
    /// </summary>
    public interface ICounted : IFinite, INullity
    {
        /// <summary>
        /// The count value
        /// </summary>
        new int Count {get;}

        int IFinite.Count() 
            => Count;

        bool INullity.IsEmpty 
            => Count == 0;
    }
}