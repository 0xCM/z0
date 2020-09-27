//-----------------------------------------------------------------------------
// Derivative Work
// Origin:    : https://github.com/microsoft/scalar
// Copyright  : Microsoft/.Net foundation
// Copyright  : (c) Chris Moore, 2020
// License    :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Derivatives.Scalar
{
    using System;
    using System.Collections.Generic;

    public static class TracingConstants
    {
        public static class MessageKey
        {
            public const string ErrorMessage = "ErrorMessage";

            public const string WarningMessage = "WarningMessage";

            public const string InfoMessage = "Message";
        }
    }

    public enum Keywords : long
    {
        None = 1 << 0,

        Network = 1 << 1,

        DEPRECATED = 1 << 2,

        Telemetry = 1 << 3,

        Any = ~0,
    }

    // This is a convenience class to make code around event metadata look nicer.
    // It's more obvious to see EventMetadata than Dictionary<string, object> everywhere.
    public class EventMetadata : Dictionary<string, object>
    {
        public EventMetadata()
        {
        }

        public EventMetadata(Dictionary<string, object> metadata)
            : base(metadata)
        {
        }
    }

    // The default EventLevel is Verbose, which does not go to log files by default.
    // If you want to log to a file, you need to raise EventLevel to at least Informational
    public enum EventLevel
    {
        LogAlways = 0,

        Critical = 1,

        Error = 2,

        Warning = 3,

        Informational = 4,

        Verbose = 5
    }

    public interface ITracer : IDisposable
    {
        ITracer StartActivity(string activityName, EventLevel level);

        ITracer StartActivity(string activityName, EventLevel level, EventMetadata metadata);

        ITracer StartActivity(string activityName, EventLevel level, Keywords startStopKeywords, EventMetadata metadata);

        void SetGitCommandSessionId(string sessionId);

        void RelatedEvent(EventLevel level, string eventName, EventMetadata metadata);

        void RelatedEvent(EventLevel level, string eventName, EventMetadata metadata, Keywords keywords);

        void RelatedInfo(string message);

        void RelatedInfo(string format, params object[] args);

        void RelatedInfo(EventMetadata metadata, string message);

        void RelatedWarning(EventMetadata metadata, string message);

        void RelatedWarning(EventMetadata metadata, string message, Keywords keywords);

        void RelatedWarning(string message);

        void RelatedWarning(string format, params object[] args);

        void RelatedError(EventMetadata metadata, string message);

        void RelatedError(EventMetadata metadata, string message, Keywords keywords);

        void RelatedError(string message);

        void RelatedError(string format, params object[] args);

        TimeSpan Stop(EventMetadata metadata);
    }
}