//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using Free = System.Security.SuppressUnmanagedCodeSecurityAttribute;

    using K = ApiBitLogicClass;

    /// <summary>
    /// Characterizes a bitlogic operation classifier
    /// </summary>
    [Free]
    public interface IApiBitLogicClass : IApiClass<K>
    {
        new K Kind {get;}

        K IApiClass<K>.Kind
            => Kind;

        NumericKind NumericKind
            => default;
    }

    /// <summary>
    /// Characterizes a kind-parametric and numeric-parametric bitlogic operation classifier
    /// </summary>
    /// <typeparam name="F">The kind classifier type</typeparam>
    /// <typeparam name="T">The numeric type</typeparam>
    [Free]
    public interface IApiBitLogicClass<F,T> : IApiBitLogicClass
        where F : unmanaged, IApiBitLogicClass
    {
        ApiBitLogicClass IApiBitLogicClass.Kind
            => default(F).Kind;
    }
}