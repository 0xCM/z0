//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;    
        
    using static zfunc;

    public readonly ref struct VBlock256<T>
        where T : unmanaged
    {
        readonly Block256<T> data;

        [MethodImpl(Inline)]
        public VBlock256(in Block256<T> src)
            => this.data = src;

        [MethodImpl(Inline)]
        public VBlock256(in ConstBlock256<T> src)
            => this.data = src.Replicate();

        [MethodImpl(Inline)]
        public static implicit operator VBlock256<T>(in Block256<T> src)
            =>  new VBlock256<T>(src);

        [MethodImpl(Inline)]
        public static implicit operator VBlock256<T>(in ConstBlock256<T> src)
            =>  new VBlock256<T>(src);

        [MethodImpl(Inline)]
        public static implicit operator Block256<T>(in VBlock256<T> src)
            =>  src.data;

        [MethodImpl(Inline)]
        public static implicit operator Span<T>(in VBlock256<T> src)
            =>  src.data;

        [MethodImpl(Inline)]
        public static implicit operator ReadOnlySpan<T>(in VBlock256<T> src)
            =>  src.Data.ReadOnly();

        [MethodImpl(Inline)]
        public static bool operator == (VBlock256<T> lhs, in VBlock256<T> rhs) 
            => lhs.Equals(rhs);

        [MethodImpl(Inline)]
        public static bool operator != (VBlock256<T> lhs, in VBlock256<T> rhs) 
            => !lhs.Equals(rhs);


        [MethodImpl(Inline)]
        public static T operator *(VBlock256<T> lhs, in VBlock256<T> rhs)
            => mathspan.dot<T>(lhs.Data.ReadOnly(), rhs.Data.ReadOnly());

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
        public VBlock256<U> As<U>()
            where U : unmanaged
                => data.As<U>();
                
        [MethodImpl(Inline)]
        public string Format(char delimiter = ',')
            => data.Data.FormatList(delimiter);    

        [MethodImpl(Inline)]
        public ref VBlock256<T> CopyTo(ref VBlock256<T> dst)
        {
            Unblocked.CopyTo(dst.Unblocked);
            return ref dst;
        }

        [MethodImpl(Inline)]
        public VBlock256<U> Convert<U>()
            where U : unmanaged
              => new VBlock256<U>(convert<T,U>(data));

        public VBlock256<T> Replicate(bool structureOnly = false)
            => new VBlock256<T>(data.Replicate(structureOnly));

        public bool Equals(VBlock256<T> rhs)
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