//-----------------------------------------------------------------------------
// Adapted from Iced:https://github.com/0xd4d/iced
// License: See the accompanying license file
//-----------------------------------------------------------------------------
namespace Z0.Asm.Data 
{
    using System;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;
    
    using static Konst;

    using TC = DecoderMemoryTestCase;

    public delegate T[] TestCaseParseFunction<N,T>(N n, FilePath src)
        where N : unmanaged, ITypeNat;

    public interface ITestCaseParser<T>
    {
        T[] Parse(FilePath src);

        int Bitness {get;}
    }

    public interface ITestCaseParser<N,T> : ITestCaseParser<T>
        where N : unmanaged, ITypeNat
    {
        new N Bitness => default;        
        
        int ITestCaseParser<T>.Bitness => (int)Bitness.NatValue;
    }

    public readonly struct TestCaseParser<N,T> : ITestCaseParser<N,T>
        where N : unmanaged, ITypeNat
    {
        readonly TestCaseParseFunction<N,T> ParseFunction;

        [MethodImpl(Inline)]
        public static implicit operator TestCaseParser<N,T>(TestCaseParseFunction<N,T> f)
            => new TestCaseParser<N,T>(f);
        
        [MethodImpl(Inline)]
        internal TestCaseParser(TestCaseParseFunction<N,T> f)
        {
            ParseFunction = f;
        }

        public N Bitness => default;

        public T[] Parse(FilePath src)
            => ParseFunction.Invoke(Bitness,src);
    }

    public class TestCaseParsers
    {
        [MethodImpl(Inline)]
        public static ITestCaseParser<TC> Memory(N16 n)
            => MemoryCaseParser(n);

        [MethodImpl(Inline)]
        public static ITestCaseParser<TC> Memory(N32 n)
            => MemoryCaseParser(n);

        [MethodImpl(Inline)]
        public static ITestCaseParser<TC> Memory(N64 n)
            => MemoryCaseParser(n);

        [MethodImpl(Inline)]
        static TestCaseParser<N,TC> MemoryCaseParser<N>(N n)
            where N : unmanaged, ITypeNat
        {
            TestCaseParseFunction<N,TC> f = MemoryDecoderTestParser.Parse;
            var parser = new TestCaseParser<N,TC>(f);
            return parser;
        }        
    }
}