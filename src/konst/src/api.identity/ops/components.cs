//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Reflection;
    using System.Collections.Generic;
    using System.Linq;

    using static Konst;

    partial struct ApiIdentity
    {
        [Op]
        public static IEnumerable<ApiIdentityPart> components(OpIdentity src)
        {
               var parts = ComponentText(src).ToArray();
               byte i = 0;
               for(;i<parts.Length; i++)
               {
                   var part = parts[i];
                   var partkind = ApiIdentityPartKind.None;

                   if(i == 0)
                        partkind = ApiIdentityPartKind.Name;
                    else
                    {
                        if(part.Contains(IDI.SegSep))
                            partkind = ApiIdentityPartKind.Segment;
                        else
                        {
                            if(i == 1 && part[0] == IDI.Generic && Char.IsDigit(part.TakeAfter(IDI.Generic).First()))
                                partkind = ApiIdentityPartKind.Numeric;
                            else if(Char.IsDigit(part.First()))
                                partkind = ApiIdentityPartKind.Numeric;
                        }
                    }
                    yield return (i, partkind, part);
               }

               var suffixes = SuffixText(src).ToArray();
               for(var j=0; j< suffixes.Length; j++, i++)
                    yield return (i, ApiIdentityPartKind.Suffix, suffixes[j]);
        }


        static IEnumerable<string> SuffixText(OpIdentity src)
        {
            if(src.Identifier.Contains(IDI.SuffixSep))
            {
                var suffixes = src.Identifier.TakeAfter(IDI.SuffixSep);
                if(!string.IsNullOrWhiteSpace(suffixes))
                {
                    var seperated = suffixes.Split(IDI.SuffixSep, StringSplitOptions.RemoveEmptyEntries);
                    foreach(var suffix in seperated)
                        yield return suffix;
                }
            }
        }


        static IEnumerable<string> ComponentText(OpIdentity src)
        {
            var parts = (src.Identifier.Contains(IDI.SuffixSep)
            ? src.Identifier.TakeBefore(IDI.SuffixSep)
            : src.Identifier).Split(IDI.PartSep, StringSplitOptions.RemoveEmptyEntries);
            {
                foreach(var part in parts)
                    yield return part;
            }
        }
    }
}