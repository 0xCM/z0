//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    public enum OpacityKind : ulong
    {
        None = 0,

        Closure = NumericKind.All,
        
        Root = OpKindId.Opaque,

        First = Root + 1,

        UnboxObject = First,

        UnboxEnum,

        CreateString,

        Alloc,
        
        Equals,

        GetInstanceType,

        GetGenericType,

        GetTypeCode,

        GetGenericTypeCode,

        Write,

        Copy,

        CopyBlock,

        GetTypeHandle,

        GetGenericTypeHandle,

        StringToCharSpan,

        CharSpanToString,

        CharPointerToString,

        ClearSpan,

        SpanToArray,

        ParameterArray,

        InitRefBlock,       

        FillSpan,

        CopyCellToVoidPointer,

        CopyCellToGenericPointer,

        CopySpan,

        EmptyStringTest,

        ArrayToList,

       ListToArray,

        Throw,

    }
}