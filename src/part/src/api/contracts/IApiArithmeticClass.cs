//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using K = ApiArithmeticClass;
    using I = IApiArithmeticApClass;

    /// <summary>
    /// Characterizes an arithmetic function classifier
    /// </summary>
    public interface IApiArithmeticApClass : IApiKind<K>
    {
        /// <summary>
        /// The literal identifier that will be lifted to the type-level
        /// </summary>
        new K Kind {get;}

        NumericKind OperandKind
            => default;
    }

    /// <summary>
    /// Characterizes a kind-parametric and numeric-parametric arithmetic operation classifier
    /// </summary>
    /// <typeparam name="F">The kind classifier type</typeparam>
    /// <typeparam name="T">The numeric type</typeparam>
    public interface IApiArithmeticClass<F,T> : IApiArithmeticApClass
        where F : unmanaged, IApiArithmeticApClass
    {
        K I.Kind
            => default(F).Kind;

        /// <summary>
        /// The parametrically-identified numeric kind
        /// </summary>
        NumericKind IApiArithmeticApClass.OperandKind
            => Numeric.kind<T>();
    }
}