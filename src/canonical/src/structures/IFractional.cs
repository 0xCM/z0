//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    public interface IFractional<S> : IRealNumber<S>
        where S : IFractional<S>, new()
    {
        S Ceil();

        S Floor();
    }

    /// <summary>
    /// Characterizes a fractional structure
    /// </summary>
    /// <typeparam name="T">The operand type</typeparam>
    public interface IFractional<S,T> : IFractional<S>, IRealNumber<S,T>
        where S : IFractional<S,T>, new()
    {

    }
}