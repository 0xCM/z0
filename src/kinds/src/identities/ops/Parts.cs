//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Reflection;
    using System.Linq;
    using System.Collections.Generic;

    using static Seed;
    using static UriDelimiters;

    partial class Identify
    {
        public static Option<IdentityPart> Part(OpIdentity src, int partidx)
        {
            var parts = Parts(src).ToArray();
            if(partidx <= parts.Length - 1)
                return parts[partidx];
            else
                return Option.none<IdentityPart>();
        }

        public static IEnumerable<IdentityPart> Parts(OpIdentity src)
        {
               var parts = Identify.ComponentText(src).ToArray();
               byte i = 0;
               for(;i<parts.Length; i++)
               {                   
                   var part = parts[i];
                   var partkind = IdentityPartKind.None;

                   if(i == 0)
                        partkind = IdentityPartKind.Name;
                    else
                    {
                        if(part.Contains(IDI.SegSep))
                            partkind = IdentityPartKind.Segment;
                        else
                        {
                            if(i == 1 && part[0] == IDI.Generic && Char.IsDigit(part.TakeAfter(IDI.Generic).First()))
                                partkind = IdentityPartKind.Numeric;
                            else if(Char.IsDigit(part.First()))
                                partkind = IdentityPartKind.Numeric;                                
                        }
                    }
                    yield return (i, partkind, part);
               }

               var suffixes = Identify.SuffixText(src).ToArray();
               for(var j=0; j< suffixes.Length; j++, i++)
                    yield return (i, IdentityPartKind.Suffix, suffixes[j]);
        }
    
        internal static IEnumerable<string> SuffixText(OpIdentity src)
        {
            if(src.IdentityText.Contains(IDI.SuffixSep))
            {
                var suffixes = src.IdentityText.TakeAfter(IDI.SuffixSep);
                if(!string.IsNullOrWhiteSpace(suffixes))
                {
                    var seperated = suffixes.Split(IDI.SuffixSep, StringSplitOptions.RemoveEmptyEntries);
                    foreach(var suffix in seperated)
                        yield return suffix;
                }
            }
        }

        internal static IEnumerable<string> ComponentText(OpIdentity src)
        {
            var parts = (src.IdentityText.Contains(IDI.SuffixSep) 
            ? src.IdentityText.TakeBefore(IDI.SuffixSep) 
            : src.IdentityText).Split(IDI.PartSep, StringSplitOptions.RemoveEmptyEntries);
            {
                foreach(var part in parts)
                    yield return part;                     
            }
        }
    }
}