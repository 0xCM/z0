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

    using static Root;
    using static Nats;
    using VT = Z0.VectorType;

    public interface ISurrogate<S,T>
        where S : struct, ISurrogate<S,T>
    {
        T Subject {get;}
    }
    
    public static partial class VectorSurrogates
    {
        public interface IVec : ICustomFormattable
        {
            Type VectorType {get;}

            Type CellType {get;}

            Type ContainerType {get;}

            VectorKind Kind {get;}

            NumericKind CellKind {get;}

            FixedWidth Width {get;}

            IVec Convert(NumericKind dst);
        }


        public interface IVec<S,V,T> : IVec, ISurrogate<S,V>, IFormattable<S>, IEquatable<S>, INullary<S>
            where S : struct, IVec<S,V,T>
            where V : unmanaged
            where T : unmanaged
        {
            S New(in V src);   
        }

        public interface IVec128 : IVec
        {
            FixedWidth IVec.Width 
                => FixedWidth.W128;

            Vector128<T> Vector<T>()
                where T : unmanaged;

            new IVec128 Convert(NumericKind dst);
        }
        
        public interface IVec128<T> : IVec128
            where T : unmanaged
        {
            Type IVec.VectorType => typeof(Vector128<T>);

            VectorKind IVec.Kind 
                => VT.kind(typeof(Vector128<T>));

            Type IVec.CellType 
                => typeof(T);

            NumericKind IVec.CellKind 
                => typeof(T).NumericKind();      

            IVec IVec.Convert(NumericKind dst)
                => VectorSurrogates.Convert(this, dst);
            
            IVec128 IVec128.Convert(NumericKind dst)
                => VectorSurrogates.Convert(this, dst);
        }

        public interface IV128<S,T> : IVec128<T>, IVec<S, Vector128<T>, T>, IFormattable<S>
            where T : unmanaged
            where S : struct, IV128<S,T>
        {
            Type IVec.ContainerType => typeof(S);
            string ICustomFormattable.Format()
                => Subject.FormatAsList();

            [MethodImpl(Inline)]
            bool IEquatable<S>.Equals(S src)          
                => src.Subject.Equals(src.Subject);

            [MethodImpl(Inline)]
            Vector128<U> IVec128.Vector<U>()
                => Subject.As<T,U>();

            S INullary<S>.Zero
                => default;
            
            bool INullary<S>.IsEmpty
                => this.Equals(default);

            X Convert<X,U>(X model = default, U t = default)
                where X : struct, IV128<X,U>
                where U : unmanaged;
        }

        public interface IVec256 : IVec
        {
            FixedWidth IVec.Width 
                => FixedWidth.W256;

            Vector256<T> ToVector<T>()
                where T : unmanaged;

            IVec IVec.Convert(NumericKind dst)
                => default;

        }

        public interface IVec256<T> : IVec256
            where T : unmanaged
        {
            Type IVec.VectorType => typeof(Vector256<T>);

            VectorKind IVec.Kind 
                => VT.kind(typeof(Vector256<T>));

            Type IVec.CellType 
                => typeof(T);

            NumericKind IVec.CellKind 
                => typeof(T).NumericKind();      
        }

        public interface IV256<S,T> : IVec256<T>, IVec<S, Vector256<T>, T>, IFormattable<S>
            where T : unmanaged
            where S : struct, IV256<S,T>
        {
            Type IVec.VectorType => typeof(Vector256<T>);

            Type IVec.ContainerType => typeof(S);

            string ICustomFormattable.Format()
                => Subject.Format();

            [MethodImpl(Inline)]
            bool IEquatable<S>.Equals(S src)          
                => src.Subject.Equals(src.Subject);

            [MethodImpl(Inline)]
            Vector256<U> IVec256.ToVector<U>()
                =>  Subject.As<T,U>();

            S INullary<S>.Zero
                => default;

            bool INullary<S>.IsEmpty
                => this.Equals(default);            
        }
    }
}