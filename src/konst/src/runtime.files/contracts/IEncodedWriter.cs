//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    public interface IEncodedWriter<H> : IArchiveWriter
        where H : struct, IEncodedWriter<H>
    {

    }

    public interface IEncodedWriter<H,T> : IEncodedWriter<H>, IArchiveWriter<H>
        where T : struct, IEncoded<T>
        where H : struct, IEncodedWriter<H,T>
    {
        void Write(in T code);
    }
}