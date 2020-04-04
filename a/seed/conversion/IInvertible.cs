//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{

    public interface IInvertible<F>
        where F : IInvertible<F>, new()
    {
        /// <summary>
        /// Unary structural negation
        /// </summary>
        F Invert();
    }

    /// <summary>
    /// Characterizes a signed structure that supports in-place sign specification
    /// </summary>
    /// <typeparam name="T">The operand type</typeparam>
    public interface IResignable<F> : ISigned<F>, IInvertible<F>
        where F : IResignable<F>, new()
    {
        /// <summary>
        /// Aligns the structure with a specified sign
        /// </summary>
        F Resign(Sign sign);
    }    
}