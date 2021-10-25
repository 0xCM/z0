//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Eval
{
    using RFM = ExprFormats;

    public readonly partial struct api
    {
       public static string format<S,T>(in OpEvalCapture<S,T> src)
            => string.Format(RFM.Eval, src.Actor.OpName, src.Input, src.Output);

        public static string format<S>(in OpEvalCapture<S> src)
            => string.Format(RFM.Eval, src.Actor.OpName, src.Input, src.Output);

        public static string format<O,S,T>(in OpEvalCapture<O,S,T> src)
            where O : IOp
                => string.Format(RFM.Eval, src.Actor.OpName, src.Input, src.Output);

        public static string format(in OpEvalCapture src)
            => string.Format(RFM.Eval, src.Actor.OpName, src.Input, src.Output);
    }
}