//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    using Free = System.Security.SuppressUnmanagedCodeSecurityAttribute;

    [Free]
    public interface IDataConverter
    {
        PairedTypes ConversionTypes {get;}

        Outcome Convert(object src, out object dst);
    }

    [Free]
    public interface IDataConverter<C> : IDataConverter
    {
        Outcome Convert(C config, object src, out object dst);
    }

    [Free]
    public interface IDataConverter<A,B> : IDataConverter
    {
        PairedTypes IDataConverter.ConversionTypes
            => PairedTypes.define<A,B>();

        Outcome Convert(in A src, out B dst);

        Outcome Convert(in B src, out A dst);

        Outcome IDataConverter.Convert(object src, out object dst)
        {
            var result = Outcome.Failure;
            dst = null;
            var paired = PairedTypes.define<A,B>();
            var tInput = src?.GetType() ?? typeof(void);
            var _dst = default(object);
            if(tInput == paired.TypeA)
            {
                var a = (A)src;
                var b = default(B);
                result = Convert(a, out b);
                if(result)
                    dst = b;
            }
            else if(tInput == paired.TypeB)
            {
                var a = default(A);
                var b = (B)src;
                result = Convert(b, out a);
                if(result)
                    dst = a;
            }

            return result;
        }
    }

    [Free]
    public interface IDataConverter<C,A,B> : IDataConverter<A,B>, IDataConverter<C>
    {
        Outcome Convert(in C config, in A src, out B dst);

        Outcome Convert(in C config, in B src, out A dst);

        Outcome IDataConverter<C>.Convert(C config, object src, out object dst)
        {
            var result = Outcome.Failure;
            dst = null;
            var paired = PairedTypes.define<A,B>();
            var tInput = src?.GetType() ?? typeof(void);
            var _dst = default(object);
            if(tInput == paired.TypeA)
            {
                var a = (A)src;
                var b = default(B);
                result = Convert(config, a, out b);
                if(result)
                    dst = b;
            }
            else if(tInput == paired.TypeB)
            {
                var a = default(A);
                var b = (B)src;
                result = Convert(config, b, out a);
                if(result)
                    dst = a;
            }

            return result;
        }
    }
}