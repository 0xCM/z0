//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    public interface ITextLineProcessor : IDataProcessor<TextLine>
    {

    }

    public interface ITextLineProcessor<T> : ITextLineProcessor
    {
        Outcome Process(in TextLine src, out T dst);

        Outcome IDataProcessor<TextLine>.Process(in TextLine src, out dynamic dst)
        {
            var outcome = Process(src, out var _dst);
            dst = _dst;
            return outcome;
        }
    }
}