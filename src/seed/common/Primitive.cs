//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    using PK = PrimalKind;

    partial class XTend
    {

        [MethodImpl(Inline)]
        public static PrimalKind PrimalKind(this Type src)
            => Primitive.kind(src);
    
        [MethodImpl(Inline)]
        public static bool IsPrimalKind(this Type src)
            => Primitive.kind(src) != 0;    

        [MethodImpl(Inline)]
        public static bool IsLiteralKind(this PrimalKind src)
            => Primitive.literal(src);
    }

    
    [ApiHost]
    public readonly struct Primitive
    {
        /// <summary>
        /// Returns the type-code identified primal kind
        /// </summary>
        /// <param name="src">The type code</param>
        [MethodImpl(Inline), Op]
        public static PrimalKind kind(TypeCode src)
            => Root.skip(Kinds,(int)src);

        [MethodImpl(Inline), Op]
        public static PrimalKind kind(Type src)
            => kind(Type.GetTypeCode(src));

        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public static PrimalKind kind<T>()
            => kind(typeof(T));
        
        [MethodImpl(Inline), Op]
        public static BitSize width(Type src)
            => kind(src).BitField().Width;

        [MethodImpl(Inline), Op]
        public static ByteSize size(Type src)
            => kind(src).BitField().Size;

        [MethodImpl(Inline), Op]
        public static bool literal(PrimalKind src)
            => ((byte)src > 2 && (byte)src<16) || (byte)src == 18;

        /// <summary>
        /// Determines the literal kind of a type, if any
        /// </summary>
        /// <param name="src">The source type</param>
        [MethodImpl(Inline), Op]
        public static PrimalLiteralKind literal(Type src)
        {
            var i = index(src);
            var test = (i > 2 && i <16) || i == 18;
            return test ? (PrimalLiteralKind)Root.skip(PrimalKindData,i) : PrimalLiteralKind.None;            
        }

        static ReadOnlySpan<PrimalKind> Kinds
        {
            [MethodImpl(Inline)]
            get => Root.cast<PrimalKind>(PrimalKindData);
        }

        [MethodImpl(Inline), Op]
        static byte index(Type src)
            => (byte)Type.GetTypeCode(src);

        //PrimalKindId|TypeCode -> PrimalKind                
        static ReadOnlySpan<byte> PrimalKindData => new byte[19]{
            (byte)PK.None, //0:Empty/null
            (byte)PK.Object, //1:Object
            (byte)PK.DBNull, //2:DbNull
            (byte)PK.U1, //3:Bool
            (byte)PK.C16, //4:char
            (byte)PK.I8, //5:int8
            (byte)PK.U8, //6:uint8
            (byte)PK.I16, //7:short
            (byte)PK.U16, //8:ushort
            (byte)PK.I32, //9:int32
            (byte)PK.U32, //10:uint32
            (byte)PK.I64, //11:int64
            (byte)PK.U64, //12:uint64
            (byte)PK.F32, //13:float32
            (byte)PK.F64, //14:float64
            (byte)PK.F128, //15:decimal
            (byte)PK.DateTime, //16:datetime
            (byte)PK.None, // 17:empty
            (byte)PK.String //18:string            
        };
    }
}