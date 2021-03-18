//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using K = ApiComparisonClass;
    using I = IApiComparisonClass;

    /// <summary>
    /// Characterizes a bitshift operation classifier
    /// </summary>
    public interface IApiComparisonClass : IApiKind<K>
    {
        new K Kind {get;}
    }

    /// <summary>
    /// Characterizes a kind-parametric and numeric-parametric comparison operation classifier
    /// </summary>
    /// <typeparam name="F">The kind classifier type</typeparam>
    /// <typeparam name="T">The numeric type</typeparam>
    public interface IApiComparisonClass<F,T> : IApiComparisonClass
        where F : unmanaged, IApiComparisonClass
    {
        K I.Kind => default(F).Kind;

        /// <summary>
        /// The parametrically-identified numeric kind
        /// </summary>
        NumericKind NumericKind
            => Numeric.kind<T>();
    }
}