//-----------------------------------------------------------------------------
// Derivative Work
// Copyright  : Microsft/.Net foundation
// Copyright  : (c) Chris Moore, 2020
// License    :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Image
{
    using System;
    using System.IO;

    partial struct Images
    {
        [Op]
        public static PEImage adapter(string path)
        {
            var reader = new StreamReader(path);
            return new PEImage(reader.BaseStream);
        }
    }
}