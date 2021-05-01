//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    /// <summary>
    /// Characterizes a bitshift operation classifier
    /// </summary>
    public interface IApiBitShiftClass : IApiKind<ApiBitShiftClass>
    {
        new ApiBitShiftClass Kind {get;}
    }

    /// <summary>
    /// Characterizes a kind-parametric and numeric-parametric bitshift operation classifier
    /// </summary>
    /// <typeparam name="K">The kind classifier type</typeparam>
    /// <typeparam name="T">The numeric type</typeparam>
    public interface IApiBitShiftClass<K,T> : IApiBitShiftClass
        where K : unmanaged, IApiBitShiftClass
    {
        ApiBitShiftClass IApiBitShiftClass.Kind
            => default(K).Kind;

        /// <summary>
        /// The parametrically-identified numeric kind
        /// </summary>
        NumericKind NumericKind
            => Numeric.kind<T>();
    }
}