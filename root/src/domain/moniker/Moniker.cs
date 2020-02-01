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

    public readonly struct Moniker : IEquatable<Moniker>
    {            
        /// <summary>
        /// The moniker text
        /// </summary>
        public readonly string Text;

        /// <summary>
        /// The zero moniker
        /// </summary>
        public static Moniker Empty => new Moniker(string.Empty);

        /// <summary>
        /// Creates a moniker directly from source text
        /// </summary>
        /// <param name="src">The source text</param>
        public static Moniker Parse(string src)
            => new Moniker(src);

        public static implicit operator string(Moniker src)
            => src.Text;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator==(Moniker a, Moniker b)
            => a.Equals(b);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator!=(Moniker a, Moniker b)
            => !a.Equals(b);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        Moniker(string text)
            => this.Text = text ?? 0.ToString();

        /// <summary>
        /// The unqualified operation name
        /// </summary>
        public string Name
            => TakeBefore(Text, PartSep);

        /// <summary>
        /// The moniker's suffix, if any
        /// </summary>
        string Suffix
            => HasSuffix ? TakeAfter(Text,SuffixSep) : string.Empty;

        /// <summary>
        /// Indicates whether the moniker is emtpy
        /// </summary>
        public bool IsEmpty
            => string.IsNullOrWhiteSpace(Text);

        /// <summary>
        /// Specifies whether the operation was reified from a generic definition 
        /// </summary>
        public bool IsGeneric
            => TakeAfter(Text,PartSep)[0] == Generic;

        /// <summary>
        /// Specifies whether the operation is specialized for an immediate value
        /// </summary>
        public bool HasImm
            => Suffix.Contains(Imm);

        /// <summary>
        /// Specifies whether the moniker has a suffix
        /// </summary>
        public bool HasSuffix
            => Text.Contains(SuffixSep);

        /// <summary>
        /// The moniker parts, as determined by part delimiters
        /// </summary>
        public IEnumerable<string> TextComponents
            => Text.Split(PartSep, StringSplitOptions.RemoveEmptyEntries);

        public override string ToString()
            => Text;

        public override int GetHashCode()
            => Text.GetHashCode();

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool Equals(Moniker src)
            => String.Compare(Text, src.Text, true) == 0;

        public override bool Equals(object obj)
            => obj is Moniker m && Equals(m);


        public IEnumerable<string> SuffixText
        {
            get
            {
                if(Text.Contains(SuffixSep))
                {
                    var suffixes = TakeAfter(Text,SuffixSep);
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
                 var parts = (Text.Contains(SuffixSep) ? TakeBefore(Text, SuffixSep) : Text).Split(PartSep, StringSplitOptions.RemoveEmptyEntries);
                 {
                     foreach(var part in parts)
                         yield return part;                     
                 }
            }

        }

        public IEnumerable<MonikerPart> Parts
        {
            get
            {
               var parts = PartText.ToArray();
               byte i = 0;
               for(;i<parts.Length; i++)
               {                   
                   var part = parts[i];
                   var partkind = MonikerPartKind.None;

                   if(i == 0)
                        partkind = MonikerPartKind.Name;
                    else
                    {
                        if(part.Contains(SegSep))
                            partkind = MonikerPartKind.Segment;
                        else
                        {
                            partkind = MonikerPartKind.UserType;
                            if(i == 1 && part[0] == Moniker.Generic && Char.IsDigit(TakeAfter(part, Moniker.Generic).First()))
                                partkind = MonikerPartKind.Scalar;
                            else if(Char.IsDigit(part.First()))
                                partkind = MonikerPartKind.Scalar;                                
                        }
                    }
                    yield return (i, partkind, part);
               }

               var suffixes = SuffixText.ToArray();
               for(var j=0; j< suffixes.Length; j++, i++)
                    yield return (i, MonikerPartKind.Suffix, suffixes[j]);
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

        public const char SegSep = 'x';

        public const char PartSep = '_';

        public const char SuffixSep = '-';

        public const char Generic = 'g';

        public const char Vector = 'v';

        public const char Block = 'b';

        public const char Nat = 'n';

        public const string Span = "span";

        public const string Asm = "asm";

        public const string Imm = "imm";

        public const string Pointer = "ptr";

        public const string ImmLocator = "-imm";

        public const string AsmLocator = "-asm";

        public const string GenericBlockLocator = "_gb";

        public const string GenericVectorLocator = "_gv";

        public const string GenericLocator = "_g";
    }
}