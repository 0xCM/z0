//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Reflection;

    using static Part;
    using static memory;

    partial struct Resources
    {
        /// <summary>
        /// Loades the corresponding method definitions
        /// </summary>
        /// <param name="src"></param>
        /// <remarks>
        /// Each method is 29 bytes in length and similar to:
        /// 0000h nop dword ptr [rax+rax]        ; NOP r/m32           | 0F 1F /0        | 5   | 0f 1f 44 00 00
        /// 0005h mov rax,228ab7d8e44h           ; MOV r64, imm64      | REX.W B8+ro io  | 10  | 48 b8 44 8e 7d ab 28 02 00 00
        /// 000fh mov [rcx],rax                  ; MOV r/m64, r64      | REX.W 89 /r     | 3   | 48 89 01
        /// 0012h mov dword ptr [rcx+8],91h      ; MOV r/m32, imm32    | C7 /0 id        | 7   | c7 41 08 91 00 00 00
        /// 0019h mov rax,rcx                    ; MOV r64, r/m64      | REX.W 8B /r     | 3   | 48 8b c1
        /// 001ch ret                            ; RET                 | C3              | 1   | c3
        /// </remarks>
        [Op]
        public static unsafe SpanBlock256<byte> definitions(ReadOnlySpan<ApiResAccessor> src)
        {
            var count = src.Length;
            var blocks = SpanBlocks.alloc<byte>(w256,count);
            for(var i=0; i<count; i++)
            {
                var offset = i*32;
                ref readonly var accessor = ref skip(src,i);
                var pMethod = accessor.Member.MethodHandle.GetFunctionPointer().ToPointer<byte>();
                var reader = memory.reader(pMethod, 29);
                reader.ReadAll(blocks.Block(i));
            }

            return blocks;
        }

        [Op]
        public static unsafe ApiRes resource(ApiResAccessor src)
        {
            var pMethod = src.Member.MethodHandle.GetFunctionPointer().ToPointer<byte>();
            var storage = MemoryStacks.alloc(w256);
            var buffer = MemoryStacks.span<byte>(ref storage);
            var reader = memory.reader(pMethod, 29);
            reader.ReadAll(buffer);
            var address = slice(buffer,8,8).TakeUInt64();
            var size = slice(buffer,22,4).TakeUInt32();
            return new ApiRes(src, address, size);
        }

        /// <summary>
        /// Queries the source assemblies for ByteSpan property getters
        /// </summary>
        /// <param name="src">The assemblies to query</param>
        [Op]
        public static Index<ApiResAccessor> accessors(Assembly[] src)
            => accessors(src.SelectMany(x => x.GetTypes()));

        /// <summary>
        /// Queries the source assembly for ByteSpan property getters
        /// </summary>
        /// <param name="src">The assembly to query</param>
        [MethodImpl(Inline), Op]
        public static Index<ApiResAccessor> accessors(Assembly src)
            => accessors(src.GetTypes());

        /// <summary>
        /// Queries the source types for ByteSpan property getters
        /// </summary>
        /// <param name="src">The types to query</param>
        [Op]
        public static Index<ApiResAccessor> accessors(Type[] src)
            => src.Where(t => !t.IsInterface).SelectMany(x => accessors(x));

        /// <summary>
        /// Queries the source types for ByteSpan property getters
        /// </summary>
        /// <param name="src">The types to query</param>
        [Op]
        public static Index<ApiResAccessor> accessors(Index<Type> src)
            => src.Where(t => !t.IsInterface).SelectMany(accessors).Array();

        /// <summary>
        /// Queries the source type for ByteSpan property getters
        /// </summary>
        /// <param name="src">The type to query</param>
        [Op]
        public static Index<ApiResAccessor> accessors(Type src)
            => src.StaticProperties()
                 .Ignore()
                  .WithPropertyType(ResAccessorTypes)
                  .Select(p => p.GetGetMethod(true))
                  .Where(m  => m != null)
                  .Concrete()
                  .Select(x => new ApiResAccessor(ApiQuery.uri(src), x, ApiAccessorKind(x.ReturnType)));

        static Type[] ResAccessorTypes
            => new Type[]{ByteSpanAcessorType, CharSpanAcessorType};

        static Type ByteSpanAcessorType
            => typeof(ReadOnlySpan<byte>);

        static Type CharSpanAcessorType
            => typeof(ReadOnlySpan<char>);

        [Op]
        static ApiResKind ApiAccessorKind(Type match)
        {
            ref readonly var src = ref first(span(ResAccessorTypes));
            var kind = ApiResKind.None;
            if(skip(src,0).Equals(match))
                kind = ApiResKind.ByteSpan;
            else if(skip(src,1).Equals(match))
                kind = ApiResKind.CharSpan;
            return kind;
        }
    }
}