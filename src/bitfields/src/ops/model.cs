//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;    
    using static Memories;

    partial class BitFields
    {
        [Op]
        public static BitFieldModel model(string name, string[] names, byte[] widths)
        {            
            Demands.insist(names.Length, widths.Length);
            var fieldCount = (byte)names.Length;
            var fieldWidths = widths;
            var fieldNames = asci.alloc(n16,fieldCount);            

            ArraySpan<byte> fieldPositions = new byte[fieldCount];

            byte width = 0;            
            for(var i=0; i< fieldCount; i++)
            {
                asci.encode(names[i], out fieldNames[i]);
                fieldPositions[i] = width;
                width += fieldWidths[i];                
            }
            return new BitFieldModel(asci.encode(n16,name), fieldCount, width, fieldNames, fieldWidths, fieldPositions);
        }
    }
}