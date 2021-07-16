//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    public interface IRuleModel
    {

    }

    public interface IRuleModel<R> : IRuleModel
        where R : struct, IRuleModel<R>
    {

    }
}