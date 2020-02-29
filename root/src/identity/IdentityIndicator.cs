//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Runtime.CompilerServices;
    
    using static Root;

    using IIK = IdentityIndicatorKind;

    [AttributeUsage(AttributeTargets.Field)]
    class IdentityIndicatorAttribute : Attribute
    {
        public IdentityIndicatorAttribute(IdentityIndicatorKind kind)        
            => this.IndicatorKind = kind;
        
        public IdentityIndicatorKind IndicatorKind {get;}
    }

    public static class IdentityIndicatorOps
    {
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