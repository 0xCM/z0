//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{        
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    public static class OpUriOps
    {
        const string C = ":";

        const string S2 = "//";

        const string S1 = "/";

        const char Q = '?';

        const char H = '#';

       public static string Format(this OpUriScheme src)
            => src.ToString().ToLower();
        
        public static OpUriScheme ParseScheme(string text)        
            => Enum.TryParse(typeof(OpUriScheme), text, true, out var result) 
               ? (OpUriScheme)result 
               : OpUriScheme.None;

        public static string PathText(string scheme, AssemblyId catalog, string host)
            => $"{scheme}{C}{S2}{catalog.Format()}{S1}{host}";

        public static string QueryText(OpUriScheme scheme, AssemblyId catalog, string host, string group)
            => $"{scheme.Format()}{C}{S2}{catalog.Format()}{S1}{host}{Q}{group}";

        //scheme://assembly/apihost?opname#identifier
        public static string FullUriText(OpUriScheme scheme, AssemblyId catalog, string host, string group, OpIdentity opid)
            => $"{scheme.Format()}{C}{S2}{catalog.Format()}{S1}{host}?{group}#{opid.Identifier}";

        public static string GroupUriText(OpUriScheme scheme, ApiHostPath host, string group)
            => QueryText(scheme, host.Owner, host.Name, group); 

        public static ParseResult<OpUri> ParseUri(string text)
        {
            var parts = text.SplitClean(C);
            var msg = string.Empty;
            if(parts.Length != 2)
                msg = $"Splitting on {C} produces {parts.Length} pieces";
            else
            {
                var scheme = ParseScheme(parts[0]);
                var rest = parts[1].TakeAfter(S2);
                var pathText = rest.TakeBefore(Q);
                var path = ApiHostPath.Parse(pathText);
                if(!path.Succeeded)
                    msg = $"Failed to parse {pathText} as an api host path";
                else
                {
                    var id = OpIdentity.Define(rest.TakeAfter(H));
                    var group = rest.Between(Q,H);
                    var uri = OpUri.Define(scheme, path.Value, group, id);
                    return ParseResult.Success(uri);
                }                
            }
                        
            return ParseResult.Fail<OpUri>(msg);
        }
                
    }
}