//-----------------------------------------------------------------------------
// Taken from https://github.com/0xd4d/JitDasm/tree/master/JitDasm;
// License: See the accompanying license file
//-----------------------------------------------------------------------------
namespace Z0
{        
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using System.Text.RegularExpressions;

    static partial class Symbolizer
    {

        public sealed class RegexFilter 
        {
            readonly List<Regex> regexes = new List<Regex>();
            public bool HasFilters => regexes.Count != 0;
            public bool IsMatch(string value) 
            {
                foreach (var regex in regexes) 
                {
                    if (regex.IsMatch(value))
                        return true;
                }
                return false;
            }

            public void Add(string pattern) => regexes.Add(CreateRegex(pattern));
            
            static Regex CreateRegex(string wildcardString) {
                const RegexOptions flags = RegexOptions.CultureInvariant | RegexOptions.IgnoreCase | RegexOptions.Singleline;
                return new Regex("^" + Regex.Escape(wildcardString).Replace(@"\*", ".*").Replace(@"\?", ".") + "$", flags);
            }
        }


        public sealed class TokensFilter 
        {
            readonly List<(uint lo, uint hi)> tokens = new List<(uint lo, uint hi)>();
            public bool HasTokens => tokens.Count != 0;
            public void Add(uint lo, uint hi) => tokens.Add((lo, hi));
            public bool IsMatch(uint token) {
                foreach (var (lo, hi) in tokens) {
                    if (lo <= token && token <= hi)
                        return true;
                }
                return false;
            }
        }

        public sealed class MemberFilter 
        {
            public readonly RegexFilter NameFilter = new RegexFilter();
            public readonly TokensFilter TokensFilter = new TokensFilter();
            public readonly RegexFilter ExcludeNameFilter = new RegexFilter();
            public readonly TokensFilter ExcludeTokensFilter = new TokensFilter();

            public bool IsMatch(string name, uint token) 
            {
                if (TokensFilter.HasTokens || NameFilter.HasFilters) {
                    bool match =
                        (TokensFilter.HasTokens && TokensFilter.IsMatch(token)) ||
                        (NameFilter.HasFilters && NameFilter.IsMatch(name));
                    if (!match)
                        return false;
                }

                if (ExcludeTokensFilter.HasTokens || ExcludeNameFilter.HasFilters) {
                    bool match =
                        (ExcludeTokensFilter.HasTokens && ExcludeTokensFilter.IsMatch(token)) ||
                        (ExcludeNameFilter.HasFilters && ExcludeNameFilter.IsMatch(name));
                    if (match)
                        return false;
                }

                return true;
            }
        }



    }

}