//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    /// <summary>
    /// Defines serivce contract for persting text-formatted x86 encoded assembly 
    /// </summary>
    public interface IBitArchiveWriter : IFileStreamWriter
    {
        void WriteHex(in OperationBits src, int? idpad = null);

        void WriteHex(OperationBits[] src);

        void WriteHex(in EncodedHexLine src, int? idpad = null);
    }
}