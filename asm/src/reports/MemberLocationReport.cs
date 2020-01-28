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
    using System.IO;

    using static zfunc;
 
    public class MemberLocationReport
    {
        public static MemberLocationReport Create(IEnumerable<MethodInfo> methods)
        {   
            var identity = OpIdentity.Provider;
            var src = (from m in methods
                      let id =  (m.IsGenericMethodDefinition ? identity.GenericIdentity(m) : identity.DefineIdentity(m)).ValueOrDefault(Moniker.Parse(m.Name))
                      let address = MemoryAddress.Define(m.MethodHandle.GetFunctionPointer())
                      orderby address.Origin
                      select (id,address)).ToArray();

            var records = new MemberLocationRecord[src.Length];
            var lastaddress = 0ul;
            for(var i=0; i< src.Length; i++)
            {
                (var id, var address)  = src[i];
                var gap = lastaddress != 0 ? address - lastaddress : 0ul;
                records[i] = MemberLocationRecord.Define(address, (ushort)gap, id);
                lastaddress =  address;
            }
    

            return new MemberLocationReport(records);
        }

        MemberLocationReport(MemberLocationRecord[] records)
        {
            this.Records = records;
        }

        IReadOnlyList<MemberLocationRecord> Records {get;}

        public char Delimiter {get;}
            = AsciSym.Comma;

        public Option<FilePath> Save(FilePath dst)
        {
            if(Records.Count == 0)
                return dst;
            
            try
            {
                using var writer = new StreamWriter(dst.FullPath, false);
                writer.WriteLine(Record.ReportHeaders<MemberLocationRecord>().Concat(Delimiter));
                foreach(var record in Records)
                    writer.WriteLine(record.DelimitedText(Delimiter));
                return dst;
            }
            catch(Exception e)
            {
                errout(e);
                return default;
            }
        }

    }

}