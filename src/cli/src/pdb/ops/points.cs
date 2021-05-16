//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using Microsoft.DiaSymReader;

    using static Part;
    using static memory;

    partial struct PdbServices
    {
        public static Index<SequencePoint> points(ISymUnmanagedMethod src)
        {
            return src.GetSequencePoints().Array().Select(adapt);
        }
    }
}