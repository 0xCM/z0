//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Linq;
    using System.Reflection;
    using System.Collections.Generic;
    
    using static RootShare;

    public readonly struct OpIdentity : IIdentity<OpIdentity>
    {            
        /// <summary>
        /// The moniker text
        /// </summary>
        public string Identifier {get;}

        /// <summary>
        /// The zero moniker
        /// </summary>
        public static OpIdentity Empty => new OpIdentity(string.Empty);

        /// <summary>
        /// Creates a moniker directly from source text
        /// </summary>
        /// <param name="src">The source text</param>
        public static OpIdentity Define(string src)
            => new OpIdentity(src);

        public static OpIdentity FromParts(params OpIdentityPart[] parts)
            => new OpIdentity(string.Join(PartSep, parts.Select(x =>x.PartText)));

        [MethodImpl(Inline)]
        public static implicit operator string(OpIdentity src)
            => src.Identifier;

        [MethodImpl(Inline)]
        public static implicit operator OpIdentity(OpIdentityPart[] src)
            => FromParts(src);

        [MethodImpl(Inline)]
        public static bool operator==(OpIdentity a, OpIdentity b)
            => a.Equals(b);

        [MethodImpl(Inline)]
        public static bool operator!=(OpIdentity a, OpIdentity b)
            => !a.Equals(b);

        [MethodImpl(Inline)]
        OpIdentity(string text)
            => this.Identifier = text ?? 0.ToString();

        /// <summary>
        /// The unqualified operation name
        /// </summary>
        public string Name
            => TakeBefore(Identifier, PartSep);

        /// <summary>
        /// The moniker's suffix, if any
        /// </summary>
        string Suffix
            => HasSuffix ? TakeAfter(Identifier,SuffixSep) : string.Empty;

        /// <summary>
        /// Indicates whether the moniker is emtpy
        /// </summary>
        public bool IsEmpty
        {
            
            [MethodImpl(Inline)]
            get => string.IsNullOrWhiteSpace(Identifier);
        }

        /// <summary>
        /// Specifies whether the operation was reified from a generic definition 
        /// </summary>
        public bool IsGeneric
            => TakeAfter(Identifier,PartSep)[0] == Generic;

        /// <summary>
        /// Specifies whether the operation is specialized for an immediate value
        /// </summary>
        public bool HasImm
            => Suffix.Contains(Imm);

        /// <summary>
        /// Specifies whether the moniker has a suffix
        /// </summary>
        public bool HasSuffix
            => Identifier.Contains(SuffixSep);

        /// <summary>
        /// The moniker parts, as determined by part delimiters
        /// </summary>
        public IEnumerable<string> TextComponents
            => Identifier.Split(PartSep, StringSplitOptions.RemoveEmptyEntries);

        public override string ToString()
            => Identifier;

        public override int GetHashCode()
            => Identifier.GetHashCode();

        [MethodImpl(Inline)]
        public bool Equals(OpIdentity src)
            => string.Equals(src.Identifier, Identifier, StringComparison.InvariantCultureIgnoreCase);

        public override bool Equals(object obj)
            => obj is OpIdentity m && Equals(m);

        public IEnumerable<string> SuffixText
        {
            get
            {
                if(Identifier.Contains(SuffixSep))
                {
                    var suffixes = TakeAfter(Identifier,SuffixSep);
                    if(!string.IsNullOrWhiteSpace(suffixes))
                    {
                        var seperated = suffixes.Split(SuffixSep, StringSplitOptions.RemoveEmptyEntries);
                        foreach(var suffix in seperated)
                            yield return suffix;
                    }
                }
            }
        }

        public IEnumerable<string> PartText
        {
            get
            {
                 var parts = (Identifier.Contains(SuffixSep) ? TakeBefore(Identifier, SuffixSep) : Identifier).Split(PartSep, StringSplitOptions.RemoveEmptyEntries);
                 {
                     foreach(var part in parts)
                         yield return part;                     
                 }
            }
        }

        public IEnumerable<OpIdentityPart> Parts
        {
            get
            {
               var parts = PartText.ToArray();
               byte i = 0;
               for(;i<parts.Length; i++)
               {                   
                   var part = parts[i];
                   var partkind = OpIdentityPartKind.None;

                   if(i == 0)
                        partkind = OpIdentityPartKind.Name;
                    else
                    {
                        if(part.Contains(TypeIdentity.SegSep))
                            partkind = OpIdentityPartKind.Segment;
                        else
                        {
                            partkind = OpIdentityPartKind.UserType;
                            if(i == 1 && part[0] == OpIdentity.Generic && Char.IsDigit(TakeAfter(part, OpIdentity.Generic).First()))
                                partkind = OpIdentityPartKind.Scalar;
                            else if(Char.IsDigit(part.First()))
                                partkind = OpIdentityPartKind.Scalar;                                
                        }
                    }
                    yield return (i, partkind, part);
               }

               var suffixes = SuffixText.ToArray();
               for(var j=0; j< suffixes.Length; j++, i++)
                    yield return (i, OpIdentityPartKind.Suffix, suffixes[j]);
            }
        }

        static string RightOfLast(string s, string match)
        {
            var idx = s.LastIndexOf(match);
            if (idx != -1)
                return s.Substring(idx + match.Length);
            else
                return string.Empty;
        }

        static string TakeBefore(string s, char c)
        {
            var found = -1;
            for(var i=0; i<s.Length; i++)
            {
                if(s[i] == c)
                {
                    found = i;
                    break;
                }
            }
            return found != -1 ? s.Substring(0, found) : s;
        }

        static string TakeAfter(string s, char c)
        {
            var found = -1;
            for(var i=0; i<s.Length; i++)
            {
                if(s[i] == c)
                {
                    found = i;
                    break;
                }
            }
            return found != -1 ? s.Substring(found + 1) : s;
        }

        public const char PartSep = '_';

        public const char SuffixSep = '-';

        public const char Generic = 'g';

        public const string Span = "span";

        public const string Asm = "asm";

        public const string Imm = "imm";

        public const string ImmLocator = "-imm";

        public const string AsmLocator = "-asm";

        public const string GenericLocator = "_g";
    }
}