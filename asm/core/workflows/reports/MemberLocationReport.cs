//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{        
    using System;
    using System.Runtime.CompilerServices;
    using System.Collections.Generic;
    using System.Linq;
    using System.Reflection;

    using static Root;

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
    public class MemberLocationReport : IReport<MemberLocationRecord>
    {
        public static MemberLocationReport Create(PartId id, Assembly src)
            => MemberLocationReport.Create(id, src.GetTypes().DeclaredMethods().Static().NonGeneric().WithoutConversionOperators());

        public static MemberLocationReport Create(PartId assemblyid, IEnumerable<MethodInfo> methods)
        {   
            var src = (from m in methods
                      let id = m.IsGenericMethodDefinition ? Identity.generic(m) : Identity.identify(m)
                      let address = MemoryAddress.Define(m.MethodHandle.GetFunctionPointer())
                      orderby address.Location
                      select (id,address)).ToArray();

            // var records = new MemberLocationRecord[src.Length];
            // var lastaddress = MemoryAddress.Zero;
            // for(var i=0; i< src.Length; i++)
            // {
            //     (var id, var address)  = src[i];
            //     var gap = lastaddress.NonZero ? address - lastaddress : MemoryAddress.Zero;
            //     records[i] = MemberLocationRecord.Define(address, (ushort)gap, id);
            //     lastaddress =  address;
            // }
            var dst = new MemberLocationRecord[src.Length];
            return new MemberLocationReport(assemblyid, dst);
        }

        MemberLocationReport(PartId id, MemberLocationRecord[] records)
        {
            this.AssemblyId = id;
            this.ApiHost = none<ApiHost>();
            this.Records = records;
        }

        MemberLocationReport(ApiHost host, MemberLocationRecord[] records)
        {
            this.AssemblyId = host.Owner;
            this.ApiHost = host;
            this.Records = records;
        }

        public PartId AssemblyId {get;}
         
        public Option<ApiHost> ApiHost {get;}

        public MemberLocationRecord[] Records {get;}

        /// <summary>
        /// Intentionally not being saved because the report is useless
        /// </summary>
        public Option<FilePath> Save()
            => ApiHost.MapValueOrElse(
                    h => AsmEmissionPaths.The.LocationPath(h.Path),
                   () => AsmEmissionPaths.The.LocationPath(AssemblyId));            
    }
}