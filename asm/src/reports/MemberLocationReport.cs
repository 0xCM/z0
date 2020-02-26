//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{        
    using System;
    using System.Runtime.CompilerServices;
    using System.Collections.Generic;
    using System.Linq;
    using System.Reflection;

    using static zfunc;

    public class MemberLocationReport : IReport<MemberLocationRecord>
    {
        public static MemberLocationReport HostReport(ApiHost host)
        {
            var src = host.EncodedOps().ToArray();
            var records = new MemberLocationRecord[src.Length];
            var lastaddress = MemoryAddress.Zero;
            for(var i=0; i< src.Length; i++)
            {
                (var id, var address)  = src[i];
                var gap = lastaddress.NonZero ? address - lastaddress : MemoryAddress.Zero;
                records[i] = MemberLocationRecord.Define(address, (ushort)gap, id);
                lastaddress =  address;
            }

            return new MemberLocationReport(host, records);
        }

        public static MemberLocationReport Create(AssemblyId assemblyid, IEnumerable<MethodInfo> methods)
        {   
            var src = (from m in methods
                      let id = m.IsGenericMethodDefinition ? Identity.generic(m) : Identity.identify(m)
                      let address = MemoryAddress.Define(m.MethodHandle.GetFunctionPointer())
                      orderby address.Location
                      select (id,address)).ToArray();

            var records = new MemberLocationRecord[src.Length];
            var lastaddress = MemoryAddress.Zero;
            for(var i=0; i< src.Length; i++)
            {
                (var id, var address)  = src[i];
                var gap = lastaddress.NonZero ? address - lastaddress : MemoryAddress.Zero;
                records[i] = MemberLocationRecord.Define(address, (ushort)gap, id);
                lastaddress =  address;
            }

            return new MemberLocationReport(assemblyid, records);
        }

        MemberLocationReport(AssemblyId id, MemberLocationRecord[] records)
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

        public AssemblyId AssemblyId {get;}
         
        public Option<ApiHost> ApiHost {get;}

        public MemberLocationRecord[] Records {get;}

        public MemoryAddress FirstAddress
            => Records.First().Location;

        public MemoryAddress LastAddress
            => Records.Last().Location;        

        public bool IsEmpty
            => Records.Length == 0;

        public bool IsNonEmpty
            => Records.Length != 0;

        public Option<FilePath> Save()
        {
            var dst = ApiHost.MapValueOrElse(AsmEmissionPaths.Current.LocationPath,
                        () => AsmEmissionPaths.Current.LocationPath(AssemblyId));            
            //Records.Save(dst);
            return dst;
        }
    }
}