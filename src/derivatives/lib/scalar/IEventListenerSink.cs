//-----------------------------------------------------------------------------
// Derivative Work
// Origin:    : https://github.com/microsoft/scalar
// Copyright  : Microsoft/.Net foundation
// Copyright  : (c) Chris Moore, 2020
// License    :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Derivatives.Scalar
{
    public interface IEventListenerEventSink
    {
        void OnListenerRecovery(EventListener listener);

        void OnListenerFailure(EventListener listener, string errorMessage);
    }
}
