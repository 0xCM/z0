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
}