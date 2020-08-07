//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{    
    public delegate IIdentifiedCodeWriter UriHexWriterFactory(FilePath dst);

    public interface IIdentifiedCodeWriter : IFileStreamWriter
    {        
        void Write(IdentifiedCode src, int uripad);
    }
}