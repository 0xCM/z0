//-----------------------------------------------------------------------------
// Derivative Work
// Origin:    : https://github.com/microsoft/scalar
// Copyright  : Microsoft/.Net foundation
// Copyright  : (c) Chris Moore, 2020
// License    :  MIT
//-----------------------------------------------------------------------------
namespace Z0.X.Events
{
    using System;

    public interface ITracer : IDisposable
    {
        ITracer StartActivity(string activityName, EventLevel level);

        ITracer StartActivity(string activityName, EventLevel level, EventMetadata metadata);

        ITracer StartActivity(string activityName, EventLevel level, EventKeys startStopKeywords, EventMetadata metadata);

        void RelatedEvent(EventLevel level, string eventName, EventMetadata metadata);

        void RelatedEvent(EventLevel level, string eventName, EventMetadata metadata, EventKeys keywords);

        void RelatedInfo(string message);

        void RelatedInfo(string format, params object[] args);

        void RelatedInfo(EventMetadata metadata, string message);

        void RelatedWarning(EventMetadata metadata, string message);

        void RelatedWarning(EventMetadata metadata, string message, EventKeys keywords);

        void RelatedWarning(string message);

        void RelatedWarning(string format, params object[] args);

        void RelatedError(EventMetadata metadata, string message);

        void RelatedError(EventMetadata metadata, string message, EventKeys keywords);

        void RelatedError(string message);

        void RelatedError(string format, params object[] args);

        TimeSpan Stop(EventMetadata metadata);
    }
}