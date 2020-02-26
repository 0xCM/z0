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
    public class MemberLocationRecord : IRecord<MemberLocationRecord>
    {    
        public static MemberLocationRecord Define(MemoryAddress location, ushort gap, OpIdentity member)
            => new MemberLocationRecord(location, gap, member);

        MemberLocationRecord(MemoryAddress location, ushort gap, OpIdentity member)
        {
            this.Location = location;
            this.Gap = gap;
            this.Member = member;
        }

        [ReportField(LocationPad)]
        public MemoryAddress Location {get;set;}

        [ReportField(GapPad)]
        public ushort Gap {get;set;}

        [ReportField]
        public OpIdentity Member {get;set;}

        const int LocationPad = 16;

        const int GapPad  = 8;

        public string DelimitedText(char delimiter)
        {
            var dst = text.factory.Builder();
            dst.AppendField(Location.Location.FormatAsmHex(), LocationPad);
            dst.DelimitField(Gap.ToString(), GapPad, delimiter);
            dst.DelimitField(Member, delimiter);
            return dst.ToString();
        }

        public IReadOnlyList<string> GetHeaders()
            => Record.ReportHeaders(GetType());        
    }
}