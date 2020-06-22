//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    /// <summary>
    /// Characterizes identified code with a known address
    /// </summary>
    /// <typeparam name="F"></typeparam>
    /// <typeparam name="C"></typeparam>
    public interface IMemberCode<F,C> : ILocatedCode<F,C>, IIdentifiedCode<F,C>
        where F : struct, IEncoded<F,C>
    {

    }
}