//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    
    using static Konst;

    public readonly struct OpIdentity : IIdentifedOp<OpIdentity>
    {            
        /// <summary>
        /// The operation identifier
        /// </summary>
        public string Identifier {get;}

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
 
        /// <summary>
        /// The empty identifier
        /// </summary>
        public static OpIdentity Empty 
            => Set(string.Empty);

        /// <summary>
        /// Creates a moniker directly from source text
        /// </summary>
        /// <param name="src">The source text</param>
        [MethodImpl(Inline)]
        public static OpIdentity Set(string src)
            => new OpIdentity(src);

        [MethodImpl(Inline)]
        public static OpIdentity Define(string text, string name, string suffix, bool generic, bool imm, string[] components)
            => new OpIdentity(text, name, suffix, generic, imm, components);

        [MethodImpl(Inline)]
        public static implicit operator string(OpIdentity src)
            => src.Identifier;

        [MethodImpl(Inline)]
        public static bool operator==(OpIdentity a, OpIdentity b)
            => a.Equals(b);

        [MethodImpl(Inline)]
        public static bool operator!=(OpIdentity a, OpIdentity b)
            => !a.Equals(b);

        static string Safe(string src)
            => src.Replace(Chars.Lt, IDI.TypeArgsOpen).Replace(Chars.Gt, IDI.TypeArgsClose);

        OpIdentity(string text, string name, string suffix, bool generic, bool imm, string[] components)
        {
            Identifier = Safe(text);
            Name = name; 
            Suffix = suffix;
            IsGeneric = generic;
            HasImm = imm;
            TextComponents = components;
        }
        
        [MethodImpl(Inline)]
        OpIdentity(string text)
        {
            this.Identifier = Safe(text);
            this.Name = string.Empty;
            this.Suffix = string.Empty;
            this.IsGeneric = false;
            this.HasImm = false;
            this.TextComponents = new string[]{};
        }

        IIdentifedOp<OpIdentity> Identified 
            => this;
         
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
    }
}