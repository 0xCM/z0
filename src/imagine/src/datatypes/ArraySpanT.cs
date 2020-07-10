//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;    

    using static Konst;
    using static As;
    
    /// <summary>
    /// An array that works like a span, more-or-less
    /// </summary>
    public readonly struct ArraySpan<T> : ISpan<ArraySpan<T>,T>
        where T : struct
    {        
        internal readonly T[] Content;

        [MethodImpl(Inline)]
        public static implicit operator ArraySpan<T>(T[] src)
            => new ArraySpan<T>(src);
                
        public static bool operator ==(ArraySpan<T> lhs, ArraySpan<T> rhs)
            => lhs.Equals(rhs);

        public static bool operator !=(ArraySpan<T> lhs, ArraySpan<T> rhs)
            => !lhs.Equals(rhs);

        [MethodImpl(Inline)]
        public ArraySpan(params T[] data)   
            => Content = data;
        
        public int Length
        {
            [MethodImpl(Inline)]
            get => Content.Length;
        }

        public Span<T> Data
        {
            [MethodImpl(Inline)]
            get => Content;
        }

        public bool IsEmpty
        {
            [MethodImpl(Inline)]
            get => Content is null || Content.Length == 0;
        }

        public bool IsNonEmpty
        {
            [MethodImpl(Inline)]
            get => !IsEmpty;
        }

        public Span<T> Cells
        {
            [MethodImpl(Inline)]
            get => Content;
        }

        public ArraySpan<T> Zero
        {
            [MethodImpl(Inline)]
            get => Empty;
        }

        public static ArraySpan<T> Empty 
        {
            [MethodImpl(Inline)]
            get => new ArraySpan<T>();
        }

        public Span<byte> Bytes
        {
            [MethodImpl(Inline)]
            get => cast<T,byte>(Cells);
        }

        [MethodImpl(Inline)]
        public ref T Cell(int offset)
            => ref seek(Cells, (uint)offset);

        public ref T this[int index]
        {
            [MethodImpl(Inline)]
            get => ref Cell(index);
        }

        [MethodImpl(Inline)]
        public void Clear()
            => sys.clear(Cells);
        
        [MethodImpl(Inline)]
        public void Fill(T src)
            => sys.fill(src, Cells);
        
        [MethodImpl(Inline)]
        public void CopyTo(in ArraySpan<T> dst)
            => sys.copy(Cells, dst.Cells);
        
        [MethodImpl(Inline)]
        public Span<T> Slice(int offset)
            => Cells.Slice(offset);
    
        [MethodImpl(Inline)]
        public Span<T> Slice(int offset, int length)
            => Cells.Slice(offset, length);
        
        [MethodImpl(Inline)]
        public ArraySpan<T>.Enumerator GetEnumerator()
            => new Enumerator(this);

        [MethodImpl(Inline)]
        public bool Equals(ArraySpan<T> src)
            => Cells == src.Cells;

        [MethodImpl(Inline)]
        public ref T GetPinnableReference()       
            => ref Cells.GetPinnableReference();
        
        public override bool Equals(object src)
            => src is ArraySpan<T> x && Equals(x);

        public override int GetHashCode()
            => Content.GetHashCode();

        
        public struct Enumerator : ISpanEnumerator<Enumerator,T>
        {
            readonly ArraySpan<T> Data;

            int Pos;

            [MethodImpl(Inline)]
            public Enumerator(in ArraySpan<T> src)
            {
                Data = src;
                Pos = 0;
            }
            
            int LastPos
            {
                [MethodImpl(Inline)]
                get => Data.Length - 1;
            }

            public bool HasNext
            {
                [MethodImpl(Inline)]
                get => Pos != -1 && Pos != LastPos;
            }
            
            public ref T Current 
            {
                [MethodImpl(Inline)]
                get => ref Data[Pos];
            }

            [MethodImpl(Inline)]
            public bool MoveNext()
            {
                if(Pos < LastPos)
                {
                    Pos++;
                    return true;
                }
                else
                {
                    Pos = -1;
                    return false;
                }
            }
        }
    }
}