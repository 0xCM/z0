//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    public interface IIdentityBuilder<S,T>
        where T : struct
    {
        S Build(T src);
    }
}