//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{

    using K = ApiBitShiftClass;

    /// <summary>
    /// Characterizes a bitshift operation classifier
    /// </summary>
    public interface IApiBitShiftClass : IApiClass<K>
    {
        new ApiBitShiftClass Kind {get;}

        K IApiClass<K>.Kind
            => Kind;
    }
}