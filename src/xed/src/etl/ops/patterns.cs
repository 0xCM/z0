//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;
    using static XedSourceMarkers;

    partial struct XedWfOps
    {
        public static string pattern(XedInstructionDoc src, string name)
        {
            for(var i=0; i<src.RowCount; i++)
            {
                var row = src.Data[i];
                var rowText = row.Text;
                if(text.nonempty(rowText) && rowText.StartsWith(name))
                {
                    var value = rowText.RightOfFirst(PROP_DELIMITER);
                    if(text.nonempty(value))
                        return value.Trim();
                }
            }
            return EmptyString;
        }

        public static XedPattern[] patterns(in XedInstructionDoc src)
            => map(src, out var _);
    }
}