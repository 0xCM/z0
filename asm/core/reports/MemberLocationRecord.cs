//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    using F = MemberLocationField;
    using R = MemberLocationRecord;

    enum MemberLocationField : ulong
    {
        Location = 16,

        Gap = 8,

        Member = 1,

    }

    /// <summary>
    /// Describes an assembly code emission
    /// </summary>
    public class MemberLocationRecord :  IRecord<F, R>
    {    
        public static MemberLocationRecord Define(MemoryAddress location, ushort gap, OpIdentity member)
            => new MemberLocationRecord(location, gap, member);

        MemberLocationRecord(MemoryAddress location, ushort gap, OpIdentity member)
        {
            this.Location = location;
            this.Gap = gap;
            this.Member = member;
        }

        [ReportField(F.Location)]
        public MemoryAddress Location {get;set;}

        [ReportField(F.Gap)]
        public ushort Gap {get;set;}

        [ReportField(F.Member)]
        public OpIdentity Member {get;set;}

        public string DelimitedText(char delimiter)
        {
            var dst = text.factory.Builder();
            dst.AppendField(Location, 16);
            dst.DelimitField(Gap, 8, delimiter);
            dst.DelimitField(Member, delimiter);
            return dst.ToString();
        }
    }
}