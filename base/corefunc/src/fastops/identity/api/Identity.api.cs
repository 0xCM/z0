//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Reflection;
    using System.Runtime.CompilerServices;
    using System.Linq;
    using System.Collections.Generic;

    using static zfunc;
    using static OpIdentity;

    public enum IdentityKind
    {
        None = 0,

        Type,

        Operation,
    }

    public static class Identity
    {
        /// <summary>
        /// Produces an identifier of the form {width(nk)}{u | i | f} for a numeric type
        /// </summary>
        /// <param name="t">A primal type representative</param>
        /// <typeparam name="T">The primal type</typeparam>
        [MethodImpl(Inline)]   
        public static TypeIdentity identify(NumericKind nk)
            => TypeIdentity.Define(NumericType.signature(nk));

        [MethodImpl(Inline)]
        public static TypeIdentity resource(string basename, ITypeNat w, NumericKind kind)
            => TypeIdentity.Define($"{basename}{w}x{kind.Signature()}");
        
        [MethodImpl(Inline)]
        public static TypeIdentity resource(string basename, ITypeNat w1, ITypeNat w2, NumericKind kind)
            => TypeIdentity.Define($"{basename}{w1}x{w2}x{kind.Signature()}");   

        [MethodImpl(Inline)]
        public static TypeIdentity identify(Type t)
            => TypeIdentities.identify(t);

        /// <summary>
        /// Produces an identifier of the form {bitsize[T]}{u | i | f} for a numeric type
        /// </summary>
        /// <param name="t">A primal type representative</param>
        /// <typeparam name="T">The primal type</typeparam>
        [MethodImpl(Inline)]   
        public static TypeIdentity numericid<T>(T t = default)
            where T : unmanaged
                => TypeIdentity.Define(NumericType.signature(typeof(T)));

        /// <summary>
        /// Identifies the method
        /// </summary>
        /// <param name="m">The method to identify</param>
        public static OpIdentity identify(MethodInfo src)
        {            
            if(src.IsOpenGeneric())
                return Identity.generic(src);
            else
                return Identity.constructed(src);
        }            

        /// <summary>
        /// Identifies the delegate
        /// </summary>
        /// <param name="m">The method to identify</param>
        public static OpIdentity identify(Delegate m)
            => identify(m.Method);

        public static OpIdentity identify(MethodInfo src, NumericKind k)
        {
            var pt = k.ToClrType();
            if(src.IsOpenGeneric() && pt.IsSome())
                return identify(src.MakeGenericMethod(pt.Value));
            else
                return identify(src);
        }


        public static string identify(ParameterInfo p)
        {
            var pt = p.ParameterType;
            if(!p.IsParametric())
            {
                var id = Identity.identify(pt.EffectiveType());
                if(!id.IsEmpty)
                    return concat(id.Identifier, p.Variance().Format());                
            }
            return string.Empty;                        
        }

        public static IEnumerable<string> parameters(MethodInfo method)
        {
            var args = method.GetParameters();
            var argtypes = method.ParameterTypes(true).ToArray();
            for(var i=0; i<argtypes.Length; i++)
            {                                
                var argtext = identify(args[i]);
                if(argtext.IsNotBlank())
                    yield return argtext;
            }
        }

        public static string name(MethodInfo m)
        {
            var attrib = m.CustomAttribute<OpAttribute>();
            if(attrib.IsNone())
                return m.Name;
        
            var sep = AsciSym.Tilde;
            var attribVal = attrib.Value;  
            var customName = attribVal.Name;
            var combine = attribVal.CombineCustomName;
            
            var name = string.Empty;

            if(customName.IsNotBlank())
            {
                name += customName;

                if(combine)
                {
                    name += sep;
                    name += m.Name;
                }
            }
            else
                name += m.Name;
                
            return name;            
        }

        public static OpIdentity constructed(MethodInfo src)
        {
            var id = src.OpName();
            var argtypes = src.ParameterTypes(true).ToArray();
            var args = src.GetParameters();

            id += PartSep;

            if(src.IsConstructedGenericMethod)
                id += OpIdentity.Generic;                           

            id += string.Join(PartSep, Identity.parameters(src));

            return OpIdentity.Define(id);
        }        

        /// <summary>
        /// Defines the identity of a generic method
        /// </summary>
        /// <param name="src">The source method</param>
        public static OpIdentity generic(MethodInfo src)            
        {
            if(!src.IsGenericMethod)
                return OpIdentity.Empty;
                        
            var id = src.OpName();
            id += PartSep; 
            id += Generic;

            var args = src.GetParameters();
            var argtypes = src.ParameterTypes(true).ToArray();
            var last = string.Empty;
            for(var i=0; i<argtypes.Length; i++)
            {
                var argtype = argtypes[i];
                if(i != 0 && last.IsNotBlank())
                    id += PartSep;

                last = string.Empty;                    

                if(args[i].IsParametric())
                    last = Identity.identify(args[i]);
                else if(argtype.IsOpenGeneric())
                {
                    if(argtype.IsVector())
                        last = concat(TypeIdentity.Vector,argtype.Width().Format());
                    else if(argtype.IsBlocked())
                        last = concat(TypeIdentity.Block, argtype.Width().Format());
                    else if(argtype.IsSpan())
                        last = argtype.SpanKind().Format();
                }
                
                id += last;
            }

            return OpIdentity.Define(id);        
        }

        public static OpIdentity group(MethodInfo method)            
        {
            var id = method.OpName();
            var args = Identity.parameters(method).ToArray();
            for(var i=0; i<args.Length; i++)            
            {
                id += OpIdentity.PartSep;                    
                id += args[i];
            }
            return OpIdentity.Define(id);
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
            var g = generic ? $"{Generic}" : string.Empty;
            var suffixPart = string.IsNullOrWhiteSpace(suffix) ?  string.Empty : $"{SuffixSep}{suffix}";

            if(generic && k == NumericKind.None)
                return OpIdentity.Define(concat(opname, PartSep, Generic, suffixPart));            
            else if(w.IsSome())
                return OpIdentity.Define(concat(opname, PartSep, $"{g}{w.Format()}{TypeIdentity.SegSep}{NumericType.signature(k)}", suffixPart));
            else
                return OpIdentity.Define(concat($"{opname}_{g}{NumericType.signature(k)}{suffixPart}"));
        }

        /// <summary>
        /// Produces an identifier of the form {opname}_{bitsize(kind)}{u | i | f}
        /// </summary>
        /// <param name="opname">The base operator name</param>
        /// <param name="k">The primal kind over which the identifier is deined</param>
        [MethodImpl(Inline)]   
        public static OpIdentity operation(string opname, NumericKind k)
            => operation(opname, FixedWidth.None, k, false);

        /// <summary>
        /// Produces an identifier of the form {opname}_{g}{bitsize(kind)}{u | i | f}
        /// </summary>
        /// <param name="opname">The base operator name</param>
        /// <param name="k">The primal kind over which the identifier is deined</param>
        [MethodImpl(Inline)]   
        public static OpIdentity operation(string opname, NumericKind k, bool generic)
            => operation(opname, FixedWidth.None, k, generic);

        /// <summary>
        /// Defines an operand identifier of the form {opname}_N{u | i | f} that identifies an operation over a primal type of bit width N := bitsize[T]
        /// </summary>
        /// <param name="opname">The base operator name</param>
        /// <param name="t">A primal type representative</param>
        /// <typeparam name="T">The primal type</typeparam>
        [MethodImpl(Inline)]   
        public static OpIdentity operation<T>(string opname, T t = default)
            => operation(opname,typeof(T).NumericKind());

        /// <summary>
        /// Defines a moniker with rendering {opname}_N{u | i | f} that identifies an
        /// operation over a primal type of bit width N := bitsize[T]
        /// </summary>
        /// <param name="opname">The base operator name</param>
        /// <param name="t">A primal type representative</param>
        /// <typeparam name="T">The primal type</typeparam>
        [MethodImpl(Inline)]   
        public static OpIdentity operation<T>(string opname, HK.Numeric<T> hk)
            where T : unmanaged
                => operation(opname,typeof(T).NumericKind());

        /// <summary>
        /// Produces an identifier of the form {opname}_{w}{typesig(nk)}
        /// </summary>
        /// <param name="opname">The base operator name</param>
        /// <param name="k">The primal kind over which the identifier is deined</param>
        [MethodImpl(Inline)]   
        public static OpIdentity operation(string opname, FixedWidth w, NumericKind nk)
            => operation(opname,w,nk,false);

        /// <summary>
        /// Defines an identifier of the form {opname}_256xN{u | i | f} where N := bitsize[T]
        /// </summary>
        /// <param name="opname">The base operator name</param>
        /// <param name="w">The covering bit width representative</param>
        /// <param name="t">A primal cell type representative</param>
        /// <typeparam name="W">The bit width type</typeparam>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline)]   
        public static OpIdentity operation<T>(string opname, HK.Vec256<T> hk)
            where T : unmanaged
                => operation(opname, n256, NumericType.kind<T>());
                
        /// <summary>
        /// Defines an identifier of the form {opname}_128xN{u | i | f} where N := bitsize[T]
        /// </summary>
        /// <param name="opname">The base operator name</param>
        /// <param name="w">The covering bit width representative</param>
        /// <param name="t">A primal cell type representative</param>
        /// <typeparam name="W">The bit width type</typeparam>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline)]   
        public static OpIdentity operation<T>(string opname, N128 w, T t = default)
            where T : unmanaged
                => Identity.operation(opname,w, NumericType.kind<T>());

        /// <summary>
        /// Defines an identifier of the form {opname}_256xN{u | i | f} where N := bitsize[T]
        /// </summary>
        /// <param name="opname">The base operator name</param>
        /// <param name="w">The covering bit width representative</param>
        /// <param name="t">A primal cell type representative</param>
        /// <typeparam name="W">The bit width type</typeparam>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline)]   
        public static OpIdentity operation<T>(string opname, N256 w, T t = default)
            where T : unmanaged
                => Identity.operation(opname,w, NumericType.kind<T>());

        /// <summary>
        /// Defines an identifier of the form {opname}_WxN{u | i | f} where N := bitsize[T]
        /// </summary>
        /// <param name="opname">The base operator name</param>
        /// <param name="w">The covering bit width representative</param>
        /// <param name="t">A primal cell type representative</param>
        /// <typeparam name="W">The bit width type</typeparam>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline)]   
        public static OpIdentity operation<W,T>(string opname, W w = default, T t = default)
            where W : unmanaged, ITypeNat
            where T : unmanaged
                => operation(opname,w, NumericType.kind<T>());

        /// <summary>
        /// Transforms a nonspecific identity part into a specialized scalar part, if the source part is indeed a scalar identity
        /// </summary>
        /// <param name="part">The source part</param>
        public static Option<ScalarIdentity> scalar(OpIdentityPart part)
        {
            if(part.PartKind == OpIdentityPartKind.Scalar)
            {
                return from k in NumericType.parseKind(part.PartText)
                    let scalar = ScalarIdentity.Define((FixedWidth)k.Width(), k.Indicator())
                    select scalar;
            }
            else
                return none<ScalarIdentity>();                
        }

        /// <summary>
        /// Extracts an index-identified operation identity part from an operation identity
        /// </summary>
        /// <param name="src">The source identity</param>
        /// <param name="partidx">The 0-based part index</param>
        public static Option<OpIdentityPart> part(OpIdentity src, int partidx)
        {
            var parts = src.Parts.ToArray();
            if(partidx <= parts.Length - 1)
                return parts[partidx];
            else
                return none<OpIdentityPart>();
        }

        /// <summary>
        /// Transforms a nonspecific identity part into a specialized segment part, if the source part is indeed a segment identity
        /// </summary>
        /// <param name="part">The source part</param>
        public static Option<OpIdentitySegment> segment(OpIdentityPart part)
        {
            if(part.PartKind == OpIdentityPartKind.Segment)
            {
                if(OpIdentitySegment.TryParse(part.PartText, out var seg))
                    return seg;                
            }

            return none<OpIdentitySegment>();                
        }

        /// <summary>
        /// Extracts an index-identified segmented identity part from an operation identity
        /// </summary>
        /// <param name="src">The source identity</param>
        /// <param name="partidx">The 0-based part index</param>
        public static Option<OpIdentitySegment> segment(OpIdentity src, int partidx)
            => from p in part(src, partidx)
                from s in segment(p)
                select s;

        /// <summary>
        /// Defines an 8-bit immediate suffix predicated on an immediate value
        /// </summary>
        /// <param name="immval">The source value</param>
        public static string imm8(byte immval)            
            => $"{OpIdentity.SuffixSep}{OpIdentity.Imm}{immval}";

        /// <summary>
        /// Extracts an 8-bit immediate value from an identity if it contains an immediate suffix; otherwise, returns none
        /// </summary>
        /// <param name="src">The source identity</param>
        public static Option<byte> imm8(OpIdentity src)            
        {
            if(src.HasImm && byte.TryParse(src.Identifier.RightOfLast(OpIdentity.Imm), out var immval))
                return immval;
            else
                return none<byte>();
        }

        /// <summary>        
        /// Clears an attached immediate suffix, if any
        /// </summary>
        public static OpIdentity imm8Remove(OpIdentity src)
            => imm8(src).MapValueOrDefault(immval => OpIdentity.Define(src.Identifier.Remove(imm8(immval))), src);

        /// <summary>        
        /// Attaches an immediate suffix to an identity, removing an existing immediate suffix if necessary
        /// </summary>
        /// <param name="src">The source identity</param>
        /// <param name="immval">The immediate value to attach</param>
        public static OpIdentity imm8Add(OpIdentity src, byte immval)
            => OpIdentity.Define(concat(imm8Remove(src).Identifier, imm8(immval)));

        /// <summary>
        /// Gets the name of a method to which to Op attribute is applied
        /// </summary>
        /// <param name="m">The source method</param>
        public static string host(Type t)
            => t.CustomAttribute<OpHostAttribute>().MapValueOrDefault(a => a.Name, t.Name.ToLower());

        /// <summary>
        /// Produces the name of the test case for the specified function
        /// </summary>
        /// <param name="f">The function</param>
        public static string testcase(Type host, IFunc f)
            => $"{host.Name}/{f.Moniker}";

        /// <summary>
        /// Produces the name of the test case predicated on fully-specified name, exluding the host name
        /// </summary>
        /// <param name="m">Moniker that identifies the operation under test</param>
        public static string testcase(Type host, OpIdentity m)
            => $"{host.Name}/{m}";

        /// <summary>
        /// Produces the name of the test case predicated on fully-specified name, exluding the host name
        /// </summary>
        /// <param name="fullname">The full name of the test</param>
        public static string testcase(Type host,string fullname)
            => $"{host.Name}/{fullname}";

        /// <summary>
        /// Produces the name of the test case predicated on a root name and parametric type
        /// </summary>
        /// <param name="root">The root name</param>
        public static string testcase<C>(Type host, string root, C t = default)
            where C : unmanaged
            => $"{host.Name}/{root}_{Identity.numericid(t)}";

        public static string testcase<W,C>(Type host, string root, W w = default, C t = default)
            where W : unmanaged, ITypeNat
            where C : unmanaged
                => $"{host.Name}/{Identity.operation(root,w,t)}";

        public static OpIdentity subject(string opname, NumericKind kind)
            => Identity.operation($"{opname}_subject",kind);

        public static OpIdentity subject<T>(string opname, T t = default)
            where T : unmanaged
                => subject(opname, NumericType.kind<T>());
 
        public static Option<IOpIdentityProvider> provider(IdentityKind kind)
            => kind switch
            {
                IdentityKind.Operation => default(OpIdentityProvider),
                _ => default
            };

        public static ITypeIdentityProvider provider(Type t)
            => TypeIdentities.provider(t);

        readonly struct OpIdentityProvider : IOpIdentityProvider
        {
            public OpIdentity DefineIdentity(MethodInfo src, NumericKind k)
                => Identity.identify(src,k);

            public OpIdentity GroupIdentity(MethodInfo src)            
                => Identity.group(src);

            public OpIdentity GenericIdentity(MethodInfo src)            
                => Identity.generic(src);

            OpIdentity IOpIdentityProvider.DefineIdentity(MethodInfo src)
                => Identity.identify(src);
        }
 
    }
}