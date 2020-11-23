//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    public interface ITextRenderService<H,S> : IRenderService<S,string,IRenderBuffer<S,string>>
        where H : ITextRenderService<H,S>
    {

    }
}