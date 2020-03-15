//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Collections.Generic;
    using System.Linq;

    using static Root;

    using IIK = IdentityIndicatorKind;

    public static class IdentityKindOps
    {
       [MethodImpl(Inline)]
        public static bool IsNumericIndicator(this IdentityPartKind kind)
            => kind == IdentityPartKind.FloatIndicator 
            || kind == IdentityPartKind.UnsignedIndicator 
            || kind == IdentityPartKind.SignedIndicator;

        [MethodImpl(Inline)]
        public static bool IsArgList(this IdentityPartKind kind)
            => kind == IdentityPartKind.ValueArgList 
            || kind == IdentityPartKind.TypeArgList;

        [MethodImpl(Inline)]
        public static bool IsArg(this IdentityPartKind kind)
            => kind == IdentityPartKind.ValueArg
            || kind == IdentityPartKind.TypeArg;
        
        [MethodImpl(Inline)]
        public static bool IsModifier(this IdentityPartKind kind)
            => (TermModifierKind)kind >= TermModifierKind.First 
            && (TermModifierKind)kind <= TermModifierKind.Last;

         [MethodImpl(Inline)]
        public static bool IsSome(this GenericKind kind)
            => kind != GenericKind.None;

        [MethodImpl(Inline)]
        public static bool IsSome(this IdentityIndicatorKind kind)
            => kind != 0;

        [MethodImpl(Inline)]
        public static bool IsNone(this IdentityIndicatorKind kind)
            => kind == 0;

        [MethodImpl(Inline)]
        public static string Format(this IdentityIndicatorKind kind)
            => IndicatorFormats.TryGetValue(kind, out var fmt) ? fmt : string.Empty;

        static Dictionary<IdentityIndicatorKind,string> IndicatorFormats {get;}
            = IndexFormats();

        static Dictionary<IdentityIndicatorKind,string> IndexFormats()
        {
            try
            {
                var fields = from f in typeof(IDI).TaggedFieldIndex<IdentityIndicatorAttribute>()
                            let kind = f.Value.IndicatorKind
                            let format = (f.Key.GetRawConstantValue()?.ToString()) ?? string.Empty
                            select (kind,format);                                      
                return fields.ToDictionary();
            }
            catch(Exception e)
            {
                Console.Error.WriteLine(e.ToString());
                return new Dictionary<IIK, string>();
            }            
        }        
    }
}