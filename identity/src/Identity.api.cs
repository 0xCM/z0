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

    using static Root;

    public static partial class Identity
    {
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
            => OpIdentity.operation(opname,w,k,generic,suffix);

        /// <summary>
        /// Produces an identifier of the form {opname}_{g}{bitsize(kind)}{u | i | f}
        /// </summary>
        /// <param name="opname">The base operator name</param>
        /// <param name="k">The primal kind over which the identifier is deined</param>
        [MethodImpl(Inline)]   
        public static OpIdentity numeric(string opname, NumericKind k, bool generic)
            => operation(opname, FixedWidth.None, k, generic);

        /// <summary>
        /// Produces an identifier of the form {opname}_{bitsize(kind)}{u | i | f}
        /// </summary>
        /// <param name="opname">The base operator name</param>
        /// <param name="k">The primal kind over which the identifier is deined</param>
        [MethodImpl(Inline)]   
        public static OpIdentity numeric(string opname, NumericKind k)
            => operation(opname, FixedWidth.None, k, false);

        /// <summary>
        /// Produces an identifier of the form {opname}_g{kind}{u | i | f}
        /// </summary>
        /// <param name="opname">The base operator name</param>
        /// <param name="t">A primal type representative</param>
        /// <typeparam name="T">The primal type</typeparam>
        [MethodImpl(Inline)]   
        public static OpIdentity numeric<T>(string opname, NumericType<T> hk = default, bool generic = true)
            where T : unmanaged
                => operation(opname, FixedWidth.None, typeof(T).NumericKind(), generic);       

        /// <summary>
        /// Produces an identifier of the form {opname}_{w}{typesig(nk)}
        /// </summary>
        /// <param name="opname">The base operator name</param>
        /// <param name="k">The primal kind over which the identifier is deined</param>
        [MethodImpl(Inline)]   
        public static OpIdentity fixedop(string opname, FixedWidth w, NumericKind nk)
            => operation(opname,w,nk,false);

        /// <summary>
        /// Defines an operand identifier of the form {opname}_N{u | i | f} that identifies an operation over a primal type of bit width N := bitsize[T]
        /// </summary>
        /// <param name="opname">The base operator name</param>
        /// <param name="t">A primal type representative</param>
        /// <typeparam name="T">The primal type</typeparam>
        [MethodImpl(Inline)]   
        public static OpIdentity contracted<T>(string opname, T t = default)
            => numeric(opname,typeof(T).NumericKind());

        /// <summary>
        /// Identifies the method
        /// </summary>
        /// <param name="m">The method to identify</param>
        public static OpIdentity identify(MethodInfo src)
        {            
            if(src.IsOpenGeneric())
                return Identity.generic(src);
            else if(src.IsConstructedGenericMethod)
                return constructed(src);
            else
                return nongeneric(src);
        }            

        public static OpIdentity identify(MethodInfo src, NumericKind k)
        {
            var pt = k.ToClrType();
            if(src.IsOpenGeneric() && pt.IsSome())
                return identify(src.MakeGenericMethod(pt.Value));
            else
                return identify(src);
        }
        
        /// <summary>
        /// Identifies the delegate
        /// </summary>
        /// <param name="m">The method to identify</param>
        public static OpIdentity identify(Delegate m)
            => identify(m.Method);

        [MethodImpl(Inline)]
        public static TypeIdentity identify(Type t)
            => provider(t).DefineIdentity(t);

        [MethodImpl(Inline)]
        public static TypeIdentity resource(string basename, ITypeNat w, NumericKind kind)
            => TypeIdentity.Define($"{basename}{w}x{kind.Format()}");
        
        [MethodImpl(Inline)]
        public static TypeIdentity resource(string basename, ITypeNat w1, ITypeNat w2, NumericKind kind)
            => TypeIdentity.Define($"{basename}{w1}x{w2}x{kind.Format()}");   

        /// <summary>
        /// Extracts an index-identified segmented identity part from an operation identity
        /// </summary>
        /// <param name="src">The source identity</param>
        /// <param name="partidx">The 0-based part index</param>
        public static Option<SegmentedIdentity> segment(OpIdentity src, int partidx)
            => from p in part(src, partidx)
                from s in segmented(p)
                select s;

        public static string identify(ParameterInfo p)
        {
            if(!p.IsParametric())
            {
                var id = Identity.identify(p.ParameterType.EffectiveType());
                if(!id.IsEmpty)
                    return text.concat(id.Identifier, p.Variance().Format());                
            }
            return string.Empty;                        
        }

        /// <summary>
        /// Defines the identity of a generic method
        /// </summary>
        /// <param name="src">The source method</param>
        public static OpIdentity generic(MethodInfo src)            
        {
            if(!src.IsGenericMethod)
                return OpIdentity.Empty;
                        
            var id = name(src);
            id += IDI.PartSep; 
            id += IDI.Generic;

            var args = src.GetParameters();
            var argtypes = src.ParameterTypes(true).ToArray();
            var last = string.Empty;
            for(var i=0; i<argtypes.Length; i++)
            {
                var argtype = argtypes[i];
                if(i != 0 && last.IsNotBlank())
                    id += IDI.PartSep;

                last = string.Empty;                    

                if(args[i].IsParametric())
                    last = Identity.identify(args[i]);
                else if(argtype.IsOpenGeneric())
                {
                    if(argtype.IsVector())
                        last = text.concat(IDI.Vector,argtype.Width().Format());
                    else if(argtype.IsBlocked())
                        last = text.concat(IDI.Block, argtype.Width().Format());
                    else if(argtype.IsSpan())
                        last = argtype.SpanKind().Format();
                }
                
                id += last;
            }

            return OpIdentity.Define(id);        
        }

        /// <summary>
        /// Produces the formatted identifier of the declaring assembly
        /// </summary>
        /// <param name="host">The source type</param>
        public static string owner(Type host)
            => host.Assembly.AssemblyId().Format();

        /// <summary>
        /// Produces the name of the test case for the specified function
        /// </summary>
        /// <param name="f">The function</param>
        public static string testcase(Type host, IFunc f)
            => $"{owner(host)}/{host.Name}/{f.Id}";

        /// <summary>
        /// Produces an identifier of the form {owner}/{host} where owner is the formatted identifier of the declaring assembly
        /// and host is the name of the type
        /// </summary>
        /// <param name="host">The source type</param>
        public static string testhosturi(Type host)
            => $"{owner(host)}/{host.Name}";

        /// <summary>
        /// Produces the name of the test case predicated on fully-specified name, exluding the host name
        /// </summary>
        /// <param name="id">Identity of the operation under test</param>
        public static string testcase(Type host, OpIdentity id)
            => $"{owner(host)}/{host.Name}/{id}";

        /// <summary>
        /// Produces the name of the test case determined by a source method
        /// </summary>
        /// <param name="method">The method that implements the test</param>
        public static string testcase(MethodInfo method)
            => $"{owner(method.DeclaringType)}/{method.DeclaringType.Name}/{method.Name}";

        /// <summary>
        /// Produces the name of the test case predicated on fully-specified name, exluding the host name
        /// </summary>
        /// <param name="fullname">The full name of the test</param>
        public static string testcase(Type host,string fullname)
            => $"{owner(host)}{host.Name}/{fullname}";

        /// <summary>
        /// Produces the name of the test case predicated on a root name and parametric type
        /// </summary>
        /// <param name="root">The root name</param>
        public static string testcase<C>(Type host, string root, C t = default)
            where C : unmanaged
                => $"{owner(host)}{host.Name}/{root}_{TypeIdentity.numeric(t)}";        
    }

    public static class IdentityExtensions
    {        
        /// <summary>
        /// Returns a kind-identified system type if possible; throws an exception otherwise
        /// </summary>
        /// <param name="k">The identifying kind</param>
        [MethodImpl(Inline)]
        public static Option<Type> ToClrType(this NumericKind k)
        {
            var nt = k.NumericType();
            return nt.IsSome() ? some(nt.Subject) : none<Type>();
        }

        /// <summary>
        /// Identifies the method
        /// </summary>
        /// <param name="m">The method to identify</param>
        public static OpIdentity Identify(this MethodInfo m)
            => Identity.identify(m);

        /// <summary>
        /// Identifies the delegate
        /// </summary>
        /// <param name="m">The method to identify</param>
        public static OpIdentity Identify(this Delegate m)
            => Identity.identify(m);
    }    
}