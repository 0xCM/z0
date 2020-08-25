//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    public interface IIdentifiedCodeWriter : IArchiveWriter
    {
        void Write(in IdentifiedCode src, int uripad);
    }

    public interface IIdentifiedCodeWriter<H> : IIdentifiedCodeWriter, IEncodedWriter<H,IdentifiedCode>
        where H : struct, IIdentifiedCodeWriter<H>
    {

    }
}