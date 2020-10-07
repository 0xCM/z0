//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    using static Konst;
    using static z;

    using F = BinaryResourceField;

    partial struct Resources
    {
        [Op]
        public void render(in BinaryResourceRow src, StringBuilder dst)
        {
            delimit(dst, F.Offset, src.Offset.Format());
            delimit(dst, F.Address, src.Address);
            delimit(dst, F.Size, src.Size.Format());
            delimit(dst, F.Uri, src.Uri);
            delimit(dst, F.Data, src.Data.Format());
        }

       static void delimit<F>(StringBuilder sb, F field, object content, char delimiter = FieldDelimiter)
            where F : unmanaged, Enum
        {

            sb.Append(Z0.text.rspace(delimiter));
            sb.Append($"{content}".PadRight(Z0.text.width(field)));
        }
    }
}