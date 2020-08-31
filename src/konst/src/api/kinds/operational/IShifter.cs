//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    public interface IShifter<T>
    {
        T Sll(T src, uint count);

        T Srl(T src, uint rhs);
    }
    
    public interface IShiftable<F,T> : IReified<F>
        where F : IShiftable<F,T>, new()
    {
        F Sll(uint count);

        F Srl(uint rhs);
    }
}