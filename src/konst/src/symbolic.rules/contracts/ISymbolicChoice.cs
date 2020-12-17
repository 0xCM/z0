//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    public interface ISymbolicChoice<T> : IChoice<T>, ISymbolicRule<T>
        where T : unmanaged
    {

    }

    public interface ISymbolicChoice<H,T> : IChoice<H,T>, ISymbolicRule<T>
        where T : unmanaged
        where H : ISymbolicChoice<H,T>
    {

    }
}