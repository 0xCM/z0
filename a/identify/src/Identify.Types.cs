//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Seed;
    
    partial class Identify
    {
        /// <summary>
        /// Defines a scalar type identity
        /// </summary>
        /// <param name="width">The scalar bit-width</param>
        [MethodImpl(Inline)]
        public static NumericIdentity Numeric(NumericKind nk)
            => NumericIdentity.Define(nk);

        /// <summary>
        /// Defines a segmented type identity predicated on type width numeric kind specifications
        /// </summary>
        /// <param name="name">The type name</param>
        /// <param name="wk">The width kind</param>
        /// <param name="nk">The numeric kind</param>
        [MethodImpl(Inline)]
        public static TypeIdentity Segmented(string name, TypeWidth wk, NumericKind nk)
            => TypeIdentity.Define($"{name}{wk.Format()}x{nk.Format()}");

        public static TypeIdentity NumericClosure(string root, Type arg)
        {
            var kind = arg.NumericKind();
            var indicator = kind.Indicator().ToChar();
            var width = kind.Width();
            return TypeIdentity.Define($"{root}{width}{indicator}");
        }

        /// <summary>
        /// Produces the formatted identifier of the declaring assembly
        /// </summary>
        /// <param name="host">The source type</param>
        [MethodImpl(Inline)]   
        public static string Owner(Type host)
            => host.Assembly.Id().Format();

        /// <summary>
        /// Produces an identifier of the form {bitsize[T]}{u | i | f} for a numeric type
        /// </summary>
        /// <param name="t">A primal type representative</param>
        /// <typeparam name="T">The primal type</typeparam>
        [MethodImpl(Inline)]   
        public static TypeIdentity NumericType<T>(T t = default)
            where T : unmanaged
                => TypeIdentity.Define(typeof(T).NumericKind().Format());

        /// <summary>
        /// 
        /// </summary>
        /// <param name="basename">The base name of the resource</param>
        /// <param name="w">The resource bit width</param>
        /// <param name="kind">The numeric kind of the resource</param>
        [MethodImpl(Inline)]
        public static TypeIdentity Resource(string basename, ITypeWidth w, NumericKind kind)
            => TypeIdentity.Define($"{basename}{w}x{kind.Format()}");

        /// <summary>
        /// 
        /// </summary>
        /// <param name="basename">The base name of the resource</param>
        /// <param name="w1">The first bit width</param>
        /// <param name="w2">The second bit width</param>
        /// <param name="kind">The numeric kind of the resource</param>
        [MethodImpl(Inline)]
        public static TypeIdentity Resource(string basename, ITypeWidth w1, ITypeWidth w2, NumericKind kind)
            => TypeIdentity.Define($"{basename}{w1}x{w2}x{kind.Format()}");

        /// <summary>
        /// Defines a numeric resource identity predicated on natural bitwidth
        /// </summary>
        /// <param name="basename">The base name of the resource</param>
        /// <param name="w">The resource bit width</param>
        /// <param name="kind">The numeric kind of the resource</param>
        [MethodImpl(Inline)]
        public static TypeIdentity Resource(string basename, ITypeNat w, NumericKind kind)
            => TypeIdentity.Define($"{basename}{w}x{kind.Format()}");

        /// <summary>
        /// Defines a numeric resource identity predicated on two natural bitwidths
        /// </summary>
        /// <param name="basename">The base name of the resource</param>
        /// <param name="w1">The first bit width</param>
        /// <param name="w2">The second bit width</param>
        /// <param name="kind">The numeric kind of the resource</param>
        [MethodImpl(Inline)]
        public static TypeIdentity Resource(string basename, ITypeNat w1, ITypeNat w2, NumericKind kind)
            => TypeIdentity.Define($"{basename}{w1}x{w2}x{kind.Format()}");   

    }
}