//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{

    public interface IRenderFunction
    {
        void Render(dynamic src, ITextBuffer dst);
    }

    public interface IRenderFunction<T> : IRenderFunction
    {
        void Render(in T src, ITextBuffer dst);

        void IRenderFunction.Render(dynamic src, ITextBuffer dst)
            => Render((T)src, dst);
    }
}