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

    using static zfunc;

    public static class TypeIdentities
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
            => TypeIdentityProvider.from(t).DefineIdentity(t);
            
        /// <summary>
        /// Produces an identifier of the form {bitsize[T]}{u | i | f} for a numeric type
        /// </summary>
        /// <param name="t">A primal type representative</param>
        /// <typeparam name="T">The primal type</typeparam>
        [MethodImpl(Inline)]   
        public static TypeIdentity numericid<T>(T t = default)
            where T : unmanaged
                => TypeIdentity.Define(NumericType.signature(typeof(T)));

        static Option<string> CommonIdentity(this Type arg)
        {
            if(arg.IsPointer)
                return from id in arg.Unwrap().CommonIdentity()
                let idptr = concat(id, parenthetical(OpIdentity.Pointer))
                select idptr;    
            else
            {                        
                if(arg.IsNat())
                    return arg.NatIdentity();
                else if(NumericType.test(arg))
                    return arg.NumericIdentity();
                else if(arg.IsEnum)
                    return arg.EnumIdentity();
                else if(arg.IsSpan())
                    return arg.SpanIdentity();
                else if(arg.IsNatSpan())
                    return arg.NatSpanIdentity();
                else if(arg == typeof(bit))
                    return "1u";                
            }

            return default;
        }

        static bool HasCommonIdentityRaw(this Type t)
            => t.IsNat() || NumericType.test(t) || t.IsEnum || t.IsSpan() || t.IsNatSpan();

        static bool HasCommonIdentity(this Type t)
            => t.HasCommonIdentityRaw() || t.Unwrap().HasCommonIdentityRaw();

        static Option<string> EnumIdentity(this Type arg)
            =>  TypeIdentities.EnumIdentity(arg) 
                ? $"enum{OpIdentity.SegSep}{NumericType.signature(arg.GetEnumUnderlyingType())}" 
                : default;

        static Option<string> NatIdentity(this Type arg)
            => from v in arg.NatValue() 
                let id = concat(OpIdentity.Nat, v.ToString())
                select id;

        static Option<string> NumericIdentity(this Type arg)
            => NumericType.test(arg) 
                ? NumericType.signature(arg) 
                : default;

        static Option<string> SpanIdentity(this Type arg)
            => arg.IsSpan() ? arg.GetGenericArguments().Single().CommonIdentity().MapValueOrDefault(x => concat(OpIdentity.Span,x))
             : none<string>();
                                
        internal static TypeIdentity DefineDefaultIdentity(this Type arg)
        { 
            Option<string> text = default;

            if(arg.HasCommonIdentity())
                text = arg.CommonIdentity();
            else if(arg.IsConstructedGenericType)              
            {
                var typeargs = arg.SuppliedTypeArgs().ToArray();
                var typearg = typeargs[0];                
                if(arg.HasCommonIdentity())
                    text = arg.CommonIdentity();
                else if(arg.IsSegmented())
                    text = arg.SegmentedIdentity(typearg).ValueOrDefault();
            }   
                
            return text.MapValueOrElse(t => TypeIdentity.Define(t), () => TypeIdentity.Empty);
        } 

        static Option<string> SegIndicator(this Type t)
        {
            if(t.IsBlocked())
                return $"{OpIdentity.Block}";
            else if(t.IsVector())
                return $"{OpIdentity.Vector}";
            else return none<string>();
        }

        static Option<string> SegmentedIdentity(this Type t, Type arg)
            => from i in t.SegIndicator()
                let segwidth = t.Width()
                let argwidth = arg.Width()
                let nk = arg.NumericKind()
                where segwidth.IsSome() && argwidth.IsSome() && nk.IsSome()
                select $"{i}{segwidth.Format()}{OpIdentity.SegSep}{argwidth.Format()}{nk.Indicator().Format()}";

    }
}