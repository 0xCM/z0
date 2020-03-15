//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Reflection;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;
    using System.Runtime.InteropServices;
    using System.Collections.Generic;
    using System.Linq;

    using static Z0.Root;

    public static partial class VectorSurrogates
    {
        [MethodImpl(Inline)]
        public static V128<T> define<T>(Vector128<T> src)
            where T : unmanaged
                => new V128<T>(src);
        
        [MethodImpl(Inline)]
        public static V128x8u define(Vector128<byte> src)
            => new V128x8u(src);

        [MethodImpl(Inline)]
        public static V128x8i define(Vector128<sbyte> src)
            => new V128x8i(src);

        [MethodImpl(Inline)]
        public static V128x16i define(Vector128<short> src)
            => new V128x16i(src);

        [MethodImpl(Inline)]
        public static V128x16u define(Vector128<ushort> src)
            => new V128x16u(src);

        [MethodImpl(Inline)]
        public static V128x32i define(Vector128<int> src)
            => new V128x32i(src);

        [MethodImpl(Inline)]
        public static V128x32u define(Vector128<uint> src)
            => new V128x32u(src);

        [MethodImpl(Inline)]
        public static V128x64i define(Vector128<long> src)
            => new V128x64i(src);

        [MethodImpl(Inline)]
        public static V128x64u define(Vector128<ulong> src)
            => new V128x64u(src);

        [MethodImpl(Inline)]
        public static V256<T> define<T>(Vector256<T> src)
            where T : unmanaged
                => new V256<T>(src);

        [MethodImpl(Inline)]
        public static V128x8u v8u<T>(Vector128<T> src)
            where T : unmanaged
                => new V128x8u(vgeneric.v8u(src));

        [MethodImpl(Inline)]
        public static V128x8i v8i<T>(Vector128<T> src)
            where T : unmanaged
                => new V128x8i(vgeneric.v8i(src));
        
        [MethodImpl(Inline)]
        public static V128x16i v16i<T>(Vector128<T> src)
            where T : unmanaged
                => new V128x16i(vgeneric.v16i(src));

        [MethodImpl(Inline)]
        public static V128x16u v16u<T>(Vector128<T> src)
            where T : unmanaged
                => new V128x16u(vgeneric.v16u(src));

        [MethodImpl(Inline)]
        public static V128x32i v32i<T>(Vector128<T> src)
            where T : unmanaged
                => new V128x32i(vgeneric.v32i(src));

        [MethodImpl(Inline)]
        public static V128x32u v32u<T>(Vector128<T> src)
            where T : unmanaged
                => new V128x32u(vgeneric.v32u(src));

        [MethodImpl(Inline)]
        public static V128x64i v64i<T>(Vector128<T> src)
            where T : unmanaged
                => new V128x64i(vgeneric.v64i(src));

        [MethodImpl(Inline)]
        public static V128x64u v64u<T>(Vector128<T> src)
            where T : unmanaged
                => new V128x64u(vgeneric.v64u(src));

        public static IEnumerable<V128<T>> stream<T>(IEnumerable<Vector128<T>> src)
            where T : unmanaged
                => src.Select(define);

        public static IEnumerable<V256<T>> stream<T>(IEnumerable<Vector256<T>> src)
            where T : unmanaged
                => src.Select(define);        

        public static IVec128 Convert<T>(IVec128<T> src, NumericKind dst)
            where T : unmanaged
                => dst switch{
                    NumericKind.U8 => v8u(src.Vector<T>()),
                    NumericKind.I8 => v8i(src.Vector<T>()),
                    NumericKind.U16 => v16i(src.Vector<T>()),
                    NumericKind.I16 => v16u(src.Vector<T>()),
                    NumericKind.U32 => v32i(src.Vector<T>()),
                    NumericKind.I32 => v32u(src.Vector<T>()),
                    NumericKind.U64 => v64i(src.Vector<T>()),
                    NumericKind.I64 => v64u(src.Vector<T>()),
                    _ => src,
                };
    }
}