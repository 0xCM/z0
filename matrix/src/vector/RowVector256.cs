//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;    
        
    using static Root;

    public readonly ref struct RowVector256<T>
        where T : unmanaged
    {
        readonly Block256<T> data;

        [MethodImpl(Inline)]
        public RowVector256(in Block256<T> src)
            => this.data = src;


        [MethodImpl(Inline)]
        public static implicit operator RowVector256<T>(in Block256<T> src)
            =>  new RowVector256<T>(src);


        [MethodImpl(Inline)]
        public static implicit operator Block256<T>(in RowVector256<T> src)
            =>  src.data;

        [MethodImpl(Inline)]
        public static implicit operator Span<T>(in RowVector256<T> src)
            =>  src.data;

        [MethodImpl(Inline)]
        public static implicit operator ReadOnlySpan<T>(in RowVector256<T> src)
            =>  src.Data;

        [MethodImpl(Inline)]
        public static bool operator == (RowVector256<T> lhs, in RowVector256<T> rhs) 
            => lhs.Equals(rhs);

        [MethodImpl(Inline)]
        public static bool operator != (RowVector256<T> lhs, in RowVector256<T> rhs) 
            => !lhs.Equals(rhs);


        [MethodImpl(Inline)]
        public static T operator *(RowVector256<T> lhs, in RowVector256<T> rhs)
            => mathspan.dot<T>(lhs.Data, rhs.Data);

        public ref T this[int i]
        {
            [MethodImpl(Inline)]
            get => ref data[i];            
        }

        public int Count
        {
            [MethodImpl(Inline)]
            get => data.CellCount;            
        }

        public int Length
        {
            [MethodImpl(Inline)]
            get => data.CellCount;
        }

        public Span<T> Unblocked
        {
            [MethodImpl(Inline)]
            get => data;
        }

        public Block256<T> Data
        {
            [MethodImpl(Inline)]
            get => data;
        }

        [MethodImpl(Inline)]
        public RowVector256<U> As<U>()
            where U : unmanaged
                => data.As<U>();
                
        [MethodImpl(Inline)]
        public string Format(char delimiter = ',')
            => data.Data.FormatDataList(delimiter);    

        [MethodImpl(Inline)]
        public ref RowVector256<T> CopyTo(ref RowVector256<T> dst)
        {
            Unblocked.CopyTo(dst.Unblocked);
            return ref dst;
        }

        [MethodImpl(Inline)]
        public RowVector256<U> Convert<U>()
            where U : unmanaged
              => new RowVector256<U>(blocks.convert<T,U>(data));

        public RowVector256<T> Replicate()
            => new RowVector256<T>(data.Replicate());

        public bool Equals(RowVector256<T> rhs)
        {
            var lhsData = Unblocked;
            var rhsData = rhs.Unblocked;
            if(lhsData.Length != rhsData.Length)
                return false;
            for(var i = 0; i<lhsData.Length; i++)
                if(gmath.neq(lhsData[i], rhsData[i]))
                    return false;
            return true;
        }

        public override bool Equals(object rhs)
            => throw new NotSupportedException();

        public override int GetHashCode()
            => throw new NotSupportedException(); 
    }
}