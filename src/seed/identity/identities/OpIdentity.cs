//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    
    using static Seed;

    public readonly struct OpIdentity : IIdentifedOp<OpIdentity>
    {            
        /// <summary>
        /// The operation identifier
        /// </summary>
        public string Identifier {get;}

        /// <summary>
        /// The empty identifier
        /// </summary>
        public static OpIdentity Empty => Set(string.Empty);

        /// <summary>
        /// Creates a moniker directly from source text
        /// </summary>
        /// <param name="src">The source text</param>
        [MethodImpl(Inline)]
        internal static OpIdentity Set(string src)
            => new OpIdentity(src);

        [MethodImpl(Inline)]
        public static implicit operator string(OpIdentity src)
            => src.Identifier;

        [MethodImpl(Inline)]
        public static bool operator==(OpIdentity a, OpIdentity b)
            => a.Equals(b);

        [MethodImpl(Inline)]
        public static bool operator!=(OpIdentity a, OpIdentity b)
            => !a.Equals(b);

        public static OpIdentity Define(string text, string name, string suffix, bool generic, bool imm, string[] components)
            => new OpIdentity(text, name, suffix, generic, imm, components);

        OpIdentity(string text, string name, string suffix, bool generic, bool imm, string[] components)
        {
            this.Identifier = text;
            this.Name = name; 
            this.Suffix = suffix;
            this.IsGeneric = generic;
            this.HasImm = imm;
            this.TextComponents = components;
        }
        
        [MethodImpl(Inline)]
        OpIdentity(string text)
        {
            this.Identifier = text;
            this.Name = string.Empty;
            this.Suffix = string.Empty;
            this.IsGeneric = false;
            this.HasImm = false;
            this.TextComponents = new string[]{};
        }

        /// <summary>
        /// The unqualified operation name
        /// </summary>
        public string Name {get;}

        /// <summary>
        /// The identifier suffix, if any
        /// </summary>
        public string Suffix {get;}
        
        /// <summary>
        /// Specifies whether the operation was reified from a generic definition 
        /// </summary>
        public bool IsGeneric {get;}
        
        /// <summary>
        /// Specifies whether the operation is specialized for an immediate value
        /// </summary>
        public bool HasImm {get;}

        /// <summary>
        /// The moniker parts, as determined by part delimiters
        /// </summary>
        public string[] TextComponents {get;}                        
 
        IIdentifedOp<OpIdentity> Identified => this;
         
        public bool IsEmpty
        {
            [MethodImpl(Inline)]   
            get => string.IsNullOrWhiteSpace(Identifier);
        }

        public override int GetHashCode()
            => Identified.HashCode;

        public override bool Equals(object obj)
            => Identified.Same(obj);

        public override string ToString()
            => Identified.Format();

        public string ToLegal()
        {
            var length = Identifier.Length;
            Span<char> dst = stackalloc char[length];
            for(var i=0; i< length; i++)
            {
                var c = Identifier[i];
                switch(c)
                {
                    case IDI.TypeArgsOpen:
                        dst[i] = IDI.TypeArgsOpenAlt;
                    break;
                    case IDI.TypeArgsClose:
                        dst[i] = IDI.TypeArgsCloseAlt;
                    break;
                    case IDI.ArgsOpen:
                        dst[i] = IDI.ArgsOpenAlt;
                    break;
                    case IDI.ArgsClose:
                        dst[i] = IDI.ArgsCloseAlt;
                    break;
                    case IDI.ArgSep:
                        dst[i] = IDI.ArgSepAlt;
                    break;
                    default:
                        dst[i] = c;
                    break;
                }
            }
            return new string(dst);
        }
    }
}