//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using K = ApiBitFunctionClass;

    /// <summary>
    /// Characterizes a bitfunction classifier
    /// </summary>
    public interface IApiBitFunctionClass : IApiClass<K>
    {
        new ApiBitFunctionClass Kind {get;}

        K IApiClass<K>.Kind
            => Kind;
    }
}