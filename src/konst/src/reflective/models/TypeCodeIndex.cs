//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{    
    using System;
    using System.Runtime.CompilerServices;
 
    using static Konst;
    
    public readonly struct TypeCodeIndex
    {        
        readonly Type[] PrimalTypes;

        [MethodImpl(Inline)]
        public TypeCodeIndex(Type[] src)
            => PrimalTypes = src;

        public ref readonly Type this[TypeCode code]
        {
            [MethodImpl(Inline)]
            get => ref PrimalTypes[(int)code];
        }
    }
}