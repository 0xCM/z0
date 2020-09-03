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

    partial class Identify
    {
        /// <summary>
        /// Extracts an index-identified segmented identity part from an operation identity
        /// </summary>
        /// <param name="src">The source identity</param>
        /// <param name="index">The 0-based part index</param>
        public static Option<SegmentedIdentity> segmented(OpIdentity src, int index)
            => from p in Part(src, index)
                from s in identify(p)
                select s;

        public static Option<SegmentedIdentity> identify(IdentityPart part)
        {
            if(part.IsSegment && TryParse(part.Identifier, out var seg))
                return seg;
            else
                return z.none<SegmentedIdentity>();
        }

        public static bool TryParse(string src, out SegmentedIdentity dst)
        {
            dst = default;
            if(src.Length == 0)
                return false;

            var indicator = TypeIndicator.Define(src[0]);
            var start = 0;
            for(var i=0; i<src.Length; i++)
            {
                if(char.IsDigit(src[i]))
                {
                    start = i;
                    break;
                }
            }
            
            var parts = text.split(text.slice(src,start), IDI.SegSep);
            if(parts.Length == 2)
            {
                var part0 = parts[0];
                var part1 = parts[1];

                var sText = part0[0] 
                    == IDI.Generic 
                    ? text.slice(part0, 1, part0.Length - 1) 
                    : part0;

                if(uint.TryParse(sText, out var n))
                {
                    if(Enum.IsDefined(typeof(FixedWidth),n))
                    {
                        var bText = text.slice(part1,0, part1.Length - 1);                        
                        if(uint.TryParse(bText, out var by))
                        {                                
                            if(Enum.IsDefined(typeof(FixedWidth), by))
                            {
                                dst = SegmentedIdentity.identify(indicator, (FixedWidth)n, ((NumericWidth)by).ToNumericKind((NumericIndicator)part1.Last()));
                                return true;
                            }
                        }
                    }                       
                }
            }
            return false;
        }

        public static Option<IdentityPart> Part(OpIdentity src, int index)
        {
            var parts = Parts(src).ToArray();
            if(index <= parts.Length - 1)
                return parts[index];
            else
                return z.none<IdentityPart>();
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

        internal static IEnumerable<string> ComponentText(OpIdentity src)
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