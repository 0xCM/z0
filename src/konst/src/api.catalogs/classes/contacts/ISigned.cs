//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    /// <summary>
    /// Characterizes a type-level sign classifier
    /// </summary>
    public interface ISigned
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
    public interface ISigned<F> : ISigned
        where F : unmanaged, ISigned
    {

    }

    /// <summary>
    /// Characterizes an F-bound polymorphic and S-parametric sign classifier reification
    /// </summary>
    /// <typeparam name="F">The reifying type</typeparam>
    /// <typeparam name="S">The sign classifier type</typeparam>
    public interface ISigned<F,S> : ISigned<S>
        where S : unmanaged, ISigned
        where F : unmanaged, ISigned<F,S>
    {

    }

    /// <summary>
    /// Characterizes an F-bound polymorphic S/T-parametric sign classifier reification
    /// </summary>
    /// <typeparam name="F">The reifying type</typeparam>
    /// <typeparam name="S">The sign classifier type</typeparam>
    /// <typeparam name="T">The T-carrier, of any sort</typeparam>
    public interface ISigned<F,S,T> : ISigned<F,S>
        where S : unmanaged, ISigned
        where F : unmanaged, ISigned<F,S,T>
    {
        /// <summary>
        /// Reveals the singleton instance of the T-parametric classifier
        /// </summary>
        S SignType
            => default;

        /// <summary>
        /// Default implementation of <see cref="ISigned.Kind"/>
        /// </summary>
        SignKind ISigned.Kind
            => SignType.Kind;
    }
}