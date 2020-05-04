//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    public interface IUriCodeWriter : IFileStreamWriter<UriCode>
    {
        /// <summary>
        /// Writes uri code with a specified uri padding
        /// </summary>
        /// <param name="src">The source code</param>
        /// <param name="idpad">The uri pad amount</param>
        void Write(UriCode src, int idpad);
    }
}