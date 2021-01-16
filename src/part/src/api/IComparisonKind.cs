//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using K = ComparisonApiClass;
    using I = IComparisonApiKey;

    /// <summary>
    /// Characterizes a bitshift operation classifier
    /// </summary>
    public interface IComparisonApiKey : IApiKey, IApiKind<K>
    {
        K Kind {get;}

        ApiClass IApiKey.Id
            => (ApiClass)Kind;
    }

    /// <summary>
    /// Characterizes a reified comparison operation classifier
    /// </summary>
    /// <typeparam name="F">The reification type</typeparam>
    public interface IComparisonKind<F> : I, IApiKind<F,K>
        where F : unmanaged, I
    {
        ApiClass IApiKey.Id
            => default(F).Id;
    }


}