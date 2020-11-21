//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using Free = System.Security.SuppressUnmanagedCodeSecurityAttribute;

    [Free]
    public interface ITrigger<T> : IConditionTest<T>
    {
        void TryFire(T src);
    }

    [Free]
    public interface IDataTrigger<T> : ITrigger<T>, IDataConditionTest<T>
        where T : struct
    {
        void TryFire(in T src);

        void ITrigger<T>.TryFire(T src)
            => TryFire(src);
    }
}