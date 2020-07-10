//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Linq;

    public class t_opuri : t_identity<t_opuri>
    {
        public void parse_uri_1()
        {
            var opid = OpIdentityParser.parse("vgeneric_g[8u](v512x8i~in)");
            var input = $"hex://fixed/Vector512?vgeneric#{opid}";
            var attempt = OpUriParser.Service.Parse(input);
            Claim.Require(attempt.Succeeded);
            var uri = attempt.Value;

            Claim.Eq(OpUriScheme.Hex, uri.Scheme);
            ClaimEquatable.Eq(ApiHostUri.Define(PartId.Fixed, "Vector512"), uri.Host);
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
