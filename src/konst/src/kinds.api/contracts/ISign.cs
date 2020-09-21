//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
   /// <summary>
    /// Characterizes a type-level sign classifier
    /// </summary>
    public interface ISign
    {
        /// <summary>
        /// Specifies the literal classifier the type-level classifier represents
        /// </summary>
        SignKind Kind {get;}
    }

    /// <summary>
    /// Characterizes an F-bound polymorphic type-level sign classifier reification
    /// </summary>
    /// <typeparam name="F">The reifying type</typeparam>
    public interface ISign<F> : ISign
        where F : unmanaged, ISign
    {

    }

    /// <summary>
    /// Characterizes an F-bound polymorphic and S-parametric sign classifier reification
    /// </summary>
    /// <typeparam name="F">The reifying type</typeparam>
    /// <typeparam name="S">The sign classifier type</typeparam>
    public interface ISign<F,S> : ISign<S>
        where S : unmanaged, ISign
        where F : unmanaged, ISign<F,S>
    {

    }

    /// <summary>
    /// Characterizes an F-bound polymorphic S/T-parametric sign classifier reification
    /// </summary>
    /// <typeparam name="F">The reifying type</typeparam>
    /// <typeparam name="S">The sign classifier type</typeparam>
    /// <typeparam name="T">The T-carrier, of any sort</typeparam>
    public interface ISign<F,S,T> : ISign<F,S>
        where S : unmanaged, ISign
        where F : unmanaged, ISign<F,S,T>
    {
        /// <summary>
        /// Reveals the singleton instance of the T-parametric classifier
        /// </summary>
        S SignType
            => default;

        /// <summary>
        /// Default implementation of <see cref="ISign.Kind"/>
        /// </summary>
        SignKind ISign.Kind
            => SignType.Kind;
    }
}