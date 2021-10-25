//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Expr
{
    using Free = System.Security.SuppressUnmanagedCodeSecurityAttribute;

    [Free]
    public interface IOpEval
    {
        Outcome<OpEvalCapture> Evaluate(IOp op);
    }

    [Free]
    public interface IOpEval<S> : IOpEval
    {
        S Body {get;}

        IOpSvc<S> OpSvc {get;}

        Outcome<OpEvalCapture<S>> Evaluate(IOp<S> op)
        {
            var success = OpSvc.Eval(Body, out var output);
            if(success)
                return new OpEvalCapture<S>(op, Body, output);
            else
                return false;
        }

        Outcome<OpEvalCapture> IOpEval.Evaluate(IOp op)
        {
            var outcome = Evaluate((IOp<S>)op);
            return outcome ? new Outcome<OpEvalCapture>(true,outcome.Data) : false;
        }
    }

    [Free]
    public interface IOpEval<S,T> : IOpEval<S>
    {
        new IOpSvc<S,T> OpSvc {get;}

        Outcome<OpEvalCapture<S,T>> Evaluate(IOp<S,T> op)
        {
            var success = OpSvc.Eval(Body, out var output);
            if(success)
                return new OpEvalCapture<S,T>(op, Body, output);
            else
                return false;
        }

        Outcome<OpEvalCapture<S>> IOpEval<S>.Evaluate(IOp<S> op)
        {
            var outcome = Evaluate((IOp<S,T>)op);
            if(outcome)
            {
                var data = outcome.Data;
                return new Outcome<OpEvalCapture<S>>(true,
                    new OpEvalCapture<S>(data.Actor, data.Input, data.Output)
                    );
            }
            else
                return false;
        }
    }

    public interface IExprEval<O,S,T> : IOpEval<S,T>
        where O : IOp<S,T>
    {
        Outcome<OpEvalCapture<O,S,T>> Evaluate(O op)
        {
            var success = OpSvc.Eval(Body, out var output);
            if(success)
                return new OpEvalCapture<O,S,T>(op, Body, output);
            else
                return false;
        }

        Outcome<OpEvalCapture<S,T>> IOpEval<S,T>.Evaluate(IOp<S,T> e)
        {
            var outcome = Evaluate((O)e);
            if(outcome)
            {
                var data = outcome.Data;
                return new Outcome<OpEvalCapture<S,T>>(true,
                    new OpEvalCapture<S,T>(data.Actor, data.Input, data.Output)
                    );
            }
            else
                return false;
        }
    }
}