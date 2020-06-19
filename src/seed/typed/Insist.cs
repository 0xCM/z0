//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
 
     public readonly struct Insist : IInsist
     {
        public static Insist Service => default(Insist);

        public void insist(bool invariant)
        {
            if(!invariant)
                throw new Exception($"Application invaraiant failed");
        }

        public void insist(bool invariant, string msg)
        {
            if(!invariant)
                throw new Exception($"Application invaraiant failed: {msg}");
        }

        [MethodImpl(Inline)]
        public void insist<N>(ulong src)
            where N : unmanaged, ITypeNat
                => insist(Typed.value<N>() == src, $"The source value {src} does not match the required natural value {Typed.value<N>()}");        

        [MethodImpl(Inline)]
        public void insist<N>(int src)
            where N : unmanaged, ITypeNat
                => insist<N>((ulong)src);
    
        [MethodImpl(Inline)]
        public T insist<T>(T src)
            where T : class
        {
            insist(src != null);
            return src;
        }

        [MethodImpl(Inline)]
        public T insist<T>(T src, Func<T,bool> f)
        {
            insist(f(src));
            return src;
        }
        
        [MethodImpl(Inline)]
        public T insist<T>(T? src)
            where T : struct
        {
            insist(src.HasValue);
            return src.Value;
        }

        [MethodImpl(Inline)]
        public T insist<T>(Option<T> src)
        {
            insist(src.IsSome());
            return src.Value;
        }        

        [MethodImpl(Inline)]
        public T insist<T>(T lhs, T rhs)
            where T : IEquatable<T>            
        {
            if(Control.nullnot(lhs) && Control.nullnot(rhs) && lhs.Equals(rhs))
                return lhs;
            else
                insist(false, $"{lhs} != {rhs}");
            
            return default;
        }
    }
    
    public interface IInsist
    {
        /// <summary>
        /// Demands mystery invariant satisfaction
        /// </summary>
        /// <param name="invariant">The mystery invariant</param>
        [MethodImpl(Inline)]
        void insist(bool invariant)
            => Insist.Service.insist(invariant);

        /// <summary>
        /// Demands mystery invariant satisfaction, but with an attendant message 
        /// that, hopefully, expounds the mystery
        /// </summary>
        /// <param name="invariant">The mystery invariant</param>
        /// <param name="msg">The mystery, expounded, hopefully</param>
        [MethodImpl(Inline)]
        void insist(bool invariant, string msg)
            => Insist.Service.insist(invariant,msg);

        /// <summary>
        /// Demands that a numeric value matches the value of parametric type natural
        /// </summary>
        /// <param name="src">The numeric source value</param>
        /// <typeparam name="N">The natural type</typeparam>
        [MethodImpl(Inline)]
        void insist<N>(ulong src)
            where N : unmanaged, ITypeNat
                => Insist.Service.insist<N>(src);

        /// <summary>
        /// Demands that a numeric value matches the value of parametric type natural, because .Net is hooked on int32
        /// </summary>
        /// <param name="src">The numeric source value</param>
        /// <typeparam name="N">The natural type</typeparam>
        [MethodImpl(Inline)]
        void insist<N>(int src)
            where N : unmanaged, ITypeNat
                => Insist.Service.insist<N>(src);
    
        /// <summary>
        /// Demands that a reference type value is non-null
        /// </summary>
        /// <param name="src">The value to test</param>
        /// <typeparam name="T">The value type</typeparam>
        [MethodImpl(Inline)]
        T insist<T>(T src)
            where T : class
                => Insist.Service.insist(src);

        /// <summary>
        /// Demands that a value satisfies a predicate
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="f">The predicate to evaluate over the source</param>
        /// <typeparam name="T">The source value type</typeparam>
        [MethodImpl(Inline)]
        T insist<T>(T src, Func<T,bool> f)
            => Insist.Service.insist(src,f);
        
        /// <summary>
        /// Demands that a nullable value type value is non-null
        /// </summary>
        /// <param name="src">The value to test</param>
        /// <typeparam name="T">The value type</typeparam>
        [MethodImpl(Inline)]
        T insist<T>(T? src)
            where T : struct
                => Insist.Service.insist(src);

        /// <summary>
        /// Demands that an option has a value
        /// </summary>
        /// <param name="src">The potential value</param>
        /// <typeparam name="T">The value type, should it exist</typeparam>
        [MethodImpl(Inline)]
        T insist<T>(Option<T> src)
            => Insist.Service.insist(src);

        /// <summary>
        /// Demands operand equality
        /// </summary>
        /// <param name="lhs">The left operand</param>
        /// <param name="lhs">The right operand</param>
        /// <typeparam name="T">The value type, should it exist</typeparam>
        [MethodImpl(Inline)]
        T insist<T>(T lhs, T rhs)
            where T : IEquatable<T>            
                 => Insist.Service.insist(lhs,rhs);
    }   
}