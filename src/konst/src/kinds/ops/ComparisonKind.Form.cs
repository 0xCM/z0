//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{

    using static Konst;

    using K = ComparisonKind;
    using I = IComparisonKind;

    /// <summary>
    /// Characterizes a bitshift operation classifier
    /// </summary>
    public interface IComparisonKind : IOpKind, IOpKind<K>
    {
        K Kind {get;}

        OpKindId IOpKind.KindId 
            => (OpKindId)Kind;
    }    

    /// <summary>
    /// Characterizes a reified comparison operation classifier
    /// </summary>
    /// <typeparam name="F">The reification type</typeparam>
    public interface IComparisonKind<F> : I, IOpKind<F,K>
        where F : unmanaged, I
    {
        OpKindId IOpKind.KindId 
            => default(F).KindId;                
    }

    /// <summary>
    /// Characterizes a kind-parametric and numeric-parametric comparison operation classifier
    /// </summary>
    /// <typeparam name="F">The kind classifier type</typeparam>
    /// <typeparam name="T">The numeric type</typeparam>
    public interface IComparisonKind<F,T> : IComparisonKind<F>
        where F : unmanaged, I
    {
        K I.Kind => default(F).Kind;

        /// <summary>
        /// The parametrically-identified numeric kind
        /// </summary>
        NumericKind NumericKind 
            => nkind<T>();
    }
}