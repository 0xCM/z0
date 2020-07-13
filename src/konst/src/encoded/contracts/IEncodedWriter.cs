//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    public interface IWriterConfig
    {

    }
    
    public interface IEncodedWriter<T> : IFileStreamWriter
        where T : struct, IEncoded<T>
    {
        void Write(in T code);
    }

    public interface IEncodedWriter<T,C> : IEncodedWriter<T>
        where T : struct, IEncoded<T>
        where C : unmanaged, IWriterConfig
    {
        void Write(in T code, C config);  

        void IEncodedWriter<T>.Write(in T code)
            => Write(code, default(C));
    }    
}