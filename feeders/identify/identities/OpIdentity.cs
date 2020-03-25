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
    
    using static Identify;

    public readonly struct OpIdentity : IIdentifedOp<OpIdentity>
    {            
        /// <summary>
        /// The operation identifier
        /// </summary>
        public string Identifier {get;}

        /// <summary>
        /// The empty identifier
        /// </summary>
        public static OpIdentity Empty => Identify.Op(string.Empty);

        /// <summary>
        /// Creates a moniker directly from source text
        /// </summary>
        /// <param name="src">The source text</param>
        public static OpIdentity Define(string src)
            => Identify.Op(src);

        [MethodImpl(Inline)]
        public static implicit operator string(OpIdentity src)
            => src.Identifier;

        [MethodImpl(Inline)]
        public static implicit operator OpIdentity(IdentityPart[] src)
            => Identify.Op(src);

        [MethodImpl(Inline)]
        public static bool operator==(OpIdentity a, OpIdentity b)
            => a.Equals(b);

        [MethodImpl(Inline)]
        public static bool operator!=(OpIdentity a, OpIdentity b)
            => !a.Equals(b);

        internal static OpIdentity Define(string text, string name, string suffix, bool generic, bool imm, string[] components)
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
        /// Defines an operation identifier of the form {opname}_{w}X{bitsize(k)}{u | i | f}{_suffix} to identify 
        /// an operation over a segmented type of bitwidth w over a primal kind k
        /// </summary>
        /// <param name="opname">The base operator name/operator classifier</param>
        /// <param name="w">The total bit-widht of the segmented type</param>
        /// <param name="k">The primal cell kind</param>
        /// <param name="generic">Whether a generic operation is identified</param>
        /// <param name="asm">Whether the moniker has an asm suffix</param>
        public static OpIdentity operation(string opname, TypeWidth w, NumericKind k, bool generic, string suffix = null)
            => Identify.Op(opname, w, k, generic,suffix);

        /// <summary>
        /// Defines an operand identifier of the form {opname}_N{u | i | f} that identifies an operation over a primal type of bit width N := bitsize[T]
        /// </summary>
        /// <param name="opname">The base operator name</param>
        /// <param name="t">A primal type representative</param>
        /// <typeparam name="T">The primal type</typeparam>
        [MethodImpl(Inline)]   
        public static OpIdentity sfunc<T>(string opname)
            => Identify.NumericOp(opname, typeof(T).NumericKind());

        /// <summary>
        /// Defines an operand identifier of the form {opname}_N{u | i | f} that identifies an operation over a primal type of bit width N := bitsize[T]
        /// </summary>
        /// <param name="opname">The base operator name</param>
        /// <param name="t">A primal type representative</param>
        /// <typeparam name="T">The primal type</typeparam>
        [MethodImpl(Inline)]   
        public static OpIdentity sfunc<T>(string opname, Vec128Kind<T> k)
            where T : unmanaged
                => Identify.Op(opname, (TypeWidth)k.Width, typeof(T).NumericKind(), true);

        /// <summary>
        /// Defines an operand identifier of the form {opname}_N{u | i | f} that identifies an operation over a primal type of bit width N := bitsize[T]
        /// </summary>
        /// <param name="opname">The base operator name</param>
        /// <param name="t">A primal type representative</param>
        /// <typeparam name="T">The primal type</typeparam>
        [MethodImpl(Inline)]   
        public static OpIdentity sfunc<T>(string opname, Vec256Kind<T> k)
            where T : unmanaged
                => Identify.Op(opname, (TypeWidth)k.Width, typeof(T).NumericKind(), true);
 
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

        public IEnumerable<IdentityPart> Parts
            => Identify.Parts(this);

        public const string AsmLocator = "-asm";

        public const string GenericLocator = "_g";              
    }
}