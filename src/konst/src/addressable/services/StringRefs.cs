//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;

    using static Konst;
    using static core;
    
    [ApiHost]
    public readonly struct StringRefs
    {
        [MethodImpl(Inline), Op]
        public static unsafe string format(StringRef src)
            => sys.@string(src.Address.Pointer<char>());

        [MethodImpl(Inline), Op]
        public static int length(StringRef src)
            => (int)(hi(src)/scale<char>());

        [MethodImpl(Inline), Op]
        static ulong lo(StringRef src)
            => core.vcell(src.Location, 0);

        [MethodImpl(Inline), Op]
        static ulong hi(StringRef src)
            => core.vcell(src.Location, 1);

        [MethodImpl(Inline), Op]
        public static unsafe StringRef create(string src)
            => new StringRef((ulong)pchar(src), src.Length);

        [MethodImpl(Inline)]
        public StringRef from(MemoryAddress address, int length)
            => new StringRef(address, length); 

        [MethodImpl(Inline), Op]
        public static StringRef from(MemRef src)
            => new StringRef(location(src));

        [MethodImpl(Inline), Op]
        public static StringRef from(Ref src)
            => new StringRef(location(src));

        public static string join(string delimiter, params StringRef[] refs)
        {
            var dst = text.build();
            var src = span(refs);
            var count = src.Length;
            
            for(var i=0u; i<count; i++)
            {
                var s = core.skip(src,i).Text;
                dst.Append(s);
                if(i != count - 1)
                    dst.Append(delimiter);                    
            }
            
            return dst.ToString();
        }

        [Op]
        public static void store(ReadOnlySpan<StringRef> src, Span<string> dst)
        {
            var count = src.Length;            
            for(var i=0u; i<count; i++)
                seek(dst,i) = skip(src,i);
        }


        [Op]
        public static void materialize(ReadOnlySpan<StringRef> src, Span<char> dst, char? delimiter = null)
        {
            var m = src.Length;
            var n = dst.Length;
            var o = 0u;
            for(var i=0u; i<m; i++)
            {
                var c = skip(src,i).Data;
                var p = c.Length;
                
                for(var j=0u; j<p && o<n; j++, o++)
                    seek(dst,o) = skip(c,j);
                
                if(delimiter != null)
                    seek(dst, ++o) = delimiter.Value;
            }    
        }

        [MethodImpl(Inline), Op]
        internal static Vector128<ulong> location(MemoryAddress address, int length)
            => vparts(N128.N, address, (ulong)(length*scale<char>()));
 
        [MethodImpl(Inline), Op]
        internal static Vector128<ulong> location(MemRef src)
            => vparts(N128.N, src.Address, (ulong)src.DataSize);

        [MethodImpl(Inline), Op]
        internal static Vector128<ulong> location(Ref src)
            => vparts(N128.N, src.Location, (ulong)src.DataSize); 
    }
}