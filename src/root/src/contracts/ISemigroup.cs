//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using Free = System.Security.SuppressUnmanagedCodeSecurityAttribute;

    [Free]
    public interface ISemigroup<T>
    {

    }

    [Free]
    public interface ISemigroup<F,T> : ISemigroup<T>
        where F : ISemigroup<F,T>, new()
    {

    }

    [Free]
    public interface ISemigroupOps<T>
    {
        /// <summary>
        /// Adjudicates equality between semigroup members
        /// </summary>
        /// <param name="lhs">The first operand</param>
        /// <param name="rhs">The second operand</param>
        bool Equals(T lhs, T rhs);
    }
}