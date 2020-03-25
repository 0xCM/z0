// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System; 
    using System.Linq;   
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;

    using static Root;
    
    readonly struct RowBitsIdentity : ITypeIdentityProvider
    {        
        public static TypeIdentity IdentifyNumericClosure(string root, Type arg)
        {
            var kind = arg.NumericKind();
            var indicator = kind.Indicator().ToChar();
            var width = kind.Width();
            return TypeIdentity.Define($"{root}{width}{indicator}");
        }
        
        const string @base = "rowbits";

        public IEnumerable<Type> Identifiable => items(typeof(RowBits<>));
        
        public TypeIdentity DefineIdentity(Type src)
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
                return Identify.NumericClosure(@base, arg);
            }
        }
    }
}