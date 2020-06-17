// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System; 
    using System.Linq;   
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static Memories;
    
    readonly struct RowBitsIdentityProvider : ITypeIdentityProvider
    {        
        public static TypeIdentity NumericClosure(string root, Type arg)
        {
            var kind = arg.NumericKind();
            var indicator = kind.Indicator().ToChar();
            var width = kind.Width();
            return TypeIdentity.Define($"{root}{width}{indicator}");
        }
        
        const string @base = "rowbits";

        public IEnumerable<Type> Identifiable => seq(typeof(RowBits<>));
        
        public TypeIdentity Identify(Type src)
        {
            var t = src.GenericDefinition();
            if(t.IsNone())
                return TypeIdentity.Empty;
            
            if(t.Value != typeof(RowBits<>))
                return TypeIdentity.Empty;

            if(src.IsOpenGeneric())
                return TypeIdentity.Define($"{@base}G");
            else
            {
                var arg = src.GetGenericArguments().Single();
                return Z0.Identify.numeric(@base, arg);
            }
        }
    }
}