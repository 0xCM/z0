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

    using static zfunc;

    using static OpIdentity;

    public static class OpIdentities
    {
        public static IOpIdentityProvider Provider
            => default(DefaultProvider);

        /// <summary>
        /// Produces an identifier of the form {opname}_{g}{bitsize(kind)}{u | i | f}
        /// </summary>
        /// <param name="opname">The base operator name</param>
        /// <param name="k">The primal kind over which the identifier is deined</param>
        [MethodImpl(Inline)]   
        public static OpIdentity identify(string opname, NumericKind k, bool generic)
            => build(opname, FixedWidth.None, k, generic);

        /// <summary>
        /// Produces an identifier of the form {opname}_{w}{typesig(nk)}
        /// </summary>
        /// <param name="opname">The base operator name</param>
        /// <param name="k">The primal kind over which the identifier is deined</param>
        [MethodImpl(Inline)]   
        public static OpIdentity identify(string opname, FixedWidth w, NumericKind nk)
            => build(opname,w,nk,false);

        /// <summary>
        /// Defines a moniker with rendering {opname}_N{u | i | f} that identifies an
        /// operation over a primal type of bit width N := bitsize[T]
        /// </summary>
        /// <param name="opname">The base operator name</param>
        /// <param name="t">A primal type representative</param>
        /// <typeparam name="T">The primal type</typeparam>
        [MethodImpl(Inline)]   
        public static OpIdentity identify<T>(string opname, T t = default)
            => identify(opname,typeof(T).NumericKind());

        /// <summary>
        /// Defines a moniker with rendering {opname}_N{u | i | f} that identifies an
        /// operation over a primal type of bit width N := bitsize[T]
        /// </summary>
        /// <param name="opname">The base operator name</param>
        /// <param name="t">A primal type representative</param>
        /// <typeparam name="T">The primal type</typeparam>
        [MethodImpl(Inline)]   
        public static OpIdentity identify<T>(string opname, HK.Numeric<T> hk)
            where T : unmanaged
                => identify(opname,typeof(T).NumericKind());

        /// <summary>
        /// Produces an identifier of the form {opname}_{bitsize(kind)}{u | i | f}
        /// </summary>
        /// <param name="opname">The base operator name</param>
        /// <param name="k">The primal kind over which the identifier is deined</param>
        [MethodImpl(Inline)]   
        public static OpIdentity identify(string opname, NumericKind k)
            => build(opname, FixedWidth.None, k, false);

        /// <summary>
        /// Defines an identifier of the form {opname}_WxN{u | i | f} where N := bitsize[T]
        /// </summary>
        /// <param name="opname">The base operator name</param>
        /// <param name="w">The covering bit width representative</param>
        /// <param name="t">A primal cell type representative</param>
        /// <typeparam name="W">The bit width type</typeparam>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline)]   
        public static OpIdentity identify<W>(string opname, W w, NumericKind k)
            where W : unmanaged, ITypeNat            
                => build(opname, (FixedWidth)nateval<W>(), k, false);

        /// <summary>
        /// Defines an identifier of the form {opname}_256xN{u | i | f} where N := bitsize[T]
        /// </summary>
        /// <param name="opname">The base operator name</param>
        /// <param name="w">The covering bit width representative</param>
        /// <param name="t">A primal cell type representative</param>
        /// <typeparam name="W">The bit width type</typeparam>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline)]   
        public static OpIdentity identify<T>(string opname, HK.Vec256<T> hk)
            where T : unmanaged
                => identify(opname, n256, NumericType.kind<T>());

        //Moniker.Parse($"{opname}_{w}{SegSep}{NumericType.signature(k)}");

        /// <summary>
        /// Defines a moniker of the form {opname}_{w}X{bitsize(k)}{u | i | f}{_asm} to identify 
        /// an operation over a segmented type of bitwidth w over a primal kind k
        /// </summary>
        /// <param name="opname">The base operator name/operator classifier</param>
        /// <param name="w">The total bit-widht of the segmented type</param>
        /// <param name="k">The primal cell kind</param>
        /// <param name="generic">Whether a generic operation is identified</param>
        /// <param name="asm">Whether the moniker has an asm suffix</param>
        public static OpIdentity identify(string opname, FixedWidth w, NumericKind k, bool generic, string suffix = null) 
            => build(opname, w, k, generic,suffix);

        /// <summary>
        /// Defines a moniker in accordance with the supplied parameters
        /// </summary>
        /// <param name="opname">The base operator name/operator classifier</param>
        /// <param name="w">For segmented types, the total bit-width; otherwise 0</param>
        /// <param name="k">The primal kind</param>
        static OpIdentity build(string opname, FixedWidth w, NumericKind k, bool generic, string suffix = null)
        {
            var g = generic ? $"{Generic}" : string.Empty;
            var suffixPart = string.IsNullOrWhiteSpace(suffix) ?  string.Empty : $"{SuffixSep}{suffix}";

            if(generic && k == NumericKind.None)
                return OpIdentity.Define(concat(opname, PartSep, Generic, suffixPart));            
            else if(w.IsSome())
                return OpIdentity.Define(concat(opname, PartSep, $"{g}{w.Format()}{SegSep}{NumericType.signature(k)}", suffixPart));
            else
                return OpIdentity.Define(concat($"{opname}_{g}{NumericType.signature(k)}{suffixPart}"));
        }

        readonly struct DefaultProvider : IOpIdentityProvider
        {
            public OpIdentity DefineIdentity(MethodInfo method, NumericKind k)
            {
                var provider = this as IOpIdentityProvider;
                var pt = k.ToClrType();
                if(method.IsOpenGeneric() && pt.IsSome())
                    return  provider.DefineIdentity(method.MakeGenericMethod(pt.Value));
                else
                    return provider.DefineIdentity(method);
            }

            public OpIdentity GroupIdentity(MethodInfo method)            
            {
                var id = method.OpName();
                var args = Args(method).ToArray();
                for(var i=0; i<args.Length; i++)            
                {
                    id += OpIdentity.PartSep;                    
                    id += args[i];
                }
                return OpIdentity.Define(id);
            }

            public OpIdentity GenericIdentity(MethodInfo method)            
            {
                if(!method.IsGenericMethod)
                    return OpIdentity.Empty;
                            
                var id = method.OpName();
                id += OpIdentity.PartSep; 
                id += OpIdentity.Generic;

                var args = method.GetParameters();
                var argtypes = method.ParameterTypes(true).ToArray();
                var last = string.Empty;
                for(var i=0; i<argtypes.Length; i++)
                {
                    var argtype = argtypes[i];
                    if(i != 0 && last.IsNotBlank())
                        id += OpIdentity.PartSep;

                    last = string.Empty;                    

                    if(args[i].IsParametric())
                        last = Arg(args[i]);
                    else if(argtype.IsOpenGeneric())
                    {
                        if(argtype.IsVector())
                            last = concat(OpIdentity.Vector,argtype.Width().Format());
                        else if(argtype.IsBlocked())
                            last = concat(OpIdentity.Block, argtype.Width().Format());
                        else if(argtype.IsSpan())
                            last = OpIdentity.Span;                        
                    }
                    
                    id += last;
                }

                return OpIdentity.Define(id);        
            }

            /// <summary>
            /// Makes a best-guess at defining an appropriate moniker for a specified method
            /// </summary>
            /// <param name="method">The operation method</param>
            OpIdentity IOpIdentityProvider.DefineIdentity(MethodInfo method)
            {            
                if(method.IsOpenGeneric())
                    return GenericIdentity(method);
                else
                    return FromAny(method);
            }
            
            static string Arg(ParameterInfo p)
            {
                var pt = p.ParameterType;
                if(!p.IsParametric())
                {
                    var id = TypeIdentities.identify(pt.EffectiveType());
                    if(!id.IsEmpty)
                        return concat(id.Identifier, p.Variance().Format());                
                }
                return string.Empty;                        
            }

            static IEnumerable<string> Args(MethodInfo method)
            {
                var args = method.GetParameters();
                var argtypes = method.ParameterTypes(true).ToArray();
                for(var i=0; i<argtypes.Length; i++)
                {                                
                    var argtext = Arg(args[i]);
                    if(argtext.IsNotBlank())
                        yield return argtext;
                }
            }

            static OpIdentity FromAny(MethodInfo method)
            {
                var id = method.OpName();
                var argtypes = method.ParameterTypes(true).ToArray();
                var args = method.GetParameters();

                id += PartSep;

                if(method.IsConstructedGenericMethod)
                    id += Generic;                           

                id += string.Join(OpIdentity.PartSep, Args(method));

                return OpIdentity.Define(id);
            }        
        }
    }
}