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
        void WriteCode(in LocatedBits src, int? idpad = null);

        void Write(LocatedBits[] src);

        void WriteCode(in EncodedHexLine src, int? idpad = null);
    }
}