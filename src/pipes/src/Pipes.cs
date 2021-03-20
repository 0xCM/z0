//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using static Part;

    [ApiHost]
    public readonly partial struct Pipes
    {
        const NumericKind Closure = AllNumeric;

        public static Pipeline<S,T> connect<S,T>(IEmitter<S> emitter, IProjector<S,T> projector, IReceiver<T> receiver)
        {
            var connection = new Pipeline<S,T>();
            connection.Emitter = emitter;
            connection.Projector = projector;
            connection.Receiver = receiver;
            connection.Connected = true;
            return connection;
        }
    }
}
