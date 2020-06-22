//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{    
    public delegate IUriHexWriter UriHexWriterFactory(FilePath dst);

    public interface IUriHexWriter : IFileStreamWriter<IdentifiedCode>
    {        
        void Write(IdentifiedCode src, int uripad);
    }
}