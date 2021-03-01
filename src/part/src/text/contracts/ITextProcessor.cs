//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    public interface ITextProcessor<T>
    {
        Outcome Parse(string src, out T dst);

        void Render(in T src, ITextBuffer dst);

        string Format(in T src);
    }
}