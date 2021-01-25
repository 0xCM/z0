//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using K = LogicApiClass;
    using I = ILogicApiKey;

    /// Characterizes a bitfunction classifier
    /// </summary>
    public interface ILogicApiKey : IApiKey, IApiKind<K>
    {
        K Kind {get;}

        ApiClass IApiKey.Id
            => (ApiClass)Kind;
    }
}