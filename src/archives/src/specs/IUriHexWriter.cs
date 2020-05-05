//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{    
    using System;

    public delegate IUriHexWriter UriHexWriterFactory(FilePath dst);

    public interface IUriHexWriter : IFileStreamWriter<UriHex>
    {        
        void Write(UriHex src, int uripad);
    }
}