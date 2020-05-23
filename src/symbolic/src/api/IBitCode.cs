//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{        
    using System;
    using System.Runtime.CompilerServices;

    using static Seed;

    public interface IBitCode : ITextual
    {
        Octet Kind {get;}        
    }

    public interface IBitCode<B> : IBitCode
        where B : unmanaged, IBitCode<B>
    {

    }

    public interface IBit : IBitCode
    {

    }

    public interface IBit<B> : IBit, IBitCode<B>
        where B : unmanaged, IBit<B>
    {
        new BitKind Kind {get;}

        Octet IBitCode.Kind => (Octet)Kind;

        string ITextual.Format() => Kind.ToString();

    }

    public interface IDuet : IBitCode
    {

    }
    public interface IDuet<B> : IDuet, IBitCode<B>
        where B : unmanaged, IDuet<B>
    {
        new Duet Kind {get;}

        Octet IBitCode.Kind => (Octet)Kind;

        string ITextual.Format() => Kind.ToString();
    }

    public interface ITriad: IBitCode
    {

    }
    public interface ITriad<B> : ITriad, IBitCode<B>
        where B : unmanaged, ITriad<B>
    {
        new Triad Kind {get;}

        Octet IBitCode.Kind => (Octet)Kind;

        string ITextual.Format() => Kind.ToString();
    }    

    public interface IQuartet : IBitCode
    {

    }
    public interface IQuartet<B> : IQuartet, IBitCode<B>
        where B : unmanaged, IQuartet<B>
    {
        new Quartet Kind {get;}

        Octet IBitCode.Kind => (Octet)Kind;

        string ITextual.Format() => Kind.ToString();
    }        

    public interface IQuintet: IBitCode
    {

    }
    
    public interface IQuintet<B> : IQuintet, IBitCode<B>
        where B : unmanaged, IQuintet<B>
    {
        new Quintet Kind {get;}

        Octet IBitCode.Kind => (Octet)Kind;

        string ITextual.Format() => Kind.ToString();
    }            

    public interface IOctet : IBitCode
    {

    }

    public interface IOctet<B> : IOctet, IBitCode<B>
        where B : unmanaged, IOctet<B>
    {        

        string ITextual.Format() => Kind.ToString();
    }            

}