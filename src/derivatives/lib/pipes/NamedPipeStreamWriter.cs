//-----------------------------------------------------------------------------
// Derivative Work
// Origin:    : https://github.com/microsoft/scalar
// Copyright  : Microsoft/.Net foundation
// Copyright  : (c) Chris Moore, 2020
// License    :  MIT
//-----------------------------------------------------------------------------
namespace Z0.X.Pipes
{
    using System.IO;
    using System.Text;

    public class NamedPipeStreamWriter
    {
        const string TerminatorByteString = "\x3";

        Stream DataStream;

        public NamedPipeStreamWriter(Stream stream)
        {
            DataStream = stream;
        }

        public void WriteMessage(string message)
        {
            byte[] byteBuffer = Encoding.UTF8.GetBytes(message + TerminatorByteString);
            DataStream.Write(byteBuffer, 0, byteBuffer.Length);
            DataStream.Flush();
        }
    }
}
