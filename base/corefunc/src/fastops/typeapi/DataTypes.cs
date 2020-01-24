//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using System.Runtime.Intrinsics;
    using System.Reflection;
    using System.Reflection.Emit;
    using System.Linq;
    using System.Collections.Generic;

    using static zfunc;

    public static class DataTypes
    {
        [MethodImpl(Inline)]
        public static Option<char> indicator(Type t)
        {
            var i = PrimalType.indicator(t);
            if(i.IsNone())
            {
                if(t == typeof(bit))
                    return AsciLower.u;
                else 
                    return default;
            }
            else
                return i.Value;            
        }

    
        public static Option<int> width(Type t)
        {
            if(PrimalType.test(t))
                return (int)PrimalType.width(t);
            else if(VectorType.test(t))
                return (int)VectorType.width(t);
            else if(BlockedType.test(t))
                return (int)BlockedType.width(t);
            else if(t == typeof(bit))
                return (int)FixedWidth.W1;
            else
                return default;
        }

    }

}
