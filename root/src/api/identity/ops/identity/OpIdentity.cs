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
    
    using static Root;
    using static IdentityShare;

    public readonly struct OpIdentity : IOpIdentity<OpIdentity>
    {            
        /// <summary>
        /// The operation identifier
        /// </summary>
        public string Identifier {get;}

        /// <summary>
        /// The empty identifier
        /// </summary>
        public static OpIdentity Empty => new OpIdentity(string.Empty);

        /// <summary>
        /// Creates a moniker directly from source text
        /// </summary>
        /// <param name="src">The source text</param>
        public static OpIdentity Define(string src)
            => new OpIdentity(src);

        public static OpIdentity FromParts(params IdentityPart[] parts)
            => new OpIdentity(string.Join(IDI.PartSep, parts.Select(x =>x.Identifier)));

        [MethodImpl(Inline)]
        public static implicit operator string(OpIdentity src)
            => src.Identifier;

        [MethodImpl(Inline)]
        public static implicit operator OpIdentity(IdentityPart[] src)
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
            => Identifier.TakeBefore(IDI.PartSep);

        /// <summary>
        /// The moniker's suffix, if any
        /// </summary>
        string Suffix
            => HasSuffix ? Identifier.TakeAfter(IDI.SuffixSep) : string.Empty;

        /// <summary>
        /// Indicates whether the moniker is emtpy
        /// </summary>
        public bool IsEmpty
        {            
            [MethodImpl(Inline)]
            get => string.IsNullOrWhiteSpace(Identifier);
        }

        /// <summary>
        /// Indicates whether the moniker is emtpy
        /// </summary>
        public bool IsNonEmpty
        {            
            [MethodImpl(Inline)]
            get => !IsEmpty;
        }

        /// <summary>
        /// Specifies whether the operation was reified from a generic definition 
        /// </summary>
        public bool IsGeneric
            => Identifier.TakeAfter(IDI.PartSep)[0] == IDI.Generic;

        /// <summary>
        /// Specifies whether the operation is specialized for an immediate value
        /// </summary>
        public bool HasImm
            => Suffix.Contains(IDI.Imm);

        /// <summary>
        /// Specifies whether the moniker has a suffix
        /// </summary>
        public bool HasSuffix
            => Identifier.Contains(IDI.SuffixSep);

        /// <summary>
        /// The moniker parts, as determined by part delimiters
        /// </summary>
        public IEnumerable<string> TextComponents
            => Identifier.Split(IDI.PartSep, StringSplitOptions.RemoveEmptyEntries);
            
        /// <summary>
        /// Returns the duplicate identities found in the source stream, if any; otherwise, returns an empty array
        /// </summary>
        /// <param name="src">The identities to search for duplicates</param>
        public static OpIdentity[] duplicates(IEnumerable<OpIdentity> src)
        {
            var index = new Dictionary<OpIdentity,int>();            
            var distinct = src.ToHashSet();
            if(distinct.Count != src.Count())
            {
                foreach(var id in src)
                {
                    if(index.TryGetValue(id, out var count ))
                        index[id] = ++count;
                    else
                        index[id] = 1;
                }
            }

            return (from kvp in index where kvp.Value > 1 select kvp.Key).ToArray();
        }

        /// <summary>
        /// Defines an operation identifier of the form {opname}_{w}X{bitsize(k)}{u | i | f}{_suffix} to identify 
        /// an operation over a segmented type of bitwidth w over a primal kind k
        /// </summary>
        /// <param name="opname">The base operator name/operator classifier</param>
        /// <param name="w">The total bit-widht of the segmented type</param>
        /// <param name="k">The primal cell kind</param>
        /// <param name="generic">Whether a generic operation is identified</param>
        /// <param name="asm">Whether the moniker has an asm suffix</param>
        public static OpIdentity operation(string opname, FixedWidth w, NumericKind k, bool generic, string suffix = null)
        {
            var g = generic ? $"{IDI.Generic}" : string.Empty;
            var suffixPart = string.IsNullOrWhiteSpace(suffix) ?  string.Empty : $"{IDI.SuffixSep}{suffix}";

            if(generic && k == NumericKind.None)
                return OpIdentity.Define(text.concat(opname, IDI.PartSep, IDI.Generic, suffixPart));            
            else if(w.IsSome())
                return OpIdentity.Define(text.concat(opname, IDI.PartSep, $"{g}{w.Format()}{IDI.SegSep}{k.Format()}", suffixPart));
            else
                return OpIdentity.Define(text.concat($"{opname}_{g}{k.Format()}{suffixPart}"));
        }
 
        /// <summary>
        /// Produces an identifier of the form {opname}_{g}{bitsize(kind)}{u | i | f}
        /// </summary>
        /// <param name="opname">The base operator name</param>
        /// <param name="k">The primal kind over which the identifier is deined</param>
        [MethodImpl(Inline)]   
        public static OpIdentity numeric(string opname, NumericKind k, bool generic)
            => OpIdentity.operation(opname, FixedWidth.None, k, generic);

        /// <summary>
        /// Produces an identifier of the form {opname}_{bitsize(kind)}{u | i | f}
        /// </summary>
        /// <param name="opname">The base operator name</param>
        /// <param name="k">The primal kind over which the identifier is deined</param>
        [MethodImpl(Inline)]   
        public static OpIdentity numeric(string opname, NumericKind k)
            => OpIdentity.operation(opname, FixedWidth.None, k, false);

        /// <summary>
        /// Produces an identifier of the form {opname}_g{kind}{u | i | f}
        /// </summary>
        /// <param name="opname">The base operator name</param>
        /// <param name="t">A primal type representative</param>
        /// <typeparam name="T">The primal type</typeparam>
        [MethodImpl(Inline)]   
        public static OpIdentity numeric<T>(string opname, NK<T> hk = default, bool generic = true)
            where T : unmanaged
                => OpIdentity.operation(opname, FixedWidth.None, typeof(T).NumericKind(), generic);       

        /// <summary>
        /// Defines an operand identifier of the form {opname}_N{u | i | f} that identifies an operation over a primal type of bit width N := bitsize[T]
        /// </summary>
        /// <param name="opname">The base operator name</param>
        /// <param name="t">A primal type representative</param>
        /// <typeparam name="T">The primal type</typeparam>
        [MethodImpl(Inline)]   
        public static OpIdentity contracted<T>(string opname, T t = default)
            => OpIdentity.numeric(opname,typeof(T).NumericKind());

        /// <summary>
        /// Produces an identifier of the form {opname}_{w}{typesig(nk)}
        /// </summary>
        /// <param name="opname">The base operator name</param>
        /// <param name="k">The primal kind over which the identifier is deined</param>
        [MethodImpl(Inline)]   
        public static OpIdentity fixedop(string opname, FixedWidth w, NumericKind nk)
            => OpIdentity.operation(opname,w,nk,false);

        [MethodImpl(Inline)]
        public bool Equals(OpIdentity src)
            => IdentityShare.equals(this, src);

        [MethodImpl(Inline)]
        public int CompareTo(OpIdentity other)
            => compare(this, other);
 
        public override int GetHashCode()
            => hash(this);

        public override bool Equals(object obj)
            => equals(this, obj);

        public override string ToString()
            => Identifier;

        public IEnumerable<string> SuffixText
        {
            get
            {
                if(Identifier.Contains(IDI.SuffixSep))
                {
                    var suffixes = Identifier.TakeAfter(IDI.SuffixSep);
                    if(!string.IsNullOrWhiteSpace(suffixes))
                    {
                        var seperated = suffixes.Split(IDI.SuffixSep, StringSplitOptions.RemoveEmptyEntries);
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
                 var parts = (Identifier.Contains(IDI.SuffixSep) 
                    ? Identifier.TakeBefore(IDI.SuffixSep) 
                    : Identifier).Split(IDI.PartSep, StringSplitOptions.RemoveEmptyEntries);
                 {
                     foreach(var part in parts)
                         yield return part;                     
                 }
            }
        }

        public IEnumerable<IdentityPart> Parts
        {
            get
            {
               var parts = PartText.ToArray();
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

               var suffixes = SuffixText.ToArray();
               for(var j=0; j< suffixes.Length; j++, i++)
                    yield return (i, IdentityPartKind.Suffix, suffixes[j]);
            }
        }


        public const string AsmLocator = "-asm";

        public const string GenericLocator = "_g";

        /// <summary>
        /// Defines an 8-bit immediate suffix predicated on an immediate value
        /// </summary>
        /// <param name="immval">The source value</param>
        static string imm8(byte immval)            
            => $"{IDI.SuffixSep}{IDI.Imm}{immval}";

        /// <summary>
        /// Extracts an 8-bit immediate value from an identity if it contains an immediate suffix; otherwise, returns none
        /// </summary>
        /// <param name="src">The source identity</param>
        public Option<byte> Imm8()            
        {
            if(HasImm && byte.TryParse(Identifier.RightOfLast(IDI.Imm), out var immval))
                return immval;
            else
                return none<byte>();
        }

        /// <summary>        
        /// Clears an attached immediate suffix, if any
        /// </summary>
        public OpIdentity WithoutImm8()
        {
            var perhaps = Imm8();
            if(!perhaps)   
                return this;
            return OpIdentity.Define(Identifier.Remove(imm8(perhaps.Value)));
        }

        /// <summary>        
        /// Attaches an immediate suffix to an identity, removing an existing immediate suffix if necessary
        /// </summary>
        /// <param name="src">The source identity</param>
        /// <param name="immval">The immediate value to attach</param>
        public OpIdentity WithImm8(byte immval)
              => OpIdentity.Define(text.concat(WithoutImm8().Identifier, imm8(immval)));
              
        public Func<string, OpIdentity> Factory => Define;
    }
}