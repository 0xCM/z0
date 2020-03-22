//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Linq;

    using static Root;

    public class t_opuri : UnitTest<t_opuri>
    {
        public void parse_uri_1()
        {
            var opid = OpIdentity.Define("vgeneric_g[8u](v512x8i~in)");
            var input = $"hex://fixed/Vector512?vgeneric#{opid}";
            var attempt = OpUri.Parse(input);
            Claim.yea(attempt.Succeeded);
            var uri = attempt.Value;

            Claim.eq(OpUriScheme.Hex, uri.Scheme);
            Claim.eq(ApiHostUri.Define(AssemblyId.Fixed, "Vector512"), uri.HostPath);
            Claim.eq("vgeneric", uri.GroupName);
            Claim.eq(opid, uri.OpId);
            Claim.eq(true, opid.IsGeneric);
            Claim.eq("vgeneric", opid.Name);
            var parts  = opid.Parts.ToArray();
            foreach(var p in parts)
                trace(p.PartKind, p);                            
        }
    }
}
