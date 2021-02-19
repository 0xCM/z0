//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Reflection;
    using System.Runtime.CompilerServices;
    using System.IO;

    using static Part;
    using static memory;

    partial struct Resources
    {
        [Op]
        public static bool document(ResDescriptor src, TextDocFormat format, out TextDoc dst)
        {
            var content = Resources.utf8(src);
            var result = TextDocs.parse(content,format);
            if(result)
            {
                dst = result.Value;
                return true;
            }
            else
            {
                dst = TextDoc.Empty;
                return false;
            }
        }
    }
}