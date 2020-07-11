//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    public interface IParsedExtract<F,C> : IReflectedCode<F,C>, IIdentifiedCode<F,C>
        where F : struct, IEncoded<F,C>

    {

    }
}