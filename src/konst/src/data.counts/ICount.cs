//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    public interface ICount : ICounted, ITextual
    {

    }

    public interface ICount<F,T> : ICount, ICounted<T>
        where T : unmanaged
        where F : unmanaged, ICount<F,T>
    {
        string ITextual.Format()
            => Value.ToString();
    }
}