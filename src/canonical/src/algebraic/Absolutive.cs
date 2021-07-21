//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    public interface IAbsolutiveOps<T>
        where T : unmanaged
    {
        T Abs(T x);
    }

    public interface Absolitive<S>
        where S : Absolitive<S>,new()
    {
        S Abs();
    }

}