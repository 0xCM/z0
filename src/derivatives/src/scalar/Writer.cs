//-----------------------------------------------------------------------------
// Derivative Work
// Origin:    : https://github.com/microsoft/scalar
// Copyright  : Microsoft/.Net foundation
// Copyright  : (c) Chris Moore, 2020
// License    :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Derivatives.Scalar
{
    using System.IO;
    using System.Text;

    public class NamedPipeStreamWriter
    {
        private const string TerminatorByteString = "\x3";

        Stream DataStream;

        public NamedPipeStreamWriter(Stream stream)
        {
            this.DataStream = stream;
        }

        public void WriteMessage(string message)
        {
            byte[] byteBuffer = Encoding.UTF8.GetBytes(message + TerminatorByteString);
            DataStream.Write(byteBuffer, 0, byteBuffer.Length);
            DataStream.Flush();
        }
    }
}
