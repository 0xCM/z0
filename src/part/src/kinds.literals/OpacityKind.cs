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

        Root = ApiKeyId.Opaque,

        First = Root + 1,

        UnboxObject = First,

        UnboxEnum,

        CreateString,

        Alloc,

        AllocSpan,

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

        EnumerableToArray,

        EnumerableToSpan,

        Throw,

        GetFieldConstant,

        GetTypeFields,

        GetTypeProperties,

        GetTypeMethods,

        GetEnumerator,

       MoveNext,

       Current,

       GetEmptyArray,

       GetEnumNames,

      GetEnumValues,

      FormatCharSpan,

      GetEntryAssembly,

      GetCallingAssembly,

      GetFieldValue
    }
}