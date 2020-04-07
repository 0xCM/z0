//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Linq;
    using System.Collections.Generic;
    using System.Reflection;

    using static Seed;
        
    partial class Identify
    {
        public static Option<IdentityPart> part(OpIdentity src, int partidx)
        {
            var parts = Identify.parts(src).ToArray();
            if(partidx <= parts.Length - 1)
                return parts[partidx];
            else
                return Option.none<IdentityPart>();
        }

        public static IEnumerable<IdentityPart> parts(OpIdentity src)
        {
               var parts = PartText(src).ToArray();
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

               var suffixes = SuffixText(src).ToArray();
               for(var j=0; j< suffixes.Length; j++, i++)
                    yield return (i, IdentityPartKind.Suffix, suffixes[j]);
        }
    }
}