//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using Free = System.Security.SuppressUnmanagedCodeSecurityAttribute;

    /// <summary>
    /// Characterizes a serice that computes a result and which may have other side-effects
    /// </summary>
    [Free]
    public interface IDataProcessor
    {
        Outcome<dynamic> Run();

        void Inject(dynamic context);

    }

    /// <summary>
    /// Characterizes a processor that computes a payload of parametric type
    /// </summary>
    /// <typeparam name="R">The result type</typeparam>
    [Free]
    public interface IDataProcessor<R> : IDataProcessor
    {
        new Outcome<R> Run();

        void IDataProcessor.Inject(dynamic context){}

        Outcome<dynamic> IDataProcessor.Run()
        {
            var typed = Run();
            var untyped = new Outcome(typed.Ok, typed.Message, typed.MessageCode);
            return new Outcome<dynamic>(untyped, typed.Data);
        }
    }

    /// <summary>
    /// Characterizes a processor that requires contexutal data to function
    /// </summary>
    /// <typeparam name="C">The context type</typeparam>
    /// <typeparam name="R">The payload type</typeparam>
    public interface IDataProcessor<C,R> : IDataProcessor<R>
    {
        void Inject(in C context);

        void IDataProcessor.Inject(dynamic context)
            => Inject((C)context);
    }

}