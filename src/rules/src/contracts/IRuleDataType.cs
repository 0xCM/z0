//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    public interface IRuleDataType : IType
    {

    }

    public interface IRuleDataType<T> : IRuleDataType, IType<T>
        where T : IRuleDataType<T>, new()
    {

    }
}