//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    public interface IIdentifiedCodeWriter : IArchiveWriter
    {
        void Write(in ApiHex src, int uripad);
    }

    public interface IIdentifiedCodeWriter<H> : IIdentifiedCodeWriter, IEncodedWriter<H,ApiHex>
        where H : struct, IIdentifiedCodeWriter<H>
    {

    }
}