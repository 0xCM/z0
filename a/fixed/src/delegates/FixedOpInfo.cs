//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Security;

    public static class FixedOpInfo
    {
        public static FixedOpInfo<W8,Emitter8,Fixed8> Emitter8 => default;

        public static FixedOpInfo<W16,Emitter16,Fixed16> Emitter16 => default;

        public static FixedOpInfo<W32,Emitter32,Fixed32> Emitter32 => default;

        public static FixedOpInfo<W64,Emitter64,Fixed64> Emitter64 => default;

        public static FixedOpInfo<W128,Emitter128V,Fixed128V> Emitter128 => default;

        public static FixedOpInfo<W256,Emitter256V,Fixed256V> Emitter256 => default;

        public static FixedOpInfo<W512,Emitter512V,Fixed512V> Emitter512 => default;

        public static FixedOpInfo<W8,UnaryOp8,Fixed8> UnaryOp8 => default;

        public static FixedOpInfo<W16,UnaryOp16,Fixed16> UnaryOp16 => default;

        public static FixedOpInfo<W32,UnaryOp32,Fixed32> UnaryOp32 => default;

        public static FixedOpInfo<W64,UnaryOp64,Fixed64> UnaryOp64 => default;

        public static FixedOpInfo<W128,UnaryOp128V,Fixed128V> UnaryOp128 => default;

        public static FixedOpInfo<W256,UnaryOp256V,Fixed256V> UnaryOp256 => default;

        public static FixedOpInfo<W512,UnaryOp512V,Fixed512V> UnaryOp512 => default;

        public static FixedOpInfo<W8,UnaryPredicate8,Fixed8> UnaryPredicate8 => default;

        public static FixedOpInfo<W16,UnaryPredicate16,Fixed16> UnaryPredicate16 => default;

        public static FixedOpInfo<W32,UnaryPredicate32,Fixed32> UnaryPredicate32 => default;

        public static FixedOpInfo<W64,UnaryPredicate64,Fixed64> UnaryPredicate64 => default;

        public static FixedOpInfo<W128,UnaryPredicate128V,Fixed128V> UnaryPredicate128 => default;

        public static FixedOpInfo<W256,UnaryPredicate256V,Fixed256V> UnaryPredicate256 => default;

        public static FixedOpInfo<W512,UnaryPredicate512V,Fixed512V> UnaryPredicate512 => default;

        public static FixedOpInfo<W8,BinaryOp8,Fixed8> BinaryOp8 => default;

        public static FixedOpInfo<W16,BinaryOp16,Fixed16> BinaryOp16 => default;

        public static FixedOpInfo<W32,BinaryOp32,Fixed32> BinaryOp32 => default;

        public static FixedOpInfo<W64,BinaryOp64,Fixed64> BinaryOp64 => default;

        public static FixedOpInfo<W128,BinaryOp128V,Fixed128V> BinaryOp128 => default;

        public static FixedOpInfo<W256,BinaryOp256V,Fixed256V> BinaryOp256 => default;

        public static FixedOpInfo<W512,BinaryOp512V,Fixed512V> BinaryOp512 => default;

        public static FixedOpInfo<W8,BinaryPredicate8,Fixed8> BinaryPredicate8 => default;

        public static FixedOpInfo<W16,BinaryPredicate16,Fixed16> BinaryPredicate16 => default;

        public static FixedOpInfo<W32,BinaryPredicate32,Fixed32> BinaryPredicate32 => default;

        public static FixedOpInfo<W64,BinaryPredicate64,Fixed64> BinaryPredicate64 => default;

        public static FixedOpInfo<W128,BinaryPredicate128V,Fixed128V> BinaryPredicate128 => default;

        public static FixedOpInfo<W256,BinaryPredicate256V,Fixed256V> BinaryPredicate256 => default;

        public static FixedOpInfo<W512,BinaryPredicate512V,Fixed512V> BinaryPredicate512 => default;
    }

    public readonly struct FixedOpInfo<W,D,T>
        where W : unmanaged, IFixedWidth
        where D : Delegate
        where T : IFixed
    {
        public Type DelegateType => typeof(D);

        public Type FixedType => typeof(T);

        public FixedWidth Width => Widths.fwidth<W>();
    }

}