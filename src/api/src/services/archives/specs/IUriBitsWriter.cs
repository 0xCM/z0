//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{    
    using System;

    public interface IUriBitsWriter : IFileStreamWriter
    {
        void Write(in UriBits src, int? uripad = null);

        void Write(UriBits[] src);
    }
}