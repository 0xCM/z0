//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    public interface IPresenter<S,T>
    {
        T Present(S src);

        void Present(in S src, out T dst)
            => dst = Present(src);
    }

    public interface ITextPresenter<S> : IPresenter<S,string>
    {

    }
}