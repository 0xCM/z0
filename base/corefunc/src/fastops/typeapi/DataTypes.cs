//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;

    using static zfunc;

    public static class DataTypes
    {
        [MethodImpl(Inline)]
        public static Option<char> indicator(Type t)
        {
            var i = NumericType.indicator(t);
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
            if(NumericType.test(t))
                return (int)NumericType.width(t);
            else if(VectorType.test(t))
                return (int)VectorType.width(t);
            else if(BlockedType.test(t))
                return (int)BlockedType.width(t);
            else if(t == typeof(bit))
                return (int)FixedWidth.W1;
            else
                return default;
        }

        public static Option<string> keyword(Type src)
        {
            if(src.IsSByte())
                return "sbyte";
            else if(src.IsByte())
                return "byte";
            else if(src.IsUInt16())
                return "ushort";
            else if(src.IsInt16())
                return "short";
            else if(src.IsInt32())
                return "int";
            else if(src.IsUInt32())
                return "uint";
            else if(src.IsInt64())
                return "long";
            else if(src.IsUInt64())
                return "ulong";
            else if(src.IsSingle())
                return "float";
            else if(src.IsDouble())
                return "double";
            else if(src.IsDecimal())
                return "decimal";
            else if(src.IsBool())
                return "bool";
            else if(src.IsChar())
                return "char";
            else if(src.IsString())
                return "string";
            else if(src.IsVoid())
                return "void";
            else 
                return default;
        }

    }

}
