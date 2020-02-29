//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    
    using static Root;
    using static P2K;

    public static class CharStacks
    {
        /// <summary>
        /// Queries/manipulates a index-identified character in a storage stack
        /// </summary>
        /// <param name="src">The character storage</param>
        /// <param name="index">The character index</param>
        [MethodImpl(Inline)]
        public static ref char @char(ref CharStack2 src, int index)
            => ref Unsafe.Add(ref chead(ref src), index);

        /// <summary>
        /// Queries/manipulates a index-identified character in a storage stack
        /// </summary>
        /// <param name="src">The character storage</param>
        /// <param name="index">The character index</param>
        [MethodImpl(Inline)]
        public static ref char @char(ref CharStack4 src, int index)
            => ref Unsafe.Add(ref chead(ref src), index);

        /// <summary>
        /// Queries/manipulates a index-identified character in a storage stack
        /// </summary>
        /// <param name="src">The character storage</param>
        /// <param name="index">The character index</param>
        [MethodImpl(Inline)]
        public static ref char @char(ref CharStack8 src, int index)
            => ref Unsafe.Add(ref chead(ref src), index);

        /// <summary>
        /// Queries/manipulates a index-identified character in a storage stack
        /// </summary>
        /// <param name="src">The character storage</param>
        /// <param name="index">The character index</param>
        [MethodImpl(Inline)]
        public static ref char @char(ref CharStack16 src, int index)
            => ref Unsafe.Add(ref chead(ref src), index);

        /// <summary>
        /// Queries/manipulates a index-identified character in a storage stack
        /// </summary>
        /// <param name="src">The character storage</param>
        /// <param name="index">The character index</param>
        [MethodImpl(Inline)]
        public static ref char @char(ref CharStack32 src, int index)
            => ref Unsafe.Add(ref chead(ref src), index);

        /// <summary>
        /// Queries/manipulates a index-identified character in a storage stack
        /// </summary>
        /// <param name="src">The character storage</param>
        /// <param name="index">The character index</param>
        [MethodImpl(Inline)]
        public static ref char @char(ref CharStack64 src, int index)
            => ref Unsafe.Add(ref chead(ref src), index);
         
        /// <summary>
        /// Retrieves a reference to the leading character storage cell
        /// </summary>
        /// <param name="src">The character storage source</param>
        [MethodImpl(Inline)]
        public static ref char chead(ref CharStack2 src)
            => ref src.C0;

        /// <summary>
        /// Retrieves a readonly reference to the leading character storage cell
        /// </summary>
        /// <param name="src">The character storage source</param>
        [MethodImpl(Inline)]
        public static ref readonly char first(in CharStack2 src)
            => ref src.C0;

        /// <summary>
        /// Retrieves a reference to the leading character storage cell
        /// </summary>
        /// <param name="src">The character storage source</param>
        [MethodImpl(Inline)]
        public static ref char chead(ref CharStack4 src)
            => ref chead(ref src.C0);

        /// <summary>
        /// Retrieves a readonly reference to the leading character storage cell
        /// </summary>
        /// <param name="src">The character storage source</param>
        [MethodImpl(Inline)]
        public static ref readonly char first(in CharStack4 src)
            => ref first(in src.C0);

        /// <summary>
        /// Retrieves a reference to the leading character storage cell
        /// </summary>
        /// <param name="src">The character storage source</param>
        [MethodImpl(Inline)]
        public static ref char chead(ref CharStack8 src)
            => ref chead(ref src.C0);

        /// <summary>
        /// Retrieves a readonly reference to the leading character storage cell
        /// </summary>
        /// <param name="src">The character storage source</param>
        [MethodImpl(Inline)]
        public static ref readonly char first(in CharStack8 src)
            => ref first(in src.C0);

        /// <summary>
        /// Retrieves a reference to the leading character storage cell
        /// </summary>
        /// <param name="src">The character storage source</param>
        [MethodImpl(Inline)]
        public static ref char chead(ref CharStack16 src)
            => ref chead(ref src.C0);

        /// <summary>
        /// Retrieves a readonly reference to the leading character storage cell
        /// </summary>
        /// <param name="src">The character storage source</param>
        [MethodImpl(Inline)]
        public static ref readonly char first(in CharStack16 src)
            => ref first(in src.C0);

        /// <summary>
        /// Retrieves a reference to the leading character storage cell
        /// </summary>
        /// <param name="src">The character storage source</param>
        [MethodImpl(Inline)]
        public static ref char chead(ref CharStack32 src)
            => ref chead(ref src.C0);

        /// <summary>
        /// Retrieves a readonly reference to the leading character storage cell
        /// </summary>
        /// <param name="src">The character storage source</param>
        [MethodImpl(Inline)]
        public static ref readonly char first(in CharStack32 src)
            => ref first(in src.C0);

        /// <summary>
        /// Retrieves a reference to the leading character storage cell
        /// </summary>
        /// <param name="src">The character storage source</param>
        [MethodImpl(Inline)]
        public static ref char chead(ref CharStack64 src)
            => ref chead(ref src.C0);

        /// <summary>
        /// Retrieves a readonly reference to the leading character storage cell
        /// </summary>
        /// <param name="src">The character storage source</param>
        [MethodImpl(Inline)]
        public static ref readonly char first(in CharStack64 src)
            => ref first(in src.C0);

       /// <summary>
       /// Allocates a 2-character storage stack
       /// </summary>
       [MethodImpl(Inline)]
       public static CharStack2 chars(P2x1 p2)
            => default;

        /// <summary>
        /// Allocates a 4-character storage stack
        /// </summary>
        [MethodImpl(Inline)]
        public static CharStack4 chars(P2x2 p2)
            => default;

        /// <summary>
        /// Allocates an 8-character storage stack
        /// </summary>
        [MethodImpl(Inline)]
        public static CharStack8 chars(P2x3 p2)
            => default;

        /// <summary>
        /// Allocates a 16-character storage stack
        /// </summary>
        [MethodImpl(Inline)]
        public static CharStack16 chars(P2x4 p2)
            => default;

        /// <summary>
        /// Allocates a 32-character storage stack
        /// </summary>
        [MethodImpl(Inline)]
        public static CharStack32 chars(P2x5 p2)
            => default;

        /// <summary>
        /// Allocates a 64-character storage stack
        /// </summary>
        [MethodImpl(Inline)]
        public static CharStack64 chars(P2x6 p2)
            => default;

        [MethodImpl(Inline)]
        public static unsafe CharStack4 concat(in CharStack2 head, in CharStack2 tail)
        {
            const int block = 2;
            var dst = chars(p2x2);
            PolyData.copy(in first(in head), ref chead(ref dst), block);
            PolyData.copy(in first(in tail), ref seek(ref chead(ref dst),block), block);            
            return dst;
        }

        [MethodImpl(Inline)]
        public static CharStack8 concat(in CharStack4 head, in CharStack4 tail)
        {
            const int block = 4;
            var dst = chars(p2x3);
            PolyData.copy(in first(in head), ref chead(ref dst), block);
            PolyData.copy(in first(in tail), ref seek(ref chead(ref dst), block), block);            
            return dst;
        }

        [MethodImpl(Inline)]
        public static CharStack16 concat(in CharStack8 head, in CharStack8 tail)
        {
            const int block = 8;
            var dst = chars(p2x4);
            PolyData.copy(in first(in head), ref chead(ref dst), block);
            PolyData.copy(in first(in tail), ref seek(ref chead(ref dst),block), block);            
            return dst;
        }

        [MethodImpl(Inline)]
        public static ref CharStack32 concat(in CharStack16 head, in CharStack16 tail, ref CharStack32 dst)
        {
            const int block = 16;
            PolyData.copy(in first(in head), ref chead(ref dst), block);
            PolyData.copy(in first(in tail), ref seek(ref chead(ref dst),block), block);            
            return ref dst;
        }

        [MethodImpl(Inline)]
        public static CharStack32 concat(in CharStack16 head, in CharStack16 tail)
        {
            const int block = 16;
            var dst = chars(p2x5);
            return concat(head,tail,ref dst);
        }

        [MethodImpl(Inline)]
        public static ref CharStack64 concat(in CharStack32 head, in CharStack32 tail, ref CharStack64 dst)
        {
            const int block = 32;
            PolyData.copy(in first(in head), ref chead(ref dst), block);
            PolyData.copy(in first(in tail), ref seek(ref chead(ref dst),block), block);            
            return ref dst;
        }

        [MethodImpl(Inline)]
        public static CharStack64 concat(in CharStack32 head, in CharStack32 tail)
        {
            const int block = 32;
            var dst = chars(p2x6);
            return concat(head,tail,ref dst);
        }
 
         [MethodImpl(Inline)]
        public static Span<char> charspan(ref CharStack2 src)
            => MemoryMarshal.CreateSpan(ref chead(ref src), 2);

        [MethodImpl(Inline)]
        public static Span<char> charspan(ref CharStack4 src)
            => MemoryMarshal.CreateSpan(ref chead(ref src), 4);

        [MethodImpl(Inline)]
        public static Span<char> charspan(ref CharStack8 src)
            => MemoryMarshal.CreateSpan(ref chead(ref src), 8);

        [MethodImpl(Inline)]
        public static Span<char> charspan(ref CharStack16 src)
            => MemoryMarshal.CreateSpan(ref chead(ref src), 16);

        [MethodImpl(Inline)]
        public static Span<char> charspan(ref CharStack32 src)
            => MemoryMarshal.CreateSpan(ref chead(ref src), 32);

        [MethodImpl(Inline)]
        public static Span<char> charspan(ref CharStack64 src)
            => MemoryMarshal.CreateSpan(ref chead(ref src), 64);

        public ref struct CharStack2
        {
            public char C0;

            char C1;

        }

        public ref struct CharStack4
        {
            public CharStack2 C0;

            CharStack2 C1;
        }

        public ref struct CharStack8
        {
            public CharStack4 C0;

            CharStack4 C1;
        }

        public ref struct CharStack16
        {
            public CharStack8 C0;

            CharStack8 C1;        
        }

        public ref struct CharStack32
        {
            public CharStack16 C0;

            CharStack16 C1;        
        }

        public ref struct CharStack64
        {
            public CharStack32 C0;

            CharStack32 C1;       
        }
    }
}