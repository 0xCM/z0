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

    public readonly struct Moniker
    {
        /// <summary>
        /// The moniker text
        /// </summary>
        public readonly string Text;

        /// <summary>
        /// The zero moniker
        /// </summary>
        public static Moniker Empty => new Moniker(string.Empty);

        public static implicit operator string(Moniker src)
            => src.Text;

        public Moniker(string text)
            => this.Text = string.IsNullOrWhiteSpace(text) ? "00000" : text;
        
        /// <summary>
        /// The width of the primal type over wich the identifier is constructed
        /// </summary>
        public int PrimalWidth
            => ParsePrimalWidth();

        /// <summary>
        /// The primal kind over which the the identifier is constructed
        /// </summary>
        public PrimalKind PrimalKind
            => ParsePrimalKind();

        /// <summary>
        /// The total width of the type if segmented, otherwise 0
        /// </summary>
        public FixedWidth SegmentedWidth
            => ParseSegmentedWidth();

        /// <summary>
        /// The unqualified operation name
        /// </summary>
        public string Name
            => TakeBefore(Text, PartSep);

        /// <summary>
        /// The moniker's suffix, if any
        /// </summary>
        public string Suffix
            => HasSuffix ? TakeAfter(Text,SuffixSep) : string.Empty;

        /// <summary>
        /// Indicates whether the moniker is emtpy
        /// </summary>
        public bool IsEmpty
            => string.IsNullOrWhiteSpace(Text);

        /// <summary>
        /// Indicates whether the operation is defined over a blocked or vectorized type
        /// </summary>
        public bool IsSegmented
            => Metrics.Contains(SegSep);

        /// <summary>
        /// Indicates whether the operation is defined over a vectorized type
        /// </summary>
        public bool IsVectorized
            => IsEmpty ? false : Text.First() == VectorIndicator;

        /// <summary>
        /// Indicates whether the operation is defined over a blocked type
        /// </summary>
        public bool IsBlocked
            => !IsVectorized && IsSegmented;

        /// <summary>
        /// Indicates whether the operation is defined over an unsigned integral domain
        /// </summary>
        public bool IsUnsignedInt
            => NumericIndicator == UIntIndicator;

        /// <summary>
        /// Indicates whether the operation is defined over a signed integral domain
        /// </summary>
        public bool IsSignedInt
            => NumericIndicator == SIntIndicator;

        /// <summary>
        /// Indicates whether the operation is defined over a floating-point domain
        /// </summary>
        public bool IsFloat
            => NumericIndicator == FloatIndicator; 

        /// <summary>
        /// Specifies whether the operation was reified from a generic definition 
        /// </summary>
        public bool IsGeneric
            => TakeAfter(Text,PartSep)[0] == GenericIndicator;

        /// <summary>
        /// Specifies whether the operation was reified from assembly language
        /// </summary>
        public bool IsAsm
            => Suffix.Contains(AsmIndicator);

        /// <summary>
        /// Specifies whether the operation is specialized for an immediate value
        /// </summary>
        public bool HasImm
            => Suffix.Contains(ImmIndicator);

        /// <summary>
        /// Specifies the immediate value attached to the moniker, if any
        /// </summary>
        public byte Imm
            => ParseImm();

        /// <summary>
        /// Specifies whether the moniker has a suffix
        /// </summary>
        public bool HasSuffix
            => Text.Contains(SuffixSep);

        /// <summary>
        /// Specifies the suffixes supported by the moniker, if any
        /// </summary>
        public string[] Suffixes
            => HasSuffix ? Suffix.Split(SuffixSep) : new string[]{};


        public override string ToString()
            => Text;

        string Metrics
            => IsGeneric ? RightOfLast(Text, GenericLocator) : TakeAfter(Text,PartSep);

        char NumericIndicator
        {
            get => (HasSuffix ? TakeBefore(Text,SuffixSep) : Text).Last();
        }

        PrimalKind ParsePrimalKind()
            => PrimalWidth switch{
                8 => IsUnsignedInt ? PrimalKind.U8 : PrimalKind.I8,
                16 => IsUnsignedInt ? PrimalKind.U16 : PrimalKind.I16,
                32 => IsFloat ? PrimalKind.F32 : (IsUnsignedInt ? PrimalKind.U32 : PrimalKind.I32),
                64 => IsFloat ? PrimalKind.F64 : (IsUnsignedInt ? PrimalKind.U64 : PrimalKind.I64),
                _ => PrimalKind.None
            };

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

        byte ParseImm()
        {
            if(HasImm)
            {
                var immtext = RightOfLast(Text,ImmIndicator);
                if(byte.TryParse(immtext, out var imm))
                    return imm;
            }
            return 0;
        }                

        int ParsePrimalWidth()
        {
            var s0 = (IsSegmented ? Metrics.Split(SegSep)[1] : Metrics);
            var s1 = HasSuffix ? TakeBefore(s0,SuffixSep) : s0;
            if(s1.Length > 0)
            {
                var s2 = s1.Substring(0, s1.Length - 1);
                if(int.TryParse(s2, out var n))
                    return n;
            }
            
            return 0;
        }

        FixedWidth ParseSegmentedWidth()
        {
            if(IsSegmented &&int.TryParse(Metrics.Split(SegSep)[0], out var n))
                return (FixedWidth)n;
            else 
                return FixedWidth.None;
        }

        int ParseTotalWidth()
        {
            var metrics = Metrics.Split(SegSep);
            var n = 0;
            if(IsSegmented) 
                int.TryParse(metrics[0], out n);
            else
                int.TryParse(metrics[1].Substring(0, metrics[1].Length - 1), out n);
            return n;
        }

        public const char SegSep = 'x';

        public const char PartSep = '_';

        public const char SuffixSep = '-';

        public const char UIntIndicator = 'u';

        public const char SIntIndicator = 'i';

        public const char FloatIndicator = 'f';

        public const char GenericIndicator = 'g';

        public const char VectorIndicator = 'v';

        public const char BlockIndicator = 'b';

        public const char NatIndicator = 'n';

        public const string AsmIndicator = "asm";

        public const string ImmIndicator = "imm";

        public const string ImmLocator = "-imm";

        public const string AsmLocator = "-asm";

        public const string GenericBlockLocator = "_gb";

        public const string GenericLocator = "_g";


    }
}