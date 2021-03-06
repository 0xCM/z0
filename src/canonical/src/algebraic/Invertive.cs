//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    /// <summary>
    /// Characterizes operational inversion
    /// </summary>
    /// <typeparam name="T">The operand type</typeparam>
    public interface IInversionOps<T>
    {

    }

    /// <summary>
    /// Characterizes operational multiplicative inversion
    /// </summary>
    /// <typeparam name="T">The operand type</typeparam>
    public interface InversionMOps<T> : IInversionOps<T>
    {
        /// <summary>
        /// Multiplicative inversion
        /// </summary>
        /// <param name="x">The value to invert</param>
        T InvertM(T x);
    }

    /// <summary>
    /// Characterizes operational additive inversion
    /// </summary>
    /// <typeparam name="T">The operand type</typeparam>
    public interface InvertiveA<T> : IInversionOps<T>
    {
        /// <summary>
        /// Additive inversion
        /// </summary>
        /// <param name="x">The value to invert</param>
        T InvertA(T x);
    }

    /// <summary>
    /// Characterizes structural inversion
    /// </summary>
    /// <typeparam name="T">The type over which the structure is defined</typeparam>
    public interface IInvertive<S>
    {

    }

    /// <summary>
    /// Characterizes structural multiplicative inversion
    /// </summary>
    /// <typeparam name="S">The reification type</typeparam>
    public interface IInvertiveM<S> : IInvertive<S>, IMultiplicative<S>
        where S : IInvertiveM<S>, new()
    {
        /// <summary>
        /// Effects multiplicative inversion
        /// </summary>
        S InvertM();
    }

    /// <summary>
    /// Characterizes structural additive inversion
    /// </summary>
    /// <typeparam name="S">The reification type</typeparam>
    public interface IInvertiveA<S> : IInvertive<S>, IAdditive<S>
        where S : IInvertiveA<S>, new()
    {
        /// <summary>
        /// Effects additive inversion
        /// </summary>
        S InvertA();
    }

}
