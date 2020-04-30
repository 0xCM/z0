//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Linq;

    using static Seed;
    using static Memories;

    public class t_opuri : t_identity<t_opuri>
    {
        public void parse_uri_1()
        {
            var opid = Identify.Op("vgeneric_g[8u](v512x8i~in)");
            var input = $"hex://fixed/Vector512?vgeneric#{opid}";
            var attempt = OpUri.Parse(input);
            Claim.require(attempt.Succeeded);
            var uri = attempt.Value;

            Claim.eq(OpUriScheme.Hex, uri.Scheme);
            Equatable.eq(ApiHostUri.Define(PartId.Fixed, "Vector512"), uri.HostPath);
            Claim.eq("vgeneric", uri.GroupName);
            Claim.eq(opid, uri.OpId);
            Claim.eq(true, opid.IsGeneric);
            Claim.eq("vgeneric", opid.Name);
            var parts  = Identify.Parts(opid).ToArray();
            foreach(var p in parts)
                Trace(p.PartKind, p);                            
        }
    }
}
