// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System; 
    using System.Linq;   
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;

    using static Seed;
    
    public readonly struct NumericIdentityProvider : ITypeIdentityProvider
    {                
        public TypeIdentity Identify(Type src)
            => TypeIdentity.Define(src.NumericKind().Format());

        public IEnumerable<Type> Identifiable 
            => seq(
                typeof(byte), typeof(ushort), typeof(uint), typeof(ulong), 
                typeof(sbyte), typeof(short), typeof(int), typeof(long),                 
                typeof(float), typeof(double)
                );
    }
}