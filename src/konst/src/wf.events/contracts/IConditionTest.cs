//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using Free = System.Security.SuppressUnmanagedCodeSecurityAttribute;

    [Free]
    public interface IConditionTest<T>
    {
        bool TestCondition(T src);
    }

    [Free]
    public interface IDataConditionTest<T> : IConditionTest<T>
        where T : struct
    {
        bool TestCondition(in T src);

        bool IConditionTest<T>.TestCondition(T src)
            => TestCondition(src);
    }
}