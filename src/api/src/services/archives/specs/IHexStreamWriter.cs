//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{    
    using System;

    public interface IHexStreamWriter : IFileStreamWriter
    {
        void Write(in OpUriBits src, int? uripad = null);

        void Write(OpUriBits[] src);
    }
}