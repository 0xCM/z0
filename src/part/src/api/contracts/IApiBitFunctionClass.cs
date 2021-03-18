//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using K = ApiBitFunctionClass;
    using I = IApiBitFunctionClass;

    /// <summary>
    /// Characterizes a bitfunction classifier
    /// </summary>
    public interface IApiBitFunctionClass : IApiKind<K>
    {
        new ApiBitFunctionClass Kind {get;}
    }

    /// <summary>
    /// Characterizes a kind-parametric and numeric-parametric bitfunction operation classifier
    /// </summary>
    /// <typeparam name="K">The kind classifier type</typeparam>
    /// <typeparam name="T">The numeric type</typeparam>
    public interface IApiBitFunctionClass<F,T> : IApiBitFunctionClass
        where F : unmanaged, IApiBitFunctionClass
    {
        K I.Kind
            => default(F).Kind;
    }
}