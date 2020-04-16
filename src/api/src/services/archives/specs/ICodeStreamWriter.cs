//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    /// <summary>
    /// Defines serivce contract for persting text-formatted x86 encoded assembly 
    /// </summary>
    public interface ICodeStreamWriter : IFileStreamWriter
    {
        void WriteCode(in AsmCode src, int? idpad = null);

        void Write(AsmCode[] src);

        void WriteCode(in EncodedHexLine src, int? idpad = null);
    }
}