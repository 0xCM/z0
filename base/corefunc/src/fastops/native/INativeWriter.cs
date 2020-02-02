//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.IO;
 
    using static zfunc;

    public interface INativeWriter : IDisposable
    {
        void WriteHeader();

        void WriteData(CapturedMember src);        
    
        void WriteData(CapturedMember src, NativeFormatConfig config);     

        void WriteLine(string data);   

        byte[] TakeBuffer();        
    }
}