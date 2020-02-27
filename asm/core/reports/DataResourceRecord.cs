//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    using static zfunc;

    /// <summary>
    /// Describes an assembly code emission
    /// </summary>
    public class DataResourceRecord : IRecord<DataResourceRecord>
    {    
        public static DataResourceRecord Create(ushort offset, ulong location, int length, string id)
            => new DataResourceRecord(offset, location, length, id);

        DataResourceRecord(ushort Offset, ulong location, int length, string id)
        {
            this.Offset =Offset;
            this.Location = location;
            this.Length = length;
            this.Id = id;
        }

        [ReportField(OffsetPad)]
        public ushort Offset {get; set;}

        [ReportField(LocationPad)]
        public ulong Location {get; set;}

        [ReportField(LengthPad)]
        public int Length {get; set;}

        [ReportField]
        public string Id {get; set;}

        const int OffsetPad = 8;
        
        const int LocationPad = 16;

        const int LengthPad = 10;

        public string DelimitedText(char delimiter)
        {
            var dst = text.factory.Builder();
            dst.AppendField(Offset.FormatAsmHex(), OffsetPad);
            dst.DelimitField(Location.FormatAsmHex(),16, delimiter); 
            dst.DelimitField(Length.FormatAsmHex(4),LengthPad,delimiter); 
            dst.DelimitField(Id,delimiter);                        
            return dst.ToString();
        }

        public IReadOnlyList<string> GetHeaders()
            => Reports.ReportHeaders(GetType());
    }
}
