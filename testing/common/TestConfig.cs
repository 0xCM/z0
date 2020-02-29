//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
        

    public class TestConfig : ITestConfig
    {
        public TestConfig(ITestConfig Defaults)
        {
            this.Defaults = Defaults;
            this.SampleSize = Defaults.SampleSize;
        }

        public int SampleSize {get; private set;}

        public bool TraceEnabled {get; private set;}

        ITestConfig Defaults {get;}

        public virtual ITestConfig Replicate()
            => new TestConfig(Defaults)
            {
                SampleSize = SampleSize,
                TraceEnabled = TraceEnabled
            };

        public ITestConfig<T> Get<T>() 
            where T : unmanaged
                => new TestConfig<T>(Defaults.Get<T>());

        public ITestConfig WithTrace()
        {
            var dst = (TestConfig)Replicate();
            dst.TraceEnabled = true;
            return dst;
        }

        public ITestConfig WithoutTrace()
        {
            var dst = (TestConfig)Replicate();
            dst.TraceEnabled = false;
            return dst;
        }

        public virtual ITestConfig WithSampleSize(int SampleSize)
        {
            var dst = (TestConfig)Replicate();
            dst.SampleSize = SampleSize;
            return dst;
        }

        public override string ToString()
        {
            return $"{nameof(SampleSize)}={SampleSize} | {nameof(TraceEnabled)} = {TraceEnabled}";
        }            
    }

    public class TestConfig<T> : TestConfig, ITestConfig<T>
        where T : unmanaged
    {
        public TestConfig(ITestConfig<T> Defaults)
            : base(Defaults)
        {
            this.Defaults = Defaults;
            this.SampleDomain = SampleDomain;
        }

        ITestConfig<T> Defaults {get;}

        public Interval<T> SampleDomain  {get; private set;}

        public override ITestConfig Replicate()
            => new TestConfig<T>(Defaults){SampleDomain = SampleDomain};
    }

    public readonly struct TestConfigDefaults : 
        ITestConfig<sbyte>,
        ITestConfig<byte>,
        ITestConfig<short>,
        ITestConfig<ushort>,
        ITestConfig<int>,
        ITestConfig<uint>,
        ITestConfig<long>,
        ITestConfig<ulong>,
        ITestConfig<float>,
        ITestConfig<double>
    {
        static readonly TestConfigDefaults TheOnly = default;

        public static ITestConfig Default()
            => TheOnly;

        public static ITestConfig<T> Default<T>()
            where T : unmanaged
                => (ITestConfig<T>)(object)(TheOnly);

        const int SampleSize = Pow2.T06;

        public ITestConfig<T> Get<T>()
            where T : unmanaged
                => Cast.force<ITestConfig<T>>(this);

        public ITestConfig Replicate()
            => new TestConfig(TheOnly);
        public ITestConfig WithSampleSize(int SampleSize)
            => Replicate().WithSampleSize(SampleSize);

        public ITestConfig WithTrace()
            => Replicate().WithTrace();

        public ITestConfig WithoutTrace()
            => Replicate().WithoutTrace();

        int ISampleDefaults.SampleSize 
            => SampleSize;

        bool ITestConfig.TraceEnabled 
            => true;

        const sbyte Int8Min = sbyte.MinValue;

        const sbyte Int8Max = sbyte.MaxValue;

        static readonly Interval<sbyte> Int8Domain = Numeric.domain(Int8Min,Int8Max);

        Interval<sbyte> ISampleDefaults<sbyte>.SampleDomain 
            => Int8Domain;

        const byte UInt8Min = byte.MinValue;

        const byte UInt8Max = byte.MaxValue;

        static readonly Interval<byte> UInt8Domain = Numeric.domain(UInt8Min,UInt8Max);

        Interval<byte> ISampleDefaults<byte>.SampleDomain 
            => UInt8Domain;

        const short Int16Min = short.MinValue;
        
        const short Int16Max = short.MaxValue;

        static readonly Interval<short> Int16Domain = Numeric.domain(Int16Min,Int16Max);

        Interval<short> ISampleDefaults<short>.SampleDomain 
            => Int16Domain;

        const ushort UInt16Min = 0;
        
        const ushort UInt16Max = 30000;

        static readonly Interval<ushort> UInt16Range = Numeric.domain(UInt16Min,UInt16Max);

        Interval<ushort> ISampleDefaults<ushort>.SampleDomain 
            => UInt16Range;

        const int Int32Min = -250000;
        
        const int Int32Max = 250000;

        static readonly Interval<int> Int32Domain = Numeric.domain(Int32Min,Int32Max);

        Interval<int> ISampleDefaults<int>.SampleDomain 
            => Int32Domain;

        const uint UInt32Min = 0;
        
        const uint UInt32Max = 500000;

        static readonly Interval<uint> UInt32Domain = Numeric.domain(UInt32Min,UInt32Max);

        Interval<uint> ISampleDefaults<uint>.SampleDomain 
            => UInt32Domain;
 
        const long Int64Min = -250000;
        
        const long Int64Max = 250000;

        static readonly Interval<long> Int64Domain = Numeric.domain(Int64Min,Int64Max);

        Interval<long> ISampleDefaults<long>.SampleDomain 
            => Int64Domain;

        const ulong UInt64Min = 0;
        
        const ulong UInt64Max = 500000;

        static readonly Interval<ulong> UInt64Domaim = Numeric.domain(UInt64Min,UInt64Max);

        Interval<ulong> ISampleDefaults<ulong>.SampleDomain 
            => UInt64Domaim;


        const float Float32Min = -250000.00f;
        
        const float Float32Max = 250000.00f;

        static readonly Interval<float> Float32Domain = Numeric.domain(Float32Min,Float32Max);

        Interval<float> ISampleDefaults<float>.SampleDomain 
            => Float32Domain;


        const double Float64Min = -250000.00;
        
        const double Float64Max = 250000.00;

        static readonly Interval<double> Float64Domain = Numeric.domain(Float64Min,Float64Max);

        Interval<double> ISampleDefaults<double>.SampleDomain 
            => Float64Domain;
    }
}