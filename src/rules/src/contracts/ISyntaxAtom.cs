//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    public interface ISyntaxAtom : ISyntaxElement
    {

    }

    public interface ISyntaxAtom<K> : ISyntaxAtom
        where K : unmanaged
    {
        K Code {get;}

        string ITextual.Format()
            => string.Format(RenderPattern,Code);

        string ISyntaxElement.RenderPattern
            => "{0:g}";
    }

    public interface ISyntaxAtom<H,K> : ISyntaxAtom<K>, ISyntaxElement<H,K>
        where K : unmanaged
        where H : struct, ISyntaxAtom<H,K>
    {

    }
}